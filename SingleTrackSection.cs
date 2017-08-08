using ColossalFramework;
using ColossalFramework.Math;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SingleTrackAI
{
    class SingleTrackSection
    {
        public List<uint> segment_ids;
        public ushort vehicle_id;
        public int refresh_timer;

        const string TARGET_RAIL_NAME = "Rail1L2W";

        public void InspectSuccessiveSegments(uint segment_id)
        {
            segment_ids.Clear();

            NetManager instance = Singleton<NetManager>.instance;

            int nieghbours_count = 0;
            bool include_segments = false;
            List<uint> single_lanes = new List<uint>();

            NetNode node;
            NetSegment seg = instance.m_segments.m_buffer[segment_id];

            List<uint> nodes_included = new List<uint>();
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
                        if (instance.m_segments.m_buffer[(int)node.GetSegment(i)].Info.name.Contains(TARGET_RAIL_NAME)) //detect 1 lane 2 ways segments
                            single_lanes.Add(node.GetSegment(i));
                    }
                }

                if (nieghbours_count <= 2 && single_lanes.Count > 0) //include single track segments without branching
                    include_segments = true;
                else if (nieghbours_count > 2) //include single track segments with branching. All single track 2 ways segments connected together will get booked
                    include_segments = true;

                if (include_segments)
                {
                    for (int i = 0; i < single_lanes.Count; i++)
                    {
                        segment_ids.Add(single_lanes[i]);

                        seg = instance.m_segments.m_buffer[(int)single_lanes[i]];
                           if (!nodes_included.Contains(seg.m_endNode))
                                nodes_included.Add(seg.m_endNode);
                            if (!nodes_included.Contains(seg.m_startNode))
                                nodes_included.Add(seg.m_startNode);
                        
                    }
                }

                //CODebug.Log(LogChannel.Modding, "nodes to inspect " + nodes_included.Count + " reserved list " + reservedSegments.Count);
                n++;
            }
        }
    }
}
