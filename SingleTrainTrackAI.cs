
using ColossalFramework;
using ColossalFramework.Math;
using UnityEngine;
using System;

using System.Collections.Generic;

namespace SingleTrackAI
{

    

    public class SingleTrainTrackAI : VehicleAI
    {

        public static String MOD_NAME = "SingleTrainTrackAI";

        

        private bool CheckSingleTrack2Ways(ushort vehicleID, Vehicle vehicleData, ref float maxSpeed, uint laneID, uint prevLaneID)
        {
            NetManager instance = Singleton<NetManager>.instance;
            ushort next_segment_id = instance.m_lanes.m_buffer[(int)((UIntPtr)laneID)].m_segment;
            ushort crt_segment_id = instance.m_lanes.m_buffer[(int)((UIntPtr)prevLaneID)].m_segment;

            ReservationManager instance2 = ReservationManager.instance;

            ushort leadingVehicleID = vehicleData.GetFirstVehicle(vehicleID);

            if (ReservationManager.IsSingleTrack2WSegment(crt_segment_id)) //train carriage is on a one lane section
            {
                instance2.NotifyReservation(leadingVehicleID, crt_segment_id, true);
            }

            if (ReservationManager.IsSingleTrack2WSegment(next_segment_id)) //train carriage will enter a one lane section
            {

                ReservationInfo ri = instance2.GetReservationOnSegment(next_segment_id);
                if (ri == null) //reserve track if it is not reserved by any train
                {
                    SingleTrack2WSection section = instance2.CreateSingleTrack2WSectionFromTrainPath(leadingVehicleID, next_segment_id);
                    if(section != null)
                    {
                        ushort blocking_segmentID = ReservationManager.instance.RegisterNewReservation(section, leadingVehicleID);
                        if(blocking_segmentID != 0) //reservation blocked by a further segment already reserved, get this reservation
                        {
                            ri = instance2.GetReservationOnSegment(blocking_segmentID);
                            /*ReservationManager.instance.EnqueueReservation(ri, leadingVehicleID);
                            maxSpeed = 0f;
                            return true;*/
                        }
                    }
                }

                if(ri == null) //should not happen
                {
                    return false;
                }

                if (ReservationManager.IsReservationForTrain(ri, leadingVehicleID)) //track is reserved for this vehicle
                {
                    instance2.NotifyReservation(leadingVehicleID, crt_segment_id, false);

                    //reset wait counter
                   /* if((vehicleData.m_flags2 & Vehicle.Flags2.Yielding) != (Vehicle.Flags2) 0)
                    {
                        vehicleData.m_flags2 &= ~Vehicle.Flags2.Yielding;
                        vehicleData.m_waitCounter = 0;
                    }*/
                    

                    //return true so that CheckNextLane does not interfere (it causes train to stop when going from one track to double track with a train waiting in the opposite direction)
                    if (Mod.noCheckOverlapOnLastSegment && next_segment_id == ri.section.segment_ids[ri.section.segment_ids.Count-1])
                        return true;
                }
                else //section reserved by another train
                {
                    SingleTrack2WSection section = instance2.CreateSingleTrack2WSectionFromTrainPath(leadingVehicleID, next_segment_id);
                    if (!(section != null && ReservationManager.instance.AttemptJoinReservation(ri, section, leadingVehicleID))) //can train follow the previous one?
                    {
                        if (!(section != null && ReservationManager.instance.AttemptReservationForNextPendingTrain(ri, section, leadingVehicleID))) //has section been cleared?
                        {
                            //not allowed on this track, stop
                            ReservationManager.instance.EnqueueReservation(ri, leadingVehicleID);
                            maxSpeed = 0f;

                            //increment wait counter
                            /*vehicleData.m_flags2 |= Vehicle.Flags2.Yielding;
                            vehicleData.m_waitCounter++;*/

                            //set traffic light state
                            /*NetSegment seg = instance.m_segments.m_buffer[crt_segment_id];
                            RoadBaseAI.SetTrafficLightState(seg.m_endNode, ref seg, 0, RoadBaseAI.TrafficLightState.Red, RoadBaseAI.TrafficLightState.Red, true, false);
                            RoadBaseAI.SetTrafficLightState(seg.m_startNode, ref seg, 0, RoadBaseAI.TrafficLightState.Red, RoadBaseAI.TrafficLightState.Red, true, false);
                            instance.m_nodes.m_buffer[seg.m_endNode].m_flags |= NetNode.Flags.TrafficLights;
                            instance.m_nodes.m_buffer[seg.m_startNode].m_flags |= NetNode.Flags.TrafficLights;

                            /*if (vehicleID == leadingVehicleID)
                            {
                                instance.m_segments.m_buffer[crt_segment_id].m_trafficLightState0 = (byte) RoadBaseAI.TrafficLightState.Red;
                            }*/
                            return true;
                        }
                    }
                }
                

            }

            return false;
        }

        private void NotifySingleTrack2Ways(ushort vehicleID, Vehicle vehicleData, uint laneID)
        {
            NetManager instance = Singleton<NetManager>.instance;
            ushort crt_segment_id = instance.m_lanes.m_buffer[(int)((UIntPtr)laneID)].m_segment;

            ReservationManager instance2 = ReservationManager.instance;

            ushort leadingVehicleID = vehicleData.GetFirstVehicle(vehicleID);

            if (ReservationManager.IsSingleTrack2WSegment(crt_segment_id)) //train carriage is on a one lane section
            {
                instance2.NotifyReservation(leadingVehicleID, crt_segment_id, true);
            }

            //CODebug.Log(LogChannel.Modding, Mod.modName + " - notify for vehicle " + vehicleID + " on segment " + crt_segment_id +" at frame "+Singleton<SimulationManager>.instance.m_currentFrameIndex);
        }


        //from source code
        protected void UpdatePathTargetPositions(ushort vehicleID, ref Vehicle vehicleData, Vector3 refPos1, Vector3 refPos2, ushort leaderID, ref Vehicle leaderData, ref int index, int max1, int max2, float minSqrDistanceA, float minSqrDistanceB)
        {
            PathManager instance = Singleton<PathManager>.instance;
            NetManager instance2 = Singleton<NetManager>.instance;

            Vector4 vector = vehicleData.m_targetPos0;
            vector.w = 1000f;
            float num = minSqrDistanceA;
            float num2 = 0f;
            uint num3 = vehicleData.m_path;
            byte b = vehicleData.m_pathPositionIndex;
            byte b2 = vehicleData.m_lastPathOffset;
            if (b == 255)
            {
                b = 0;
                if (index <= 0)
                {
                    vehicleData.m_pathPositionIndex = 0;
                }
                if (!Singleton<PathManager>.instance.m_pathUnits.m_buffer[(int)((UIntPtr)num3)].CalculatePathPositionOffset(b >> 1, vector, out b2))
                {
                    this.InvalidPath(vehicleID, ref vehicleData, leaderID, ref leaderData);
                    return;
                }
            }
            PathUnit.Position position;
            if (!instance.m_pathUnits.m_buffer[(int)((UIntPtr)num3)].GetPosition(b >> 1, out position))
            {
                this.InvalidPath(vehicleID, ref vehicleData, leaderID, ref leaderData);
                return;
            }
            uint num4 = PathManager.GetLaneID(position);
            //try to notify for all vehicles composing the train. however, UpdatePathTargetPositions is not called when train is stopped
            //this.NotifySingleTrack2Ways(vehicleID, vehicleData, num4);
            Bezier3 bezier;
            while (true)
            {
                if ((b & 1) == 0) //is pathPositionIndex even?
                {
                    bool flag = true;
                    while (b2 != position.m_offset)
                    {
                        if (flag)
                        {
                            flag = false;
                        }
                        else
                        {
                            float num5 = Mathf.Max(Mathf.Sqrt(num) - Vector3.Distance(vector, refPos1), Mathf.Sqrt(num2) - Vector3.Distance(vector, refPos2));
                            int num6;
                            if (num5 < 0f)
                            {
                                num6 = 4;
                            }
                            else
                            {
                                num6 = 4 + Mathf.CeilToInt(num5 * 256f / (instance2.m_lanes.m_buffer[(int)((UIntPtr)num4)].m_length + 1f));
                            }
                            if (b2 > position.m_offset)
                            {
                                b2 = (byte)Mathf.Max((int)b2 - num6, (int)position.m_offset);
                            }
                            else if (b2 < position.m_offset)
                            {
                                b2 = (byte)Mathf.Min((int)b2 + num6, (int)position.m_offset);
                            }
                        }
                        Vector3 a;
                        Vector3 vector2;
                        float b3;
                        this.CalculateSegmentPosition(vehicleID, ref vehicleData, position, num4, b2, out a, out vector2, out b3);
                        vector.Set(a.x, a.y, a.z, Mathf.Min(vector.w, b3));
                        float sqrMagnitude = (a - refPos1).sqrMagnitude;
                        float sqrMagnitude2 = (a - refPos2).sqrMagnitude;
                        if (sqrMagnitude >= num && sqrMagnitude2 >= num2)
                        {
                            if (index <= 0)
                            {
                                vehicleData.m_lastPathOffset = b2;
                            }
                            vehicleData.SetTargetPos(index++, vector);
                            if (index < max1)
                            {
                                num = minSqrDistanceB;
                                refPos1 = vector;
                            }
                            else if (index == max1)
                            {
                                num = (refPos2 - refPos1).sqrMagnitude;
                                num2 = minSqrDistanceA;
                            }
                            else
                            {
                                num2 = minSqrDistanceB;
                                refPos2 = vector;
                            }
                            vector.w = 1000f;
                            if (index == max2)
                            {
                                return;
                            }
                        }
                    }
                    b += 1;
                    b2 = 0;
                    if (index <= 0)
                    {
                        vehicleData.m_pathPositionIndex = b;
                        vehicleData.m_lastPathOffset = b2;
                    }
                }
                int num7 = (b >> 1) + 1; //pathPositionIndex is divided by 2 to get the final position index
                uint num8 = num3;
                if (num7 >= (int)instance.m_pathUnits.m_buffer[(int)((UIntPtr)num3)].m_positionCount)
                {
                    num7 = 0;
                    num8 = instance.m_pathUnits.m_buffer[(int)((UIntPtr)num3)].m_nextPathUnit;
                    if (num8 == 0u)
                    {
                        goto Block_19;
                    }
                }
                PathUnit.Position position2;
                if (!instance.m_pathUnits.m_buffer[(int)((UIntPtr)num8)].GetPosition(num7, out position2))
                {
                    goto Block_21;
                }
                NetInfo info = instance2.m_segments.m_buffer[(int)position2.m_segment].Info;
                if (info.m_lanes.Length <= (int)position2.m_lane)
                {
                    goto Block_22;
                }
                uint laneID = PathManager.GetLaneID(position2);
                NetInfo.Lane lane = info.m_lanes[(int)position2.m_lane];
                if (lane.m_laneType != NetInfo.LaneType.Vehicle)
                {
                    goto Block_23;
                }
                if (position2.m_segment != position.m_segment && leaderID != 0)
                {
                    leaderData.m_flags &= ~Vehicle.Flags.Leaving;
                }
                byte b4 = 0;

                if (num4 != laneID) //num4 is last path lane, laneID is the new one. This triggers checkNextLane.
                {
                    PathUnit.CalculatePathPositionOffset(laneID, vector, out b4);
                    bezier = default(Bezier3);
                    Vector3 vector3;
                    float num9;
                    this.CalculateSegmentPosition(vehicleID, ref vehicleData, position, num4, position.m_offset, out bezier.a, out vector3, out num9);
                    bool flag2;
                    //checkNextLane only for the vehicle in front of the train
                    if ((leaderData.m_flags & Vehicle.Flags.Reversed) != (Vehicle.Flags)0)
                    {
                        flag2 = (vehicleData.m_trailingVehicle == 0);
                    }
                    else
                    {
                        flag2 = (vehicleData.m_leadingVehicle == 0);
                    }

                    bool flag3 = flag2 && b2 == 0;
                    Vector3 vector4;
                    float num10;
                    this.CalculateSegmentPosition(vehicleID, ref vehicleData, position2, laneID, b4, out bezier.d, out vector4, out num10);
                    if (position.m_offset == 0)
                    {
                        vector3 = -vector3;
                    }
                    if (b4 < position2.m_offset)
                    {
                        vector4 = -vector4;
                    }
                    vector3.Normalize();
                    vector4.Normalize();
                    float num11;
                    NetSegment.CalculateMiddlePoints(bezier.a, vector3, bezier.d, vector4, true, true, out bezier.b, out bezier.c, out num11);

                    if (flag3)
                    {

                        if (!this.CheckSingleTrack2Ways(vehicleID, vehicleData, ref num10, laneID, num4))
                            this.CheckNextLane(vehicleID, ref vehicleData, ref num10, position2, laneID, b4, position, num4, position.m_offset, bezier);
                    }
                    if (flag2 && (num10 < 0.01f || (instance2.m_segments.m_buffer[(int)position2.m_segment].m_flags & (NetSegment.Flags.Collapsed | NetSegment.Flags.Flooded)) != NetSegment.Flags.None))
                    {
                        goto IL_595;
                    }
                    if (num11 > 1f)
                    {
                        ushort num12;
                        if (b4 == 0)
                        {
                            num12 = instance2.m_segments.m_buffer[(int)position2.m_segment].m_startNode;
                        }
                        else if (b4 == 255)
                        {
                            num12 = instance2.m_segments.m_buffer[(int)position2.m_segment].m_endNode;
                        }
                        else
                        {
                            num12 = 0;
                        }
                        float num13 = 1.57079637f * (1f + Vector3.Dot(vector3, vector4));
                        if (num11 > 1f)
                        {
                            num13 /= num11;
                        }
                        num10 = Mathf.Min(num10, this.CalculateTargetSpeed(vehicleID, ref vehicleData, 1000f, num13));
                        while (b2 < 255)
                        {
                            float num14 = Mathf.Max(Mathf.Sqrt(num) - Vector3.Distance(vector, refPos1), Mathf.Sqrt(num2) - Vector3.Distance(vector, refPos2));
                            int num15;
                            if (num14 < 0f)
                            {
                                num15 = 8;
                            }
                            else
                            {
                                num15 = 8 + Mathf.CeilToInt(num14 * 256f / (num11 + 1f));
                            }
                            b2 = (byte)Mathf.Min((int)b2 + num15, 255);
                            Vector3 a2 = bezier.Position((float)b2 * 0.003921569f);
                            vector.Set(a2.x, a2.y, a2.z, Mathf.Min(vector.w, num10));
                            float sqrMagnitude3 = (a2 - refPos1).sqrMagnitude;
                            float sqrMagnitude4 = (a2 - refPos2).sqrMagnitude;
                            if (sqrMagnitude3 >= num && sqrMagnitude4 >= num2)
                            {
                                if (index <= 0)
                                {
                                    vehicleData.m_lastPathOffset = b2;
                                }
                                if (num12 != 0)
                                {
                                    this.UpdateNodeTargetPos(vehicleID, ref vehicleData, num12, ref instance2.m_nodes.m_buffer[(int)num12], ref vector, index);
                                }
                                vehicleData.SetTargetPos(index++, vector);
                                if (index < max1)
                                {
                                    num = minSqrDistanceB;
                                    refPos1 = vector;
                                }
                                else if (index == max1)
                                {
                                    num = (refPos2 - refPos1).sqrMagnitude;
                                    num2 = minSqrDistanceA;
                                }
                                else
                                {
                                    num2 = minSqrDistanceB;
                                    refPos2 = vector;
                                }
                                vector.w = 1000f;
                                if (index == max2)
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
                else
                {
                    PathUnit.CalculatePathPositionOffset(laneID, vector, out b4);
                }
                if (index <= 0)
                {
                    if (num7 == 0)
                    {
                        Singleton<PathManager>.instance.ReleaseFirstUnit(ref vehicleData.m_path);
                    }
                    if (num7 >= (int)(instance.m_pathUnits.m_buffer[(int)((UIntPtr)num8)].m_positionCount - 1) && instance.m_pathUnits.m_buffer[(int)((UIntPtr)num8)].m_nextPathUnit == 0u && leaderID != 0)
                    {
                        this.ArrivingToDestination(leaderID, ref leaderData);
                    }
                }
                num3 = num8;
                b = (byte)(num7 << 1);
                b2 = b4;
                if (index <= 0)
                {
                    vehicleData.m_pathPositionIndex = b;
                    vehicleData.m_lastPathOffset = b2;
                    vehicleData.m_flags = ((vehicleData.m_flags & ~(Vehicle.Flags.OnGravel | Vehicle.Flags.Underground | Vehicle.Flags.Transition)) | info.m_setVehicleFlags);
                    if ((vehicleData.m_flags2 & Vehicle.Flags2.Yielding) != (Vehicle.Flags2)0)
                    {
                        vehicleData.m_flags2 &= ~Vehicle.Flags2.Yielding;
                        vehicleData.m_waitCounter = 0;
                    }
                }
                position = position2;
                num4 = laneID;
            }
            return;
            Block_19:
            if (index <= 0)
            {
                Singleton<PathManager>.instance.ReleasePath(vehicleData.m_path);
                vehicleData.m_path = 0u;
            }
            vector.w = 1f;
            vehicleData.SetTargetPos(index++, vector);
            return;
            Block_21:
            this.InvalidPath(vehicleID, ref vehicleData, leaderID, ref leaderData);
            return;
            Block_22:
            this.InvalidPath(vehicleID, ref vehicleData, leaderID, ref leaderData);
            return;
            Block_23:
            this.InvalidPath(vehicleID, ref vehicleData, leaderID, ref leaderData);
            return;
            IL_595:
            if (index <= 0)
            {
                vehicleData.m_lastPathOffset = b2;
            }
            vector = bezier.a;
            vector.w = 0f;
            while (index < max2)
            {
                vehicleData.SetTargetPos(index++, vector);
            }
        }

        //from source code
        private void CheckNextLane(ushort vehicleID, ref Vehicle vehicleData, ref float maxSpeed, PathUnit.Position position, uint laneID, byte offset, PathUnit.Position prevPos, uint prevLaneID, byte prevOffset, Bezier3 bezier)
        {
            NetManager instance = Singleton<NetManager>.instance;
            Vehicle.Frame lastFrameData = vehicleData.GetLastFrameData();
            Vector3 a = lastFrameData.m_position;
            Vector3 a2 = lastFrameData.m_position;
            Vector3 b = lastFrameData.m_rotation * new Vector3(0f, 0f, this.m_info.m_generatedInfo.m_wheelBase * 0.5f);
            a += b;
            a2 -= b;
            float num = 0.5f * lastFrameData.m_velocity.sqrMagnitude / this.m_info.m_braking;
            float a3 = Vector3.Distance(a, bezier.a);
            float b2 = Vector3.Distance(a2, bezier.a);
            if (Mathf.Min(a3, b2) >= num - 5f)
            {
                if (!instance.m_lanes.m_buffer[(int)((UIntPtr)laneID)].CheckSpace(1000f, vehicleID))
                {
                    vehicleData.m_flags2 |= Vehicle.Flags2.Yielding;
                    vehicleData.m_waitCounter = 0;
                    maxSpeed = 0f;
                    return;
                }
                Vector3 vector = bezier.Position(0.5f);
                Segment3 segment;
                if (Vector3.SqrMagnitude(vehicleData.m_segment.a - vector) < Vector3.SqrMagnitude(bezier.a - vector))
                {
                    segment = new Segment3(vehicleData.m_segment.a, vector);
                }
                else
                {
                    segment = new Segment3(bezier.a, vector);
                }
                if (segment.LengthSqr() >= 3f)
                {
                    segment.a += (segment.b - segment.a).normalized * 2.5f;
                    if (SingleTrainTrackAI.CheckOverlap(vehicleID, ref vehicleData, segment, vehicleID))
                    {
                        vehicleData.m_flags2 |= Vehicle.Flags2.Yielding;
                        vehicleData.m_waitCounter = 0;
                        maxSpeed = 0f;
                        return;
                    }
                }
                segment = new Segment3(vector, bezier.d);
                if (segment.LengthSqr() >= 1f && SingleTrainTrackAI.CheckOverlap(vehicleID, ref vehicleData, segment, vehicleID))
                {
                    vehicleData.m_flags2 |= Vehicle.Flags2.Yielding;
                    vehicleData.m_waitCounter = 0;
                    maxSpeed = 0f;
                    return;
                }
                if (this.m_info.m_vehicleType != VehicleInfo.VehicleType.Monorail)
                {
                    ushort num2;
                    if (offset < position.m_offset)
                    {
                        num2 = instance.m_segments.m_buffer[(int)position.m_segment].m_startNode;
                    }
                    else
                    {
                        num2 = instance.m_segments.m_buffer[(int)position.m_segment].m_endNode;
                    }
                    ushort num3;
                    if (prevOffset == 0)
                    {
                        num3 = instance.m_segments.m_buffer[(int)prevPos.m_segment].m_startNode;
                    }
                    else
                    {
                        num3 = instance.m_segments.m_buffer[(int)prevPos.m_segment].m_endNode;
                    }
                    if (num2 == num3)
                    {
                        NetNode.Flags flags = instance.m_nodes.m_buffer[(int)num2].m_flags;
                        NetLane.Flags flags2 = (NetLane.Flags)instance.m_lanes.m_buffer[(int)((UIntPtr)prevLaneID)].m_flags;
                        bool flag = (flags & NetNode.Flags.TrafficLights) != NetNode.Flags.None;
                        bool flag2 = (flags2 & (NetLane.Flags.YieldStart | NetLane.Flags.YieldEnd)) != NetLane.Flags.None && (flags & (NetNode.Flags.Junction | NetNode.Flags.TrafficLights | NetNode.Flags.OneWayIn)) == NetNode.Flags.Junction;
                        if (flag)
                        {
                            uint currentFrameIndex = Singleton<SimulationManager>.instance.m_currentFrameIndex;
                            uint num4 = (uint)(((int)num3 << 8) / 32768);
                            uint num5 = currentFrameIndex - num4 & 255u;
                            RoadBaseAI.TrafficLightState trafficLightState;
                            RoadBaseAI.TrafficLightState pedestrianLightState;
                            bool flag3;
                            bool pedestrians;
                            RoadBaseAI.GetTrafficLightState(num3, ref instance.m_segments.m_buffer[(int)prevPos.m_segment], currentFrameIndex - num4, out trafficLightState, out pedestrianLightState, out flag3, out pedestrians);
                            if (!flag3 && num5 >= 196u)
                            {
                                flag3 = true;
                                RoadBaseAI.SetTrafficLightState(num3, ref instance.m_segments.m_buffer[(int)prevPos.m_segment], currentFrameIndex - num4, trafficLightState, pedestrianLightState, flag3, pedestrians);
                            }
                            if (trafficLightState != RoadBaseAI.TrafficLightState.RedToGreen)
                            {
                                if (trafficLightState != RoadBaseAI.TrafficLightState.GreenToRed)
                                {
                                    if (trafficLightState == RoadBaseAI.TrafficLightState.Red)
                                    {
                                        vehicleData.m_flags2 |= Vehicle.Flags2.Yielding;
                                        vehicleData.m_waitCounter = 0;
                                        maxSpeed = 0f;
                                        return;
                                    }
                                }
                                else if (num5 >= 30u)
                                {
                                    vehicleData.m_flags2 |= Vehicle.Flags2.Yielding;
                                    vehicleData.m_waitCounter = 0;
                                    maxSpeed = 0f;
                                    return;
                                }
                            }
                            else if (num5 < 60u)
                            {
                                vehicleData.m_flags2 |= Vehicle.Flags2.Yielding;
                                vehicleData.m_waitCounter = 0;
                                maxSpeed = 0f;
                                return;
                            }
                        }
                        if (flag2 && (vehicleData.m_flags2 & Vehicle.Flags2.Yielding) != (Vehicle.Flags2)0)
                        {
                            vehicleData.m_waitCounter = (byte)Mathf.Min((int)(vehicleData.m_waitCounter + 1), 4);
                            if (vehicleData.m_waitCounter < 4)
                            {
                                maxSpeed = 0f;
                                return;
                            }
                            vehicleData.m_flags2 &= ~Vehicle.Flags2.Yielding;
                            vehicleData.m_waitCounter = 0;
                        }
                    }
                }
            }
        }

        //from source code
        private static bool CheckOverlap(ushort vehicleID, ref Vehicle vehicleData, Segment3 segment, ushort ignoreVehicle)
        {
            VehicleManager instance = Singleton<VehicleManager>.instance;
            Vector3 min = segment.Min();
            Vector3 max = segment.Max();
            int num = Mathf.Max((int)((min.x - 30f) / 32f + 270f), 0);
            int num2 = Mathf.Max((int)((min.z - 30f) / 32f + 270f), 0);
            int num3 = Mathf.Min((int)((max.x + 30f) / 32f + 270f), 539);
            int num4 = Mathf.Min((int)((max.z + 30f) / 32f + 270f), 539);
            bool result = false;
            for (int i = num2; i <= num4; i++)
            {
                for (int j = num; j <= num3; j++)
                {
                    ushort num5 = instance.m_vehicleGrid[i * 540 + j];
                    int num6 = 0;
                    while (num5 != 0)
                    {
                        num5 = SingleTrainTrackAI.CheckOverlap(vehicleID, ref vehicleData, segment, ignoreVehicle, num5, ref instance.m_vehicles.m_buffer[(int)num5], ref result, min, max);
                        if (++num6 > 16384)
                        {
                            CODebugBase<LogChannel>.Error(LogChannel.Core, "Invalid list detected!\n" + Environment.StackTrace);
                            break;
                        }
                    }
                }
            }
            return result;
        }

        //from source code
        private static ushort CheckOverlap(ushort vehicleID, ref Vehicle vehicleData, Segment3 segment, ushort ignoreVehicle, ushort otherID, ref Vehicle otherData, ref bool overlap, Vector3 min, Vector3 max)
        {
            if (ignoreVehicle == 0 || (otherID != ignoreVehicle && otherData.m_leadingVehicle != ignoreVehicle && otherData.m_trailingVehicle != ignoreVehicle))
            {
                VehicleInfo info = otherData.Info;
                if (info.m_vehicleType == VehicleInfo.VehicleType.Bicycle)
                {
                    return otherData.m_nextGridVehicle;
                }
                if (((vehicleData.m_flags | otherData.m_flags) & Vehicle.Flags.Transition) == (Vehicle.Flags)0 && (vehicleData.m_flags & Vehicle.Flags.Underground) != (otherData.m_flags & Vehicle.Flags.Underground))
                {
                    return otherData.m_nextGridVehicle;
                }
                Vector3 vector = Vector3.Min(otherData.m_segment.Min(), otherData.m_targetPos3);
                Vector3 vector2 = Vector3.Max(otherData.m_segment.Max(), otherData.m_targetPos3);
                if (min.x < vector2.x + 2f && min.y < vector2.y + 2f && min.z < vector2.z + 2f && vector.x < max.x + 2f && vector.y < max.y + 2f && vector.z < max.z + 2f)
                {
                    Vector3 rhs = Vector3.Normalize(segment.b - segment.a);
                    Vector3 lhs = otherData.m_segment.a - vehicleData.m_segment.b;
                    Vector3 lhs2 = otherData.m_segment.b - vehicleData.m_segment.b;
                    if (Vector3.Dot(lhs, rhs) >= 1f || Vector3.Dot(lhs2, rhs) >= 1f)
                    {
                        float num2;
                        float num3;
                        float num = segment.DistanceSqr(otherData.m_segment, out num2, out num3);
                        if (num < 4f)
                        {
                            overlap = true;
                        }
                        Vector3 a = otherData.m_segment.b;
                        segment.a.y = segment.a.y * 0.5f;
                        segment.b.y = segment.b.y * 0.5f;
                        for (int i = 0; i < 4; i++)
                        {
                            Vector3 vector3 = otherData.GetTargetPos(i);
                            Segment3 segment2 = new Segment3(a, vector3);
                            segment2.a.y = segment2.a.y * 0.5f;
                            segment2.b.y = segment2.b.y * 0.5f;
                            if (segment2.LengthSqr() > 0.01f)
                            {
                                num = segment.DistanceSqr(segment2, out num2, out num3);
                                if (num < 4f)
                                {
                                    overlap = true;
                                    break;
                                }
                            }
                            a = vector3;
                        }
                    }
                }
            }
            return otherData.m_nextGridVehicle;
        }



    }

}