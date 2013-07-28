//Mr.ItemRemover2 - Created by CodenameGamma - 1-31-11 - For WoW Version 4.0.3
//www.honorbuddy.de
//this is a free plugin, and should not be sold, or repackaged.
//Donations Accepted. 
//Version 1.3


using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MrItemRemover2.GUI;
using System;
using Styx.Helpers;
using Styx.WoWInternals;
using Styx.WoWInternals.WoWObjects;
using System.IO;
using System.Xml.Linq;
using Styx.Plugins;
using Styx;
using Styx.CommonBot;
using Styx.Common.Helpers;
using Styx.CommonBot.POI;
using Styx.CommonBot.Profiles;
using Styx.CommonBot.Database;
using Styx.Common;
using Styx.CommonBot.Frames;
using System.Collections.Generic;
using System.Diagnostics;


namespace MrItemRemover2
{

    public partial class MrItemRemover2 : HBPlugin
    {
        //Normal Stuff.
        public override string Name { get { return "Mr.ItemRemover2"; } }
        public override string Author { get { return "CnG (Modified by Wigglez)"; } }
        public override Version Version { get { return new Version(1, 4); } }
        public override bool WantButton { get { return true; } }
        public override string ButtonText { get { return "Mr.ItemRemover2"; } }


        public override void OnButtonPress()
        {
            MrItemRemover2GUI form = new MrItemRemover2GUI();
            form.ShowDialog();
        }
        
        public bool DeleteAllGray = MrItemRemover2Settings.Instance.DeleteAllGray;
		public bool DeleteAllWhite = MrItemRemover2Settings.Instance.DeleteAllWhite;
		public bool DeleteAllGreen = MrItemRemover2Settings.Instance.DeleteAllGreen;
		public bool DeleteAllBlue = MrItemRemover2Settings.Instance.DeleteAllBlue;
        public bool DeleteQuestItems = MrItemRemover2Settings.Instance.DeleteQuestItems;



        public static void slog(string format, params object[] args)
        { Logging.Write("[Mr.ItemRemover]:" + format, args); }
        private static LocalPlayer Me { get { return StyxWoW.Me; } }

        //My Crappy Initalise.
        public override void Initialize()
        {
            Lua.Events.AttachEvent("DELETE_ITEM_CONFIRM", DeleteItemConfirmPopup);
            Lua.Events.AttachEvent("MERCHANT_SHOW", SellVenderItems);
            Lua.Events.AttachEvent("LOOT_CLOSED", LootEnded);
            
            slog("Loading Item names.");
            MIRLoad();
            MrItemRemover2Settings.Instance.Load();
            CheckTimer.Reset(); //should start the timer
           
        }

        

        public bool init;
        //Stopwatch CheckTimer = new Stopwatch();
        public static int delay = MrItemRemover2Settings.Instance.Time;
        public WaitTimer CheckTimer = new WaitTimer(TimeSpan.FromMinutes(MrItemRemover2Settings.Instance.Time));
        
        public bool EnableCheck = false;
   
        public override void Pulse()
        {
            if (!MrItemRemover2Settings.Instance.LootEnable)
            {
                if (CheckTimer.TimeLeft.Ticks <= 0)
                {
                    if (EnableCheck == false)
                    {
                        EnableCheck = true;
                        CheckTimer.Reset();

                        Logging.Write("Enabling Check at {0}", GetTime(DateTime.Now));
                        Logging.WriteDiagnostic("Checktimer has Finished its Total wait of {0} Minutes, Enabling Item Check for next Opportunity", MrItemRemover2Settings.Instance.Time.ToString());
                        Logging.Write("Will Run Next Check At {0}", GetTime(CheckTimer.EndTime));
                    }
                }
            }

    
            if (!Me.Combat && !Me.IsCasting && !Me.IsDead && !Me.IsGhost && EnableCheck)
            {

                Logging.WriteDiagnostic("EnableCheck was Passed!");
                if (MrItemRemover2Settings.Instance.EnableOpen)
                {
                    OpenBagItems();
                }
                if (MrItemRemover2Settings.Instance.EnableRemove)
                {
                    CheckForItems();
                }
                EnableCheck = false;
                Logging.WriteDiagnostic("Turning off Check Since Done!");

            }




        }

        private void LootEnded(object sender, LuaEventArgs args)
        {
            if (MrItemRemover2Settings.Instance.LootEnable)
            {
                if (EnableCheck == false)
                {
                    EnableCheck = true;
                    Logging.WriteDiagnostic("Enabling Check because Loot Ended");
                }
            }
        }
        //All items from the TXT Doc are loaded here.
        public List<string> _ItemName = new List<string>
        {

        };
        //Specific items from the TXT Doc are loaded here.
        public List<string> _ItemNameSell = new List<string>
        {

        };
        public List<string> _InventoryList = new List<string>
        {

        };
        public List<string> _KeepList = new List<string>
        {

        };
        public List<string> _OpnList = new List<string>
        {

        };
        //file Path for Saving and Loading. 
        private string FilePathName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                              string.Format(@"Plugins/MrItemRemover2/ItemNameRemoveList.txt"));
        private string FilePathName2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                           string.Format(@"Plugins/MrItemRemover2/ItemNameSellList.txt"));
        private string KeepListPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                           string.Format(@"Plugins/MrItemRemover2/ItemNameKeepList.txt"));
        private string OpnListPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                           string.Format(@"Plugins/MrItemRemover2/ItemNameOpnList.txt"));

        public void MIRLoad()
        {
            slog("Loading Items to Remove List");
            LoadList(_ItemName, FilePathName);
            slog("Loading Items to Sell List");
            LoadList(_ItemNameSell, FilePathName2);
            slog("Loading Items to Keep List");
            LoadList(_KeepList, KeepListPath);
            slog("Loading Items to Open List");
            LoadList(_OpnList, OpnListPath);
            slog("Loading Complete");
        }
        public void LoadList(List<string> ListToLoad, string FilePath)
        {
            ListToLoad.Clear();
            try
            {
                StreamReader Read = new StreamReader(Convert.ToString(FilePath));
                while (Read.Peek() >= 0)
                {
                    ListToLoad.Add(Convert.ToString(Read.ReadLine()));

                }
                /*foreach (string item in ListToLoad)
                {
                    //slog("{0} Added to a List", item.ToString());
                }
                 */
                Read.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex.Message));
                return;
            }

        }
        //Not Yet Implemented (Will if this Plugin Ever gets a UI.
        public void MIRSave()
        {
            writeList(_ItemName, FilePathName);

            writeList(_ItemNameSell, FilePathName2);

            writeList(_KeepList, KeepListPath);

            writeList(_OpnList, OpnListPath);
        }
        public void writeList(List<string> ListName, string filePath)
        {
            StreamWriter Write;
            try
            {
                Write = new StreamWriter(filePath);
                for (int I = 0; I < ListName.Count; I++)
                {
                    Write.WriteLine(Convert.ToString(ListName[I]));
                }
                Write.Close(); //dakkon for this fix.
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message));
                return;
            }
        }

    }
}

