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

namespace MrItemRemover2
{
    public partial class MrItemRemover2
    {
        public void SellVenderItems(object sender, LuaEventArgs args)
        {
            if (MerchantFrame.Instance.IsVisible && MrItemRemover2Settings.Instance.EnableSell)
            {
                foreach (WoWItem Items in Me.BagItems)
                {
                    if (!Items.IsSoulbound && !_KeepList.Contains(Items.Name))
                    {
                        if (Items.Quality == WoWItemQuality.Poor && MrItemRemover2Settings.Instance.SellGray)
                        {
                            slog("Selling Gray Item {0}", Items.Name);
                            Items.UseContainerItem();
                        }
                        if (Items.Quality == WoWItemQuality.Common && MrItemRemover2Settings.Instance.SellWhite)
                        {
                            slog("Selling White Item {0}", Items.Name);
                            Items.UseContainerItem();
                        }
                        if (Items.Quality == WoWItemQuality.Uncommon && MrItemRemover2Settings.Instance.SellGreen)
                        {
                            slog("Selling Green Item {0}", Items.Name);
                            Items.UseContainerItem();
                        }
                        if (_ItemNameSell.Contains(Items.Name))
                        {
                            slog("Item Matched List Selling {0}", Items.Name);
                            Items.UseContainerItem();
                        }
                    }
                }

            }
        }
        private static void DeleteItemConfirmPopup(object sender, LuaEventArgs args)
        {
            string ItemNamePopUp = args.Args[0].ToString();

            if (Me.CurrentTarget != null)
            {
                slog("Clicking Yes to Comfirm {0}'s Removal From Inventory", ItemNamePopUp);
                Lua.DoString("RunMacroText(\"/click StaticPopup1Button1\");");
            }


        }
        public void OpenBagItems()
        {
             LoadList(_OpnList, OpnListPath);
             foreach (WoWItem item in Me.BagItems)
             {
                 if (_OpnList.Contains(item.Name))
                 {
                     //probally not needed, but still user could be messing with thier inventory.
                     if (item != null)
                     {
                         slog("{0} Found Open Item", item.Name);
                         item.Interact();
                         Thread.Sleep(600);
                     }
                 }

             }
        }
        public void CheckForItems()
        {
            //Added to Make sure our list matches what we are looking for. 
            LoadList(_ItemName, FilePathName);
            foreach (WoWItem item in Me.BagItems)
            {
                //if item name Matches whats in the text file / the internal list (after load)
                if (_ItemName.Contains(item.Name) && !_KeepList.Contains(item.Name))
                {
                    //probally not needed, but still user could be messing with thier inventory.
                    if (item != null)
                    {
                        //filtering out all items that for some reason didnt return a bag slot. 
                        // if (item.BagSlot != -1)
                        //{

                        //Adds + 1 to the Bag Index and BagSlot. this is to offset how honorbuddy deals with these values.
                        //int bagin = item.BagIndex + 1;
                        //int bagsl = item.BagSlot + 1;
                        //Printing to the log, and Deleting the Item.
                        slog("{0} Found Removing Item", item.Name);
                        item.PickUp();
                        //Lua.DoString("PickupContainerItem(" + bagin + "," + bagsl + ")");
                        Lua.DoString("DeleteCursorItem()");
                        //a small Sleep, might not be needed. 
                        Thread.Sleep(600);
                        //}

                    }
                }
                if (DeleteQuestItems && item.ItemInfo.BeginQuestId != 0 && !_KeepList.Contains(item.Name))
                {
                    if (item != null)
                    {
                        //if (item.BagSlot != -1)
                        //{
                        ///int bagins2 = item.BagIndex + 1;
                        //int bagssl2 = item.BagSlot + 1;
                        slog("{0}'s Began a Quest. Removing", item.Name);
                        //Lua.DoString("PickupContainerItem(" + bagins2 + "," + bagssl2 + ")");
                        item.PickUp();
                        Lua.DoString("DeleteCursorItem()");
                        //}
                    }
                }
                //Process all Gray Items if enabled. 
                if (DeleteAllGray && item.Quality == WoWItemQuality.Poor && !_KeepList.Contains(item.Name))
                {
                    if (item != null)
                    {
                        //Gold Format, goes in GXX SXX CXX 
                        string Gold = MrItemRemover2Settings.Instance.GoldGrays.ToString() + MrItemRemover2Settings.Instance.SilverGrays.ToString() + MrItemRemover2Settings.Instance.CopperGrays.ToString();
                        if (item.BagSlot != -1 && item.ItemInfo.SellPrice <= Gold.ToInt32())
                        {
                            //int bagins = item.BagIndex + 1;
                            //int bagssl = item.BagSlot + 1;
                            slog("{0}'s Item Quality was Poor Removing.", item.Name);
                            item.PickUp();
                            //Lua.DoString("PickupContainerItem(" + bagins + "," + bagssl + ")");
                            Lua.DoString("DeleteCursorItem()");
                            Thread.Sleep(300);
                        }
                    }
                }
				
				 //Process all White Items if enabled. 
                if (DeleteAllWhite && item.Quality == WoWItemQuality.Common && !item.IsSoulbound && !_KeepList.Contains(item.Name))
                {
                    if (item != null)
                    {
                        //Gold Format, goes in GXX SXX CXX 
                        string Gold = MrItemRemover2Settings.Instance.GoldWhites.ToString() + MrItemRemover2Settings.Instance.SilverWhites.ToString() + MrItemRemover2Settings.Instance.CopperWhites.ToString();
                        if (item.BagSlot != -1 && item.ItemInfo.SellPrice <= Gold.ToInt32())
                        {
                            //int bagins = item.BagIndex + 1;
                            //int bagssl = item.BagSlot + 1;
                            slog("{0}'s Item Quality was Common Removing.", item.Name);
                            item.PickUp();
                            //Lua.DoString("PickupContainerItem(" + bagins + "," + bagssl + ")");
                            Lua.DoString("DeleteCursorItem()");
                            Thread.Sleep(300);
                        }
                    }
                }
				
				 //Process all Green Items if enabled. 
                if (DeleteAllGreen && item.Quality == WoWItemQuality.Uncommon && !_KeepList.Contains(item.Name))
                {
                    if (item != null)
                    {
                        //Gold Format, goes in GXX SXX CXX 
                        string Gold = MrItemRemover2Settings.Instance.GoldGreens.ToString() + MrItemRemover2Settings.Instance.SilverGreens.ToString() + MrItemRemover2Settings.Instance.CopperGreens.ToString();
                        if (item.BagSlot != -1 && item.ItemInfo.SellPrice <= Gold.ToInt32())
                        {
                            //int bagins = item.BagIndex + 1;
                            //int bagssl = item.BagSlot + 1;
                            slog("{0}'s Item Quality was Uncommon Removing.", item.Name);
                            item.PickUp();
                            //Lua.DoString("PickupContainerItem(" + bagins + "," + bagssl + ")");
                            Lua.DoString("DeleteCursorItem()");
                            Thread.Sleep(300);
                        }
                    }
                }
				
				//Process all Blue Items if enabled. 
                if (DeleteAllBlue && item.Quality == WoWItemQuality.Rare && !_KeepList.Contains(item.Name))
                {
                    if (item != null)
                    {
                        //Gold Format, goes in GXX SXX CXX 
                        string Gold = MrItemRemover2Settings.Instance.GoldBlues.ToString() + MrItemRemover2Settings.Instance.SilverBlues.ToString() + MrItemRemover2Settings.Instance.CopperBlues.ToString();
                        if (item.BagSlot != -1 && item.ItemInfo.SellPrice <= Gold.ToInt32())
                        {
                            //int bagins = item.BagIndex + 1;
                            //int bagssl = item.BagSlot + 1;
                            slog("{0}'s Item Quality was Rare Removing.", item.Name);
                            item.PickUp();
                            //Lua.DoString("PickupContainerItem(" + bagins + "," + bagssl + ")");
                            Lua.DoString("DeleteCursorItem()");
                            Thread.Sleep(300);
                        }
                    }
                }
            }
        }

        public string GetTime(DateTime Input)
        {
            string TimeInString = "";
            int hour = Input.Hour;
            int min = Input.Minute;
            int sec = Input.Second;

            TimeInString = (hour < 10) ? "0" + hour.ToString() : hour.ToString();
            TimeInString += ":" + ((min < 10) ? "0" + min.ToString() : min.ToString());
            TimeInString += ":" + ((sec < 10) ? "0" + sec.ToString() : sec.ToString());
            return TimeInString;
        }

    }
}
