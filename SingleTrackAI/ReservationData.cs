using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ColossalFramework;
using ICities;


namespace SingleTrackAI
{

    public class SingleTrack2WSection
    {
        public List<ushort> segment_ids = new List<ushort>();

        public bool containStopStation = false;

        //public int notFromPathSegmentsStartingAt = -1;

        public bool Compare(SingleTrack2WSection other)
        {
            return this.segment_ids[0] == other.segment_ids[0] && this.segment_ids[this.segment_ids.Count - 1] == other.segment_ids[other.segment_ids.Count - 1];
        }

        public bool StartsWith(ushort segment_id)
        {
            return this.segment_ids[0] == segment_id;
        }
    }

    public enum ReservationStatus
    {
        Ineffective,
        BeforeTrainEnter,
        TrainOnSection,
        TrainEnterOrSkipStation,
        TrainAtStation,
        TrainExitStation,
        ClearingTrack,
        RecycleForPendingTrain
    }

    [System.Serializable]
    public class ReservationInfo
    {
        public static ushort ID_counter = 0;

        public ushort ID = 0;

        public ReservationStatus status = ReservationStatus.Ineffective;

        public SingleTrack2WSection section;
        public List<ushort> train_ids = new List<ushort>();
        public List<ushort> pending_train_ids = new List<ushort>();
        public List<ushort> train_at_station_ids = new List<ushort>();
        public bool refuse_following_trains = false;

        public uint clearing_timer = 0;

        public ReservationInfo()
        {
            ID_counter++;
            ID = ID_counter;
        }

        public void Recycle()
        {
            //ID_counter++;
            //ID = ID_counter;

            train_ids.Clear();
            //pending_train_ids.Clear();
            refuse_following_trains = false;
            section = null;
            clearing_timer = 0;
            status = ReservationStatus.Ineffective;
        }

    }

    [System.Serializable]
    public struct ReservedSegment
    {
        public ushort segment_id;
        public ushort reservation_id;
    }

    public class ReservationData : MonoBehaviour
    {

        public List<ReservationInfo> reservations = new List<ReservationInfo>();
        public Dictionary<ushort, ReservationInfo> cached_reservations = new Dictionary<ushort, ReservationInfo>();
        public List<ReservedSegment> reservedSegments = new List<ReservedSegment>();

        /********** list managing methods ***********/

        public bool CheckAndAddReservedSegment(ushort segment_id, ushort reservation_id)
        {
            bool include = true;
            bool reserved = false;
            for (int i = 0; i < reservedSegments.Count; i++)
            {
                if (reservedSegments[i].segment_id == segment_id)
                {
                    if (reservedSegments[i].reservation_id == 0)
                    {
                        ReservedSegment rs = reservedSegments[i];
                        rs.reservation_id = reservation_id;
                        reservedSegments[i] = rs;
                        //CODebug.Log(LogChannel.Modding, "changed segment " + segment_id + " for vehicle " + vehicle_id);
                        reserved = true;
                    }
                    include = false;
                    break;
                }
            }

            if (include)
            {
                ReservedSegment rs = new ReservedSegment();
                rs.segment_id = segment_id;
                rs.reservation_id = reservation_id;
                reservedSegments.Add(rs);
                //CODebug.Log(LogChannel.Modding, "added segment "+ segment_id+ " for vehicle "+ vehicle_id);
                reserved = true;
            }

            return reserved;

        }

        public void RemoveReservation(ushort reservation_id, bool definitive = true)
        {
            

            for(int i = 0; i < reservedSegments.Count; i++)
            {
                if (reservedSegments[i].reservation_id == reservation_id)
                {
                    ReservedSegment rs = reservedSegments[i];
                    rs.reservation_id = 0;
                    reservedSegments[i] = rs;
                }
            }

            if (definitive)
            {
                int r_index = -1;
                for (int i = 0; i < reservations.Count; i++)
                {
                    if (reservations[i].ID == reservation_id)
                    {
                        r_index = i;
                        break;
                    }
                }

                if (r_index == -1)
                    return;

                reservations.RemoveAt(r_index);
            }
        }

        public void ClearCacheForTrain(ushort leading_vehicle_id)
        {
            cached_reservations.Remove(leading_vehicle_id);
        }

    }
}
