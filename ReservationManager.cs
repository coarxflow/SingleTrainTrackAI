using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using ColossalFramework;
using ICities;

namespace SingleTrackAI
{

    public class ReservationManager : ThreadingExtensionBase
    {
        public static ReservationManager instance;

        private GameObject m_go;
        public ReservationData m_data;

        uint CLEAR_RESERVATION_AFTER = 100;
        uint NEXT_RESERVATION_AFTER = 200;
        uint DELETE_RESERVATION_AFTER = 1000;
        uint DELETE_TRAINATSTATION_RESERVATION_AFTER = 2000;

        float NOT_STOPPED_VELOCITY_SQUARED = 100;

        const int UPDATE_FRAMES_COUNT = 10;

        public static bool IsSingleTrack2WSegment(ushort segment_id)
        {
            return CheckTrainTrackSegment(
                segment_id,
                nameof(IsSingleTrack2WSegment),
                (tracks, tracks_one_way, tracks_two_way, platforms) => tracks == 1 && tracks_two_way == 1);
        }

        public static bool IsSingleTrackStation(ushort segment_id)
        {
            return CheckTrainTrackSegment(
                segment_id,
                nameof(IsSingleTrackStation),
                (tracks, tracks_one_way, tracks_two_way, platforms) => platforms != 0 && tracks == 1);
        }

        public static bool IsDoubleTrackStation(ushort segment_id)
        {
            return CheckTrainTrackSegment(
                segment_id,
                nameof(IsDoubleTrackStation),
                (tracks, tracks_one_way, tracks_two_way, platforms) => platforms != 0 && tracks == 2);
        }

        public static bool IsStation(ushort segment_id)
        {
            return CheckTrainTrackSegment(
                segment_id,
                nameof(IsStation),
                (tracks, tracks_one_way, tracks_two_way, platforms) => platforms != 0 && (tracks == 1 || tracks == 2));
        }

        public static bool RequireReservation(ushort segment_id)
        {
            return CheckTrainTrackSegment(
                segment_id,
                nameof(RequireReservation),
                (tracks, tracks_one_way, tracks_two_way, platforms) => (tracks == 1 && tracks_two_way == 1) ||
                                                                       (platforms != 0 && tracks == 2));
        }

        private static bool CheckTrainTrackSegment(ushort segment_id, string name, Func<int, int, int, int, bool> check_func)
        {
            NetSegment segment = Singleton<NetManager>.instance.m_segments.m_buffer[segment_id];
            NetInfo.Lane[] lanes = segment.Info.m_lanes;

            int tracks = 0;
            int tracks_one_way = 0;
            int tracks_two_way = 0;
            int platforms = 0;

            // Use for instead of foreach since we don't want to allocate memory for the enumerator.
            // ReSharper disable once ForCanBeConvertedToForeach
            for (int i = 0; i < lanes.Length; i++)
            {
                NetInfo.Lane lane = lanes[i];

                switch (lane.m_laneType)
                {
                    case NetInfo.LaneType.Pedestrian:
                        if (lane.m_stopType == VehicleInfo.VehicleType.Train)
                            platforms++;
                        break;

                    case NetInfo.LaneType.Vehicle:
                        if (lane.m_vehicleType == VehicleInfo.VehicleType.Train)
                        {
                            tracks++;

                            switch (lane.m_direction)
                            {
                                case NetInfo.Direction.Forward:
                                    tracks_one_way++;
                                    break;

                                case NetInfo.Direction.Backward:
                                    tracks_one_way++;
                                    break;

                                case NetInfo.Direction.Both:
                                    tracks_two_way++;
                                    break;

                                case NetInfo.Direction.AvoidBackward:
                                    tracks_one_way++;
                                    break;

                                case NetInfo.Direction.AvoidForward:
                                    tracks_one_way++;
                                    break;

                                case NetInfo.Direction.AvoidBoth:
                                    tracks_two_way++;
                                    break;
                            }
                        }

                        break;
                }
            }

            bool result = check_func(tracks, tracks_one_way, tracks_two_way, platforms);

            Debug.Log($"[STTAI] {name}: {segment.Info.name}, tracks {tracks}, one-way {tracks_one_way}, two-way {tracks_two_way}, platforms {platforms}, result {result}");

            return result;
        }

        /******** reservation creation algorithm ************/

        public SingleTrack2WSection CreateSingleTrack2WSectionFromTrainPath(ushort vehicle_id, ushort start_segment_id)
        {
            PathManager instance = Singleton<PathManager>.instance;
            VehicleManager instance2 = Singleton<VehicleManager>.instance;
            NetManager instance3 = Singleton<NetManager>.instance;

            Vehicle vehicleData = instance2.m_vehicles.m_buffer[vehicle_id];
            PathUnit pathunit = instance.m_pathUnits.m_buffer[vehicleData.m_path];
            int posindex = (vehicleData.m_pathPositionIndex >> 1) + 1;
            bool continue_search = true;

            bool found_inspected_segment = false;
            ushort segments_ahead_from_vehicle = 0;

            SingleTrack2WSection section = new SingleTrack2WSection();
            ushort crt_segment_id = 0;

            bool buildOldWay = false;

            //browse successive segments in path for single tracks
            while (continue_search)
            {
                continue_search = false;

                if (posindex >= (int)pathunit.m_positionCount)
                {
                    posindex = 0;
                    uint nextPathUnit = pathunit.m_nextPathUnit;
                    if (nextPathUnit == 0u)
                    {
                        //CODebug.Log(LogChannel.Modding, Mod.modName + " - no next path unit ??");

                        //path is at the end, don't know if train will carry after the station
                        //may add further single track segments along the track
                        buildOldWay = true; //start other algorithm, usually in case of a single track station
                        break;
                    }
                    pathunit = instance.m_pathUnits.m_buffer[nextPathUnit];
                }

                PathUnit.Position pathpos;
                if (!pathunit.GetPosition(posindex, out pathpos))
                    return null;
                crt_segment_id = pathpos.m_segment;

                //activate signal at the end of the single track section
                CheckSpawnSignals(crt_segment_id);

                if (!found_inspected_segment)
                {
                    if (crt_segment_id == start_segment_id)
                    {
                        found_inspected_segment = true;
                    }
                }

                if (found_inspected_segment)
                {
                    if (RequireReservation(crt_segment_id))
                    {
                        section.segment_ids.Add(crt_segment_id);
                        continue_search = true;

                    }
                }

                posindex++;
                segments_ahead_from_vehicle++;
                if (!found_inspected_segment && segments_ahead_from_vehicle < 5)
                    continue_search = true;

            }

            if (buildOldWay && section.segment_ids.Count > 0)
            {
                if(IsStation(section.segment_ids[section.segment_ids.Count-1]))
                {
                    section.containStopStation = true;


                    //Is use of other algo really needed? Train may or may not go further along the track
                    //Other trains check if other reservation further along the path anyway...

                    // -> yes reserving single tracks after station ensure TrainExitStation is properly resolved
                    // There is not a second, separate reservation made (except when branching...)

                    if (Mod.extendReservationAfterStopStation)
                    {
                        //section.notFromPathSegmentsStartingAt = section.segment_ids.Count; //mark that segments further on have not been path checked
                        AppendNextConnectedSegmentTheOldWay(section, section.segment_ids[section.segment_ids.Count - 1]);
                    }
                }

            }

            if (section.segment_ids.Count > 0)
            {
               return section;
            }

            return null;
        }

        static void AppendNextConnectedSegmentTheOldWay(SingleTrack2WSection section, uint segment_id)
        {
            NetManager instance = Singleton<NetManager>.instance;

            int nieghbours_count = 0;
            bool include_segments = false;
            List<ushort> single_lanes = new List<ushort>();

            NetNode node;
            NetSegment seg = instance.m_segments.m_buffer[segment_id];

            List<ushort> nodes_included = new List<ushort>();
            int n = 0;
            nodes_included.Add(seg.m_endNode);
            nodes_included.Add(seg.m_startNode);

            while (nodes_included.Count > n)
            {
                nieghbours_count = 0;
                single_lanes.Clear();
                include_segments = false;

                node = instance.m_nodes.m_buffer[(int)((UIntPtr)nodes_included[n])];

                //find every segments attached to node
                for (int i = 0; i < 8; i++)
                {
                    if (node.GetSegment(i) != 0)
                    {
                        nieghbours_count++;
                        if (RequireReservation(node.GetSegment(i))) //detect 1 lane 2 ways segments
                            single_lanes.Add(node.GetSegment(i));
                    }
                }

                if (nieghbours_count <= 2 && single_lanes.Count > 0) //include single track segments without branching
                    include_segments = true;
                /*else if (nieghbours_count > 2) //include single track segments with branching. All single track 2 ways segments connected together will get booked
                    include_segments = true;*/

                if (include_segments)
                {
                    for (int i = 0; i < single_lanes.Count; i++)
                    {
                        if (!section.segment_ids.Contains(single_lanes[i])) //check not already included
                        {
                            section.segment_ids.Add(single_lanes[i]);

                            //activate signal at the end of the single track section
                            CheckSpawnSignals(single_lanes[i]);

                            //get next nodes
                            seg = instance.m_segments.m_buffer[(int)single_lanes[i]];
                            if (!nodes_included.Contains(seg.m_endNode))
                                nodes_included.Add(seg.m_endNode);
                            if (!nodes_included.Contains(seg.m_startNode))
                                nodes_included.Add(seg.m_startNode);
                        }
                    }
                }
                n++;
            }
        }

        static void CheckSpawnSignals(ushort segment_id)
        {
            NetManager instance3 = Singleton<NetManager>.instance;

            //activate signal at the end of the single track section
            NetSegment seg = instance3.m_segments.m_buffer[segment_id];
            if (Mod.allowSpawnSignals && !IsSingleTrack2WSegment(segment_id))
            {
                NetNode node1 = instance3.m_nodes.m_buffer[seg.m_startNode];
                NetNode node2 = instance3.m_nodes.m_buffer[seg.m_endNode];
                NetLane lane = instance3.m_lanes.m_buffer[seg.m_lanes];

                if ((node1.m_flags & NetNode.Flags.Junction) != (NetNode.Flags)0)
                {


                    seg.m_flags |= NetSegment.Flags.YieldStart;

                }
                if ((node2.m_flags & NetNode.Flags.Junction) != (NetNode.Flags)0)
                {

                    seg.m_flags |= NetSegment.Flags.YieldEnd;
                }
                seg.UpdateLanes(segment_id, true);
                instance3.m_segments.m_buffer[segment_id] = seg;
            }
        }

        /********* reservation management *************/

        public ReservationInfo GetReservationOnSegment(ushort segment_id)
        {
            int s_index = -1;

            for (int i = 0; i < m_data.reservedSegments.Count; i++)
            {
                if (m_data.reservedSegments[i].segment_id == segment_id)
                {
                    s_index = i;
                    break;
                }
            }

            if(s_index == -1)
            {
                return null;
            }

            ushort reservation_id = m_data.reservedSegments[s_index].reservation_id;

            for (int i = 0;  i < m_data.reservations.Count; i++)
            {
                if (m_data.reservations[i].ID == reservation_id)
                {
                    return m_data.reservations[i];
                }
            }

            return null;

        }

        public static bool IsReservationForTrain(ReservationInfo ri, ushort leading_vehicle_id)
        {
            return ri.train_ids.Contains(leading_vehicle_id);
        }

        public ReservationInfo CheckCachedReservation(ushort start_segment, ushort leading_vehicle_id, ref ushort blocking_segment_id)
        {
            ReservationInfo ri;

            if (m_data.cached_reservations.ContainsKey(leading_vehicle_id))
            {
                ri = m_data.cached_reservations[leading_vehicle_id];

                if (ri.section.StartsWith(start_segment))
                    blocking_segment_id = RegisterReservation(ri, leading_vehicle_id, false, -1);
                else
                    ri = null;
            }
            else
                ri = null;

            return ri;
        }

        public ReservationInfo RegisterNewReservation(SingleTrack2WSection section, ushort leading_vehicle_id, ref ushort blocking_segment_id)
        {
            ReservationInfo ri = new ReservationInfo();
            ri.section = section;
            blocking_segment_id = RegisterReservation(ri, leading_vehicle_id, false, -1);

            if (!Mod.allowGoAsFarAsPossible && blocking_segment_id != 0) //cache reservation to avoid recreating it many times in a row
            {
                m_data.ClearCacheForTrain(leading_vehicle_id);
                m_data.cached_reservations.Add(leading_vehicle_id, ri);
            }
            return ri;
        }

        private ushort RegisterReservation(ReservationInfo ri, ushort leading_vehicle_id, bool recycle, int recycle_id)
        {


            int reservation_prevented_at = -1;
            for (int i = 0; i < ri.section.segment_ids.Count; i++)
            {
                if(!m_data.CheckAndAddReservedSegment(ri.section.segment_ids[i], ri.ID))
                {
                    reservation_prevented_at = i;
                    break;
                }
            }

            if (reservation_prevented_at != -1)
            {
                if (!Mod.allowGoAsFarAsPossible) //revert reserved segments (safe approach)
                {
                    m_data.RemoveReservation(ri.ID);
                    return ri.section.segment_ids[reservation_prevented_at];
                }
                else //delete further segments from reservation (go as far as possible approach)
                {
                    ri.section.segment_ids.RemoveRange(reservation_prevented_at, ri.section.segment_ids.Count - reservation_prevented_at);
                }
            }

            //else
            {
                ri.status = ReservationStatus.BeforeTrainEnter;
                ri.train_ids.Add(leading_vehicle_id);

                if(recycle)
                {
                    recycle = false;
                    //actualize data
                    for (int i = 0; i < m_data.reservations.Count; i++)
                    {
                        if (m_data.reservations[i].ID == recycle_id)
                        {
                            m_data.reservations[i] = ri;
                            recycle = true;
                            break;
                        }
                    }
                }

                if (!recycle)
                {
                    m_data.reservations.Add(ri);
                }

                return 0;
            }


        }

        public bool AttemptJoinReservation(ReservationInfo current_reservation, SingleTrack2WSection new_reservation, ushort train_id)
        {
            //do not allow train following if route taken by the train is not guaranteed (train could stop at a station and come back its way for example)
            if (!Mod.allowFollowing || current_reservation.section.containStopStation || new_reservation.containStopStation)
                return false;

            if(!current_reservation.refuse_following_trains && current_reservation.section.Compare(new_reservation))
            {
                current_reservation.train_ids.Add(train_id);

                //actualize data
                for (int i = 0; i < m_data.reservations.Count; i++)
                {
                    if (m_data.reservations[i].ID == current_reservation.ID)
                    {
                        m_data.reservations[i] = current_reservation;
                        break;
                    }
                }

                return true;
            }
            return false;
        }

        public void EnqueueReservation(ReservationInfo current_reservation, ushort train_id)
        {
            if (!Mod.allowPriorityQueue)
                return;


            bool update = false;

            if (!current_reservation.pending_train_ids.Contains(train_id))
            {
                update = true;
                current_reservation.pending_train_ids.Add(train_id);
            }

            if(!current_reservation.refuse_following_trains)
            {
                update = true;
                current_reservation.refuse_following_trains = true;
            }


            if (update)
            {
                //actualize data
                for (int i = 0; i < m_data.reservations.Count; i++)
                {
                    if (m_data.reservations[i].ID == current_reservation.ID)
                    {
                        m_data.reservations[i] = current_reservation;
                        break;
                    }
                }
            }
        }

        public bool AttemptReservationForNextPendingTrain(ReservationInfo current_reservation, SingleTrack2WSection new_reservation, ushort train_id)
        {
            if(current_reservation.status == ReservationStatus.RecycleForPendingTrain && current_reservation.pending_train_ids.Count > 0 && current_reservation.pending_train_ids[0] == train_id)
            {
                ushort old_id = current_reservation.ID;
                m_data.RemoveReservation(old_id, false);
                current_reservation.Recycle();
                current_reservation.pending_train_ids.RemoveAt(0);
                current_reservation.section = new_reservation;
                RegisterReservation(current_reservation, train_id, true, old_id);
                return true;
            }

            return false;
        }

        public void NotifyReservation(ushort vehicle_id, ushort segment_id, bool train_on_segment, Vehicle.Flags arrive_or_leave_station = 0)
        {
            int s_index = -1;
            for (int i = 0; i < m_data.reservedSegments.Count; i++)
            {
                if (m_data.reservedSegments[i].segment_id == segment_id)
                {
                    s_index = i;
                    break;
                }
            }



            if (s_index == -1)
            {
                //CODebug.Log(LogChannel.Modding, Mod.modName + " - no reservation was made for vehicle " + vehicle_id + " on segment " + segment_id);
                return;
            }

            ushort reservation_id = m_data.reservedSegments[s_index].reservation_id;



            for (int r_index = 0; r_index < m_data.reservations.Count; r_index++)
            {
                if (m_data.reservations[r_index].ID == reservation_id && m_data.reservations[r_index].train_ids.Contains(vehicle_id))
                {
                    ReservationInfo ri = m_data.reservations[r_index];

                    //CODebug.Log(LogChannel.Modding, Mod.modName + " - NotifyReservation train_on_segment="+ train_on_segment+ " IsSingleTrackStation="+ IsSingleTrackStation(segment_id)+" arriving at station "+arrive_or_leave_station+" previous status "+ri.status+" for train "+vehicle_id);

                    if (IsStation(segment_id))
                    {
                        if (ri.status != ReservationStatus.TrainAtStation && ri.status != ReservationStatus.TrainExitStation)
                            ri.status = ReservationStatus.TrainEnterOrSkipStation;
                    }
                    else if (train_on_segment) //and not in a station
                    {
                        m_data.ClearCacheForTrain(vehicle_id);
                        ri.status = ReservationStatus.TrainOnSection;
                    }
                    /*else //if next segment and not a station
                    {
                        if (ri.status == ReservationStatus.TrainExitStation)
                            ri.status = ReservationStatus.BeforeTrainEnter;
                    }*/

                    //CODebug.Log(LogChannel.Modding, Mod.modName + " - new status " + ri.status + " for train " + vehicle_id);


                    ri.clearing_timer = 0;
                    m_data.reservations[r_index] = ri;

                    break;
                }
            }

        }

        /*************** simulation update *************/

        public void Initialize()
        {
            if(m_data != null)
            {
                m_data.reservations.Clear();
                m_data.reservedSegments.Clear();
            }
        }


        public override void OnCreated(IThreading threading)
        {
            base.OnCreated(threading);

            ReservationManager.instance = this;

            //create data object
            m_go = new GameObject("SingleTrainTrackAI - ReservationManager");
            m_data = m_go.AddComponent<ReservationData>();

            /*GameObject gameObject = new GameObject(typeof(ReservationManager).Name);
            gameObject.AddComponent<ReservationManager>();
            CODebugBase<InternalLogChannel>.VerboseLog(InternalLogChannel.System, "Creating mono singleton of type " + typeof(T).Name, gameObject);
            UnityEngine.Object.DontDestroyOnLoad(Singleton<T>.sInstance.gameObject);

    */
            if(Mod.slowSpeedTrains)
            {
                CLEAR_RESERVATION_AFTER *= 2;
                NEXT_RESERVATION_AFTER *= 2;
                DELETE_RESERVATION_AFTER *= 2;
                DELETE_TRAINATSTATION_RESERVATION_AFTER *= 2;

                NOT_STOPPED_VELOCITY_SQUARED /= 4;
            }

        }

        public override void OnReleased()
        {

            if (m_go != null)
            {
                UnityEngine.Object.Destroy(m_go);
            }

        }

        public override void OnAfterSimulationFrame()
        {
            if (Singleton<SimulationManager>.instance.m_currentFrameIndex % UPDATE_FRAMES_COUNT != 0)
                return;

            for (int r_index = m_data.reservations.Count-1; r_index >= 0; r_index--)
            {
                ReservationInfo ri = m_data.reservations[r_index];
                if (ri.status == ReservationStatus.TrainOnSection && ri.clearing_timer > CLEAR_RESERVATION_AFTER)
                {
                    ri.status = ReservationStatus.ClearingTrack;
                }

                //check if any train in reservation is stopping at a station
                //at the moment, only one train can be at a station (since its route is unknown)
                if (ri.status == ReservationStatus.TrainEnterOrSkipStation || ri.status == ReservationStatus.TrainAtStation)
                {
                    VehicleManager vm = Singleton<VehicleManager>.instance;
                    foreach (ushort id in ri.train_ids)
                    {
                        Vehicle v = vm.m_vehicles.m_buffer[id];
                        if ((v.m_flags & (Vehicle.Flags.Arriving | Vehicle.Flags.Leaving | Vehicle.Flags.Stopped)) != (Vehicle.Flags)0)
                        {
                            ri.status = ReservationStatus.TrainAtStation;
                            if (!ri.train_at_station_ids.Contains(id))
                                ri.train_at_station_ids.Add(id);
                        }
                        else if (ri.status == ReservationStatus.TrainAtStation && ri.train_at_station_ids.Contains(id))
                        {
                            ri.train_at_station_ids.Remove(id);
                            if (ri.train_at_station_ids.Count == 0)
                                ri.status = ReservationStatus.TrainExitStation;
                        }
                    }
                }
                //do not allow that status stay in exit if train has left (on a double track section for example)
                else if (ri.status == ReservationStatus.TrainExitStation)
                {
                    VehicleManager vm = Singleton<VehicleManager>.instance;
                    bool all_trains_going = true;
                    foreach (ushort id in ri.train_ids)
                    {
                        Vehicle v = vm.m_vehicles.m_buffer[id];
                        if (v.GetLastFrameVelocity().sqrMagnitude < NOT_STOPPED_VELOCITY_SQUARED) //train has not picked a decent speed
                            all_trains_going = false;
                    }
                    if (all_trains_going)
                    {
                        ri.clearing_timer = 0; //leave some time in case train still need reservation and has not notified yet
                        ri.status = ReservationStatus.ClearingTrack;
                    }
                }

                ri.clearing_timer += UPDATE_FRAMES_COUNT;
                m_data.reservations[r_index] = ri;

                if (ri.clearing_timer > NEXT_RESERVATION_AFTER)
                {
                    //check if there is a train in the pending list, and let some time for this train to do teh reservation
                    if (m_data.reservations[r_index].pending_train_ids.Count > 0)
                    {
                        if (ri.status == ReservationStatus.ClearingTrack)
                        {
                            ri.status = ReservationStatus.RecycleForPendingTrain;
                            m_data.reservations[r_index] = ri;
                        }
                        //first pending train did not reserve (it could have been removed) go to the next pending train
                        else if (ri.status == ReservationStatus.RecycleForPendingTrain && ri.clearing_timer >= DELETE_RESERVATION_AFTER)
                        {
                            m_data.reservations[r_index].pending_train_ids.RemoveAt(0);
                            ri.clearing_timer = NEXT_RESERVATION_AFTER; //leave some time for next pending train to enter
                            m_data.reservations[r_index] = ri;
                        }
                    }

                    //delete reservation object if no pending reservation
                    switch(ri.status)
                    {
                        case ReservationStatus.ClearingTrack:
                            m_data.RemoveReservation(ri.ID);
                            break;
                        case ReservationStatus.RecycleForPendingTrain:
                            if(m_data.reservations[r_index].pending_train_ids.Count == 0)
                                m_data.RemoveReservation(ri.ID);
                            break;
                        case ReservationStatus.TrainAtStation:
                            if (ri.clearing_timer >= DELETE_TRAINATSTATION_RESERVATION_AFTER)
                                m_data.RemoveReservation(ri.ID);
                            break;
                        default:
                            if(ri.clearing_timer >= DELETE_RESERVATION_AFTER)
                                m_data.RemoveReservation(ri.ID);
                            break;
                    }
                }
            }
        }

    }
}
