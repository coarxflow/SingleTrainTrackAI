using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SingleTrackAI_Tests
{
    public static class Program
    {
        public static void Main()
        {
            var tracks = new[]
            {
                new NetInfo
                {
                    name = "1195282316.Elevated Train Track Full Wall_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1195282316.Train Track Bridge0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1195282316.Train Track Elevated0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1195282316.Train Track Slope0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1195282316.Train Track Tunnel0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1195938052.Elevated Train Track Arch Wall_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1195938052.Train Track Bridge0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1195938052.Train Track Elevated0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1195938052.Train Track Slope0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1195938052.Train Track Tunnel0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1226381501.Stahlbrücken mit Ziegelpfeiler_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1226381501.Train Track Bridge0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1226381501.Train Track Elevated0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1226381501.Train Track Slope0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1226381501.Train Track Tunnel0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1238520833.Eingleisige Stahlbrücken_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1238520833.Train Oneway Track Bridge0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1238520833.Train Oneway Track Elevated0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1238520833.Train Oneway Track Slope0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1238520833.Train Oneway Track Tunnel0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1317434684.Ein Gleis, zwei Richtungen_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBoth,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1317434684.Train Oneway Track Bridge0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBoth,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1317434684.Train Oneway Track Elevated0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBoth,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1317434684.Train Oneway Track Slope0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBoth,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1317434684.Train Oneway Track Tunnel0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBoth,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1317435331.Eine Richtung, zwei Gleise_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1317435331.Train Track Bridge0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1317435331.Train Track Elevated0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1317435331.Train Track Slope0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1317435331.Train Track Tunnel0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1345762742.Train Track Bridge0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1345762742.Train Track Elevated0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1345762742.Train Track Slope0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1345762742.Train Track Tunnel0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1345762742.Viaduktbogen_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 1x1 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 1x1 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 1x1 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 1x1 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 1x1 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 1x1 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 1x1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 1x2 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 1x2 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 1x2 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 1x2 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 1x2 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 1x2 S1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 1x2 S2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 1x2 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 1x2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 2x1 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 2x1 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 2x1 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 2x1 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 2x1 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 2x1 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 2x1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 2x2 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 2x2 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 2x2 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 2x2 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 2x2 S_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 2x2 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 2x2 SE_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 2x2 SW_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 2x2 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574853410.R69Railway PaCo 2x2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 1x1 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 1x1 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 1x1 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 1x1 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 1x1 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 1x1 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 1x1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 1x2 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 1x2 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 1x2 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 1x2 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 1x2 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 1x2 S1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 1x2 S2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 1x2 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 1x2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 2x1 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 2x1 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 2x1 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 2x1 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 2x1 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 2x1 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 2x1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 2x2 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 2x2 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 2x2 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 2x2 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 2x2 S_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 2x2 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 2x2 SE_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 2x2 SW_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 2x2 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574856340.R69Railway W PaCo 2x2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 1x1 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 1x1 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 1x1 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 1x1 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 1x1 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 1x1 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 1x1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 1x2 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 1x2 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 1x2 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 1x2 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 1x2 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 1x2 S1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 1x2 S2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 1x2 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 1x2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 2x1 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 2x1 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 2x1 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 2x1 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 2x1 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 2x1 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 2x1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 2x2 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 2x2 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 2x2 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 2x2 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 2x2 S_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 2x2 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 2x2 SE_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 2x2 SW_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 2x2 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857232.R69Railway GrCo 2x2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 1x1 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 1x1 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 1x1 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 1x1 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 1x1 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 1x1 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 1x1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 1x2 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 1x2 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 1x2 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 1x2 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 1x2 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 1x2 S1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 1x2 S2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 1x2 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 1x2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 2x1 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 2x1 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 2x1 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 2x1 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 2x1 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 2x1 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 2x1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 2x2 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 2x2 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 2x2 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 2x2 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 2x2 S_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 2x2 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 2x2 SE_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 2x2 SW_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 2x2 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574857742.R69Railway W GrCo 2x2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 1x1 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 1x1 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 1x1 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 1x1 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 1x1 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 1x1 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 1x1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 1x2 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 1x2 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 1x2 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 1x2 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 1x2 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 1x2 S1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 1x2 S2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 1x2 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 1x2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 2x1 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 2x1 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 2x1 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 2x1 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 2x1 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 2x1 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 2x1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 2x2 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 2x2 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 2x2 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 2x2 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 2x2 S_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 2x2 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 2x2 SE_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 2x2 SW_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 2x2 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858399.R69Railway GrWo 2x2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 1x1 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 1x1 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 1x1 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 1x1 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 1x1 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 1x1 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 1x1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 1x2 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 1x2 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 1x2 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 1x2 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 1x2 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 1x2 S1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 1x2 S2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 1x2 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 1x2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 2x1 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 2x1 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 2x1 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 2x1 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 2x1 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 2x1 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 2x1_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 2x2 B0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 2x2 E0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 2x2 N E",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 2x2 N_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 2x2 S_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 2x2 S0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 2x2 SE_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 2x2 SW_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 2x2 T0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574858950.R69Railway W GrWo 2x2_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574860184.R69Railway GrCo 1x2 EL_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574860184.R69Railway GrCo 2x2 EL_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574860850.R69Railway W GrCo 1x2 EL_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574860850.R69Railway W GrCo 2x2 EL_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574861647.R69Railway GrCo 1x2 GEL_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574861647.R69Railway GrCo 2x2 GEL_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574862041.R69Railway W GrCo 1x2 GEL_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574862041.R69Railway W GrCo 2x2 GEL_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574862811.R69Railway GrCo 1x2 TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574862811.R69Railway GrCo 2x2 TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574863472.R69Railway W GrCo 1x2 TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574863472.R69Railway W GrCo 2x2 TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574864185.R69Railway GrWo 1x2 TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574864185.R69Railway GrWo 2x2 TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574864709.R69Railway W GrWo 1x2 TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574864709.R69Railway W GrWo 2x2 TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574892446.R0Railway W GrWo 1x2 Eglisau TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574892446.R0Railway W GrWo 2x2 Eglisau TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574894293.R0Railway W GrCo 1x2 Koblenz TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574894293.R0Railway W GrCo 2x2 Koblenz TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574895043.R0Railway W GrWo 1x2 Swiss AB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574895043.R0Railway W GrWo 2x2 Swiss AB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574895879.R0Railway W GrWo 1x2 Ausser TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574895879.R0Railway W GrWo 2x2 Ausser TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574896352.R0Railway W GrCo 2x2 PiacenzaHSR_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574896352.Train Track Bridge0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574896352.Train Track Elevated0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574896352.Train Track Slope0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574896352.Train Track Tunnel0",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574916688.R0Railway GrWo 1x2 Eglisau TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574916688.R0Railway GrWo 2x2 Eglisau TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574917448.R0Railway GrWo 1x2 Ausser TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574917448.R0Railway GrWo 2x2 Ausser TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574918408.R0Railway GrWo 1x2 Swiss AB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574918408.R0Railway GrWo 2x2 Swiss AB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574919026.R0Railway GrCo 1x2 Koblenz TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Both,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574919026.R0Railway GrCo 2x2 Koblenz TB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574935847.R0Railway GrCo 2x2 PiacenzaHSR_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574935847.Train Track Bridge1",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574935847.Train Track Elevated1",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574935847.Train Track Slope1",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1574935847.Train Track Tunnel1",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1577091797.R0Railway W GrCo 2x2 Ponte AB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1577092711.R0Railway GrCo 2x2 Ponte AB_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1577093439.R0Railway W GrCo 2x2 Ponte EL_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "1577093930.R0Railway GrCo 2x2 Ponte EL_Data",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.None,
                            m_laneType = NetInfo.LaneType.None,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Oneway Train Track",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Oneway Train Track Bridge",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Oneway Train Track Elevated",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Oneway Train Track Slope",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Oneway Train Track Tunnel",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Rail1L",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Rail1L Bridge",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Rail1L Elevated",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Rail1L Slope",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Rail1L Tunnel",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Rail1L2SidedStation",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Rail1L2W",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBoth,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Rail1L2W Bridge",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBoth,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Rail1L2W Elevated",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBoth,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Rail1L2W Slope",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBoth,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Rail1L2W Tunnel",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBoth,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Rail1LStation",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Station Track Eleva",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Station Track Elevated (C)",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Station Track Elevated (CNP)",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Station Track Elevated (NP)",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Station Track Elevated Narrow",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Station Track Elevated Narrow (C)",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Station Track Elevated Narrow (CNP)",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Station Track Elevated Narrow (NP)",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Station Track Sunken",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Station Track Sunken (NP)",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Station Track Tunnel",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Cargo Track",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Cargo Track Elevated",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Connection Track",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Connection Track Elevated",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Oneway Track",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Oneway Track Bridge",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Oneway Track Elevated",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Oneway Track Slope",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Oneway Track Tunnel",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Station Track",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Station Track (C)",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Station Track (CNP)",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Station Track (NP)",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidForward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.AvoidBackward,
                            m_laneType = NetInfo.LaneType.Pedestrian,
                            m_stopType = VehicleInfo.VehicleType.Train,
                            m_vehicleType = VehicleInfo.VehicleType.None,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Track",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Track Bridge",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Track Elevated",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Track Slope",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
                new NetInfo
                {
                    name = "Train Track Tunnel",
                    m_lanes = new[]
                    {
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Backward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                        new NetInfo.Lane
                        {
                            m_direction = NetInfo.Direction.Forward,
                            m_laneType = NetInfo.LaneType.Vehicle,
                            m_stopType = VehicleInfo.VehicleType.None,
                            m_vehicleType = VehicleInfo.VehicleType.Train,
                        },
                    },
                },
            };

            var csv = new StringBuilder();

            csv.Append("Name\t");
            csv.Append("O - Single Two-Way\t");
            csv.Append("M - Single Two-Way\t");
            csv.Append("O - Single Station\t");
            csv.Append("M - Single Station\t");
            csv.Append("O - Double Station\t");
            csv.Append("M - Double Station\t");
            csv.Append("O - Station\t");
            csv.Append("M - Station\t");
            csv.Append("O - Reservation\t");
            csv.Append("M - Reservation");
            csv.AppendLine();

            foreach (var track in tracks)
            {
                csv.Append($"{track.name}\t");

                bool original = Original.IsSingleTrack2WSegment(track);
                bool modified = Modified.IsSingleTrack2WSegment(track);

                csv.Append($"{original}\t{modified}\t");

                original = Original.IsSingleTrackStation(track);
                modified = Modified.IsSingleTrackStation(track);

                csv.Append($"{original}\t{modified}\t");

                original = Original.IsDoubleTrackStation(track);
                modified = Modified.IsDoubleTrackStation(track);

                csv.Append($"{original}\t{modified}\t");

                original = Original.IsStation(track);
                modified = Modified.IsStation(track);

                csv.Append($"{original}\t{modified}\t");

                original = Original.RequireReservation(track);
                modified = Modified.RequireReservation(track);

                csv.Append($"{original}\t{modified}");
                csv.AppendLine();
            }

            File.WriteAllText("results.csv", csv.ToString(0, csv.Length - 1));
        }
    }

    public static class Original
    {
        const string TARGET_RAIL_NAME = "Rail1L2W";
        const string TARGET_RAIL_NAME2 = "Rail1L2SidedStation";
        const string TARGET_RAIL_NAME3 = "Rail1LStation";
        const string TARGET_RAIL_NAME4 = "Train Station Track";

        public static bool IsSingleTrack2WSegment(NetInfo info)
        {
            String name = info.name;
            var railLane = info.m_lanes.FirstOrDefault(l => l.m_laneType == NetInfo.LaneType.Vehicle);
            return (railLane.m_direction == NetInfo.Direction.AvoidBoth) || name.Contains(TARGET_RAIL_NAME2) || name.Contains(TARGET_RAIL_NAME3);
        }

        public static bool IsSingleTrackStation(NetInfo info)
        {
            String name = info.name;
            return name.Contains(TARGET_RAIL_NAME2) || name.Contains(TARGET_RAIL_NAME3);
        }

        public static bool IsDoubleTrackStation(NetInfo info)
        {
            return info.name.Contains(TARGET_RAIL_NAME4);
        }

        public static bool IsStation(NetInfo info)
        {
            return IsDoubleTrackStation(info) || IsSingleTrackStation(info);
        }

        public static bool RequireReservation(NetInfo info)
        {
            return IsSingleTrack2WSegment(info) || IsDoubleTrackStation(info);
        }
    }

    public static class Modified
    {

        public static bool IsSingleTrack2WSegment(NetInfo info)
        {
            return CheckTrainTrackSegment(
                info,
                nameof(IsSingleTrack2WSegment),
                (tracks, tracks_one_way, tracks_two_way, platforms) => tracks == 1 && tracks_two_way == 1);
        }

        public static bool IsSingleTrackStation(NetInfo info)
        {
            return CheckTrainTrackSegment(
                info,
                nameof(IsSingleTrackStation),
                (tracks, tracks_one_way, tracks_two_way, platforms) => platforms != 0 && tracks == 1);
        }

        public static bool IsDoubleTrackStation(NetInfo info)
        {
            return CheckTrainTrackSegment(
                info,
                nameof(IsDoubleTrackStation),
                (tracks, tracks_one_way, tracks_two_way, platforms) => platforms != 0 && tracks == 2);
        }

        public static bool IsStation(NetInfo info)
        {
            return CheckTrainTrackSegment(
                info,
                nameof(IsStation),
                (tracks, tracks_one_way, tracks_two_way, platforms) => platforms != 0 && (tracks == 1 || tracks == 2));
        }

        public static bool RequireReservation(NetInfo info)
        {
            return CheckTrainTrackSegment(
                info,
                nameof(RequireReservation),
                (tracks, tracks_one_way, tracks_two_way, platforms) => (tracks == 1 && tracks_two_way == 1) ||
                                                                       (platforms != 0 && tracks == 2));
        }

        private static bool CheckTrainTrackSegment(NetInfo info, string name, Func<int, int, int, int, bool> check_func)
        {
            NetInfo.Lane[] lanes = info.m_lanes;

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

            return result;
        }
    }

    public class VehicleInfo
    {
        [Flags]
        public enum VehicleType
        {
            None = 0,
            Car = 1,
            Metro = 2,
            Train = 4,
            Ship = 8,
            Plane = 16,
            Bicycle = 32,
            Tram = 64,
            Helicopter = 128,
            Meteor = 256,
            Vortex = 512,
            Ferry = 1024,
            Monorail = 2048,
            CableCar = 4096,
            Blimp = 8192,
            Balloon = 16384,
            Rocket = 32768,
            All = 65535
        }
    }

    public class NetInfo
    {
        public string name;
        public Lane[] m_lanes;

        [Flags]
        public enum LaneType : byte
        {
            None = 0,
            Vehicle = 1,
            Pedestrian = 2,
            Parking = 4,
            PublicTransport = 8,
            CargoVehicle = 16,
            TransportVehicle = 32,
            EvacuationTransport = 64,
            Tour = 128,
            All = 255
        }
        [Flags]
        public enum Direction : byte
        {
            None = 0,
            Forward = 1,
            Backward = 2,
            Both = 3,
            AvoidBackward = 7,
            AvoidForward = 11,
            Avoid = 12,
            AvoidBoth = 15
        }

        public class Lane
        {
            public Direction m_direction;
            public LaneType m_laneType;
            public VehicleInfo.VehicleType m_stopType;
            public VehicleInfo.VehicleType m_vehicleType;
        }
    }

    public class NetSegment
    {
        public NetInfo Info
        {
            get;
            set;
        }
    }

    public class TrackTest
    {
        public NetInfo info
        {
            get;
            set;
        }

        public Dictionary<string, bool> Expected
        {
            get;
            set;
        }
    }
}
