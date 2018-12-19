using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SingleTrackAI
{
    public static class TrackExporter
    {
        private static bool Export = false;

        public static void ExportTrackData()
        {
            if (!Export)
                return;

            Export = true;

            var networks = Resources.FindObjectsOfTypeAll<NetInfo>();
            var tracks = from network in networks
                         where network.m_segments.Length != 0
                         where network.m_lanes.Any(lane => lane.m_vehicleType == VehicleInfo.VehicleType.Train)
                         orderby network.name
                         select network;

            const string laneFormat = @"
                        new NetInfo.Lane
                        {{
                            m_direction   = NetInfo.Direction.{0},
                            m_laneType    = NetInfo.LaneType.{1},
                            m_stopType    = VehicleInfo.VehicleType.{2},
                            m_vehicleType = VehicleInfo.VehicleType.{3},
                        }},";

            const string trackFormat = @"
                new NetInfo
                {{
                    name = ""{0}"",
                    m_lanes = new[]
                    {{
                        {1}
                    }},
                }},";

            var tracksBuilder = new StringBuilder();

            foreach (var track in tracks)
            {
                var lanesBuilder = new StringBuilder();

                foreach (var lane in track.m_lanes)
                    lanesBuilder.AppendFormat(laneFormat.Trim(), lane.m_direction, lane.m_laneType, lane.m_stopType, lane.m_vehicleType);

                tracksBuilder.AppendFormat(trackFormat.Trim(), track.name, lanesBuilder);
            }

            Debug.Log("[STTAI] [DATA]\n" + tracksBuilder);
        }
    }
}
