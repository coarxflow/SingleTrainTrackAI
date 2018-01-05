using ICities;
using System;

namespace SingleTrackAI
{
	public class Mod: IUserMod {
		
		public static string modName = "SingleTrainTrackAI";
		public static String modID = "SingleTrainTrackAI";
		public static string version = "1.2.1";
		
		public string Name {
			get { return modName; }
		}
		public string Description {
			get { return "Basic AI for 1 lane 2 ways train tracks from One-Way Train Tracks mod by BloodyPenguin"; }
		}

        ///////// settings ////////////

        public static bool allowPriorityQueue = true;
        public static bool allowFollowing = true;
        public static bool allowGoAsFarAsPossible = false;
        public static bool allowSpawnSignals = false;
        public static bool noCheckOverlapOnLastSegment = false;

        //not in xml
        public static bool fixReverseTrainSingleTrackStation = true;
        public static bool extendReservationAfterStopStation = true;
        public static bool includeDoubleTrackStationAfterSingleTrackSection = true;
        public static bool slowSpeedTrains = false;

    }
}

