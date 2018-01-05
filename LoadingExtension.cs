using ICities;
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using System.IO;
using System.Xml;
using ColossalFramework.IO;

namespace SingleTrackAI
{
    public class LoadingExtension : LoadingExtensionBase
    {
        private bool hookEnabled = false;  
        private Dictionary<MethodInfo, RedirectCallsState> redirects = new Dictionary<MethodInfo, RedirectCallsState>();

        public override void OnCreated(ILoading loading)
        {
            base.OnCreated(loading);

            settingsInit();
        }


        public override void OnLevelLoaded(LoadMode mode)
        {
            base.OnLevelLoaded(mode);
            EnableHook();

            if (ReservationManager.instance != null)
                ReservationManager.instance.Initialize();

            //load XML settings file or create one if it does not exist
            if (!readSettings())
                writeSettings();
        }
		

        public override void OnReleased()
        {
            base.OnReleased();
            DisableHook();
        }

        public void EnableHook()
        {
            if (hookEnabled)
            {
                return;
            }
            var allFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public;
            var method = typeof(TrainAI).GetMethods(allFlags).Single(c => c.Name == "UpdatePathTargetPositions" && c.GetParameters().Length == 11);
            redirects.Add(method, RedirectionHelper.RedirectCalls(method, typeof(SingleTrainTrackAI).GetMethods(allFlags).Single(c => c.Name == "UpdatePathTargetPositions" && c.GetParameters().Length == 11)));

            hookEnabled = true;
        }

        public void DisableHook()
        {
            if (!hookEnabled)
            {
                return;
            }
            foreach (var kvp in redirects)
            {

                RedirectionHelper.RevertRedirect(kvp.Key, kvp.Value);
            }
            redirects.Clear();
            hookEnabled = false;
        }

        /////////////// settings ///////////////

        XmlWriterSettings xmlSettings = new XmlWriterSettings();
        string sttaiDirectory;
        string sttaiSettingsFilename;


        public void settingsInit()
        {
            sttaiDirectory = Path.Combine(DataLocation.modsPath, "SingleTrainTrackAI");
            sttaiSettingsFilename = Path.Combine(sttaiDirectory, "SingleTrainTrackAISettings.xml");

            xmlSettings.Encoding = System.Text.Encoding.Unicode;
            xmlSettings.Indent = true;
            xmlSettings.IndentChars = "\t";
        }

        public void checkDirectories()
        {
            if (!Directory.Exists(sttaiDirectory))
                Directory.CreateDirectory(sttaiDirectory);
        }

        public void writeSettings()
        {

            checkDirectories();

            XmlWriter xw = XmlWriter.Create(sttaiSettingsFilename, xmlSettings);

            //header
            xw.WriteStartDocument();
            xw.WriteComment("Automatically generated XML file for cities : skyline's SingleTrainTrackAI mod. Created by CoarxFlow.");
            xw.WriteStartElement("SingleTrainTrackAI");
            xw.WriteAttributeString("version", Mod.version);

            xw.WriteStartElement("Settings");

            xw.WriteComment("Train waiting for a single track section to clear will be registered in a queue. First in the queue can go first.");
            xw.WriteStartElement("AllowProrityQueue");
            xw.WriteAttributeString("Value", Mod.allowPriorityQueue.ToString());
            xw.WriteEndElement();
            
            xw.WriteComment("Train with the same route as the train currently on the single track section will follow immediately. Except if a train with a different route is in the priority queue.");
            xw.WriteStartElement("AllowFollowing");
            xw.WriteAttributeString("Value", Mod.allowFollowing.ToString());
            xw.WriteEndElement();
            
            xw.WriteComment("Trains will proceed as long as their route does not overlap the one of another train. Useful in case of branching single tracks, this can however cause jams.");
            xw.WriteStartElement("GoAsFarAsPossible");
            xw.WriteAttributeString("Value",Mod.allowGoAsFarAsPossible.ToString());
            xw.WriteEndElement();
            
            xw.WriteComment("Signals will be automatically spawned at junctions from two tracks to single track.");
            xw.WriteStartElement("AutoSpawnSignals");
            xw.WriteAttributeString("Value", Mod.allowSpawnSignals.ToString());
            xw.WriteEndElement();

            xw.WriteComment("Set this to true in case trains briefly stop when leaving a single track section with a train waiting in the other direction.");
            xw.WriteComment("However, this can cause train to overlap with another train.");
            xw.WriteStartElement("NoCheckOverlapOnLastSegment");
            xw.WriteAttributeString("Value", Mod.noCheckOverlapOnLastSegment.ToString());
            xw.WriteEndElement();

            xw.WriteComment("Fix case where train reversing at a single track station gets stuck.");
            xw.WriteStartElement("FixReverseTrainSingleTrackStation");
            xw.WriteAttributeString("Value", Mod.fixReverseTrainSingleTrackStation.ToString());
            xw.WriteEndElement();

            xw.WriteComment("Reserve double track station placed after a single track section. Useful in case train reverses and use the single track section again.");
            xw.WriteStartElement("IncludeDoubleTrackStationAfterSingleTrackSection");
            xw.WriteAttributeString("Value", Mod.includeDoubleTrackStationAfterSingleTrackSection.ToString());
            xw.WriteEndElement();

            xw.WriteComment("If station where the train stops has single tracks before and after it, the single track section placed after the station also gets reserved.");
            xw.WriteComment("This is just some additional logic to avoid creating a separate reservation after the station, in case the train continues.");
            xw.WriteStartElement("ExtendReservationAfterStopStation");
            xw.WriteAttributeString("Value", Mod.extendReservationAfterStopStation.ToString());
            xw.WriteEndElement();

            xw.WriteComment("In case the trains you use have slow speeds, wait 2x more time before canceling reservations.");
            xw.WriteStartElement("SlowSpeedTrains");
            xw.WriteAttributeString("Value", Mod.slowSpeedTrains.ToString());
            xw.WriteEndElement();



            xw.WriteEndElement();

            //close file
            xw.WriteEndElement();
            xw.WriteEndDocument();
            xw.Close();
        }


        public bool readSettings()
        {

            checkDirectories();

            if (!File.Exists(sttaiSettingsFilename))
                return false;

            bool fileCorrectVersion = true;

            XmlReader xr = XmlReader.Create(sttaiSettingsFilename);
            try
            {
                string val;
                bool value;
                while (xr.Read())
                {
                    //detect useful tags
                    if (xr.NodeType == XmlNodeType.Element && xr.HasAttributes)
                    {
                        val = xr.GetAttribute("Value");
                        
                        switch (xr.Name)
                        {
                            case "SingleTrainTrackAI":
                                val = xr.GetAttribute("version");
                                fileCorrectVersion = val.Equals(Mod.version);
                                break;
                            case "AllowProrityQueue":
                                if (bool.TryParse(val, out value))
                                {
                                    Mod.allowPriorityQueue = value;
                                }
                                break;
                            case "AllowFollowing":
                                if (bool.TryParse(val, out value))
                                {
                                    Mod.allowFollowing = value;
                                }
                                break;
                            case "GoAsFarAsPossible":
                                if (bool.TryParse(val, out value))
                                {
                                    Mod.allowGoAsFarAsPossible = value;
                                }
                                break;
                            case "AutoSpawnSignals":
                                if (bool.TryParse(val, out value))
                                {
                                    Mod.allowSpawnSignals = value;
                                }
                                break;
                            case "NoCheckOverlapOnLastSegment":
                                if (bool.TryParse(val, out value))
                                {
                                    Mod.noCheckOverlapOnLastSegment = value;
                                }
                                break;
                            case "FixReverseTrainSingleTrackStation":
                                if (bool.TryParse(val, out value))
                                {
                                    Mod.fixReverseTrainSingleTrackStation = value;
                                }
                                break;
                            case "IncludeDoubleTrackStationAfterSingleTrackSection":
                                if (bool.TryParse(val, out value))
                                {
                                    Mod.includeDoubleTrackStationAfterSingleTrackSection = value;
                                }
                                break;
                            case "ExtendReservationAfterStopStation":
                                if (bool.TryParse(val, out value))
                                {
                                    Mod.extendReservationAfterStopStation = value;
                                }
                                break;
                            case "SlowSpeedTrains":
                                if (bool.TryParse(val, out value))
                                {
                                    Mod.slowSpeedTrains = value;
                                }
                                break;

                        }
                    }
                }

                xr.Close();
            }
            catch (XmlException ex)
            {
                Debug.LogException(ex);
                xr.Close();
                return false;
            }

            return fileCorrectVersion;
        }

    }
}