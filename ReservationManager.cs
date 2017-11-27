using System;
using System.Collections;
using System.Collections.Generic;
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

        const string TARGET_RAIL_NAME = "Rail1L2W";
        const int CLEAR_RESERVATION_AFTER = 100;
        const int DELETE_RESERVATION_AFTER = 200;
        const int DEFINITIVE_DELETE_RESERVATION_AFTER = 1000;

        public static bool IsSingleTrack2WSegment(ushort segment_id)
        {
            return Singleton<NetManager>.instance.m_segments.m_buffer[segment_id].Info.name.Contains(TARGET_RAIL_NAME);
        }

        /******** reservation creation algorithm ************/

        public SingleTrack2WSection CreateSingleTrack2WSectionFromTrainPath(ushort vehicle_id, ushort segment_id)
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
                        CODebug.Log(LogChannel.Modding, Mod.modName + " - no next path unit ??");
                        return null;
                    }
                    pathunit = instance.m_pathUnits.m_buffer[nextPathUnit];
                }

                PathUnit.Position pathpos;
                //CODebug.Log(LogChannel.Modding, Mod.modName + " - pathunit " + backVehicleData.m_path + " index " + backVehicleData.m_pathPositionIndex + " " + posindex + " getpos " + pathunit.GetPosition(posindex, out pathpos));
                if (!pathunit.GetPosition(posindex, out pathpos))
                    return null;
                
                //activate signal at the end of the single track section
                NetSegment seg = instance3.m_segments.m_buffer[pathpos.m_segment];
                if (Mod.allowSpawnSignals && !seg.Info.name.Contains(TARGET_RAIL_NAME))
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
                    seg.UpdateLanes(pathpos.m_segment, true);
                    instance3.m_segments.m_buffer[pathpos.m_segment] = seg;
                }

                if (!found_inspected_segment)
                {
                    if (pathpos.m_segment == segment_id)
                    {
                        found_inspected_segment = true;
                    }
                }

                if (found_inspected_segment)
                {
                    if (seg.Info.name.Contains(TARGET_RAIL_NAME))
                    {
                        section.segment_ids.Add(pathpos.m_segment);
                        continue_search = true;

                    }
                }

                posindex++;
                segments_ahead_from_vehicle++;
                if (!found_inspected_segment && segments_ahead_from_vehicle < 5)
                    continue_search = true;

            }

            if (section.segment_ids.Count > 0)
            {
               return section;
            }

            return null;
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

        public ushort RegisterNewReservation(SingleTrack2WSection section, ushort leading_vehicle_id)
        {
            ReservationInfo ri = new ReservationInfo();
            ri.section = section;
            return RegisterReservation(ri, leading_vehicle_id, false, -1);


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
            if (!Mod.allowFollowing)
                return false;

            if(!current_reservation.refuse_additional_trains && current_reservation.section.Compare(new_reservation))
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

            if(!current_reservation.refuse_additional_trains)
            {
                update = true;
                current_reservation.refuse_additional_trains = true;
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

        public void NotifyReservation(ushort vehicle_id, ushort segment_id, bool train_on_segment)
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
                    if (train_on_segment && ri.status == ReservationStatus.BeforeTrainEnter)
                    {
                       ri.status = ReservationStatus.TrainOnSection;
                    }
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
            //CODebug.Log(LogChannel.Modding, "reservation count " + m_data.m_reservations.Count);
            for (int r_index = m_data.reservations.Count-1; r_index >= 0; r_index--)
            {
                ReservationInfo ri = m_data.reservations[r_index];
                if (ri.clearing_timer > CLEAR_RESERVATION_AFTER && ri.status != ReservationStatus.BeforeTrainEnter)
                {
                    ri.status = ReservationStatus.ClearingTrack;
                }

                ri.clearing_timer++;

                if(ri.clearing_timer > DELETE_RESERVATION_AFTER)
                {
                    //check if there is a train in the pending list, and let some time for this train to do teh reservation
                    if (ri.status != ReservationStatus.RecycleForPendingTrain && ri.clearing_timer < DEFINITIVE_DELETE_RESERVATION_AFTER &&  m_data.reservations[r_index].pending_train_ids.Count > 0)
                    {
                        ri.status = ReservationStatus.RecycleForPendingTrain;
                        m_data.reservations[r_index] = ri;
                    }
                    //first pending train did not reserve (it could have been removed) go to the next pending train
                    else if (ri.clearing_timer >= DEFINITIVE_DELETE_RESERVATION_AFTER && m_data.reservations[r_index].pending_train_ids.Count > 0)
                    {
                        m_data.reservations[r_index].pending_train_ids.RemoveAt(0);
                        ri.clearing_timer = DELETE_RESERVATION_AFTER; //leave some time for next pending train to enter
                        m_data.reservations[r_index] = ri;
                    }

                    //delete reservation object if no pending reservation
                    if ((ri.status == ReservationStatus.ClearingTrack && ri.clearing_timer >= DELETE_RESERVATION_AFTER) || (ri.status == ReservationStatus.RecycleForPendingTrain && m_data.reservations[r_index].pending_train_ids.Count == 0 && ri.clearing_timer >= DELETE_RESERVATION_AFTER) || ri.clearing_timer >= DEFINITIVE_DELETE_RESERVATION_AFTER)
                    {
                        m_data.RemoveReservation(ri.ID);
                    }
                }
                else
                {
                    m_data.reservations[r_index] = ri;
                }
            }
        }

    }
}
