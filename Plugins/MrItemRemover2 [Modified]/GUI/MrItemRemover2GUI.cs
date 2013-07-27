using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
using System.Diagnostics;
using Styx.WoWInternals.WoWObjects;
using Styx.WoWInternals;
using System.IO;


namespace MrItemRemover2.GUI
{
    public partial class MrItemRemover2GUI : Form
    {
        MrItemRemover2 Base = new MrItemRemover2();
        public static void slog(string format, params object[] args)
        { Logging.Write("[Mr.ItemRemover]:" + format, args); }

        public MrItemRemover2GUI()
        {
            InitializeComponent();

        }

        private string refreshImangePathName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format(@"Plugins/MrItemRemover2/ref.bmp"));
        private string GoldImangePathName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format(@"Plugins/MrItemRemover2/Gold2.bmp"));
        private void MrItemRemover2GUI_Load(object sender, EventArgs e)
        {
            Bitmap refresh = new Bitmap(refreshImangePathName);
            Bitmap GoldImg = new Bitmap(GoldImangePathName);
            GoldBox.Image = GoldImg;
            resf.Image = refresh;
            Base.MIRLoad();
            MrItemRemover2Settings.Instance.Load();
            SellList.Items.Clear();
            RemoveList.Items.Clear();
            ProtectedList.Items.Clear();
            GrayItems.Checked = MrItemRemover2Settings.Instance.DeleteAllGray;
			WhiteItems.Checked = MrItemRemover2Settings.Instance.DeleteAllWhite;
			GreenItems.Checked = MrItemRemover2Settings.Instance.DeleteAllGreen;
			BlueItems.Checked = MrItemRemover2Settings.Instance.DeleteAllBlue;
            SellGray.Checked = MrItemRemover2Settings.Instance.SellGray;
            SellWhite.Checked = MrItemRemover2Settings.Instance.SellWhite;
            SellGreen.Checked = MrItemRemover2Settings.Instance.SellGreen;
            EnableRemove.Checked = MrItemRemover2Settings.Instance.EnableRemove;
            EnableOpen.Checked = MrItemRemover2Settings.Instance.EnableOpen;
            EnableSell.Checked = MrItemRemover2Settings.Instance.EnableSell;
            RemoveQItems.Checked = MrItemRemover2Settings.Instance.DeleteQuestItems;
            LootEnable.Checked = MrItemRemover2Settings.Instance.LootEnable;
            GoldGrays.Text = MrItemRemover2Settings.Instance.GoldGrays.ToString();
            SilverGrays.Text = MrItemRemover2Settings.Instance.SilverGrays.ToString();
            CopperGrays.Text = MrItemRemover2Settings.Instance.CopperGrays.ToString();
			GoldWhites.Text = MrItemRemover2Settings.Instance.GoldWhites.ToString();
            SilverWhites.Text = MrItemRemover2Settings.Instance.SilverWhites.ToString();
            CopperWhites.Text = MrItemRemover2Settings.Instance.CopperWhites.ToString();
			GoldGreens.Text = MrItemRemover2Settings.Instance.GoldGreens.ToString();
            SilverGreens.Text = MrItemRemover2Settings.Instance.SilverGreens.ToString();
            CopperGreens.Text = MrItemRemover2Settings.Instance.CopperGreens.ToString();
			GoldBlues.Text = MrItemRemover2Settings.Instance.GoldBlues.ToString();
            SilverBlues.Text = MrItemRemover2Settings.Instance.SilverBlues.ToString();
            CopperBlues.Text = MrItemRemover2Settings.Instance.CopperBlues.ToString();
            Time.Value = MrItemRemover2Settings.Instance.Time;
            foreach (string itm in Base._ItemName)
            {
                RemoveList.Items.Add(itm);
            }
            foreach (string itm in Base._ItemNameSell)
            {
                SellList.Items.Add(itm);
            }
            foreach (string itm in Base._KeepList)
            {
                ProtectedList.Items.Add(itm);
            }
            foreach (string itm in Base._OpnList)
            {
                OpnList.Items.Add(itm);
            }
            ObjectManager.Update();
            foreach (WoWItem BagItem in StyxWoW.Me.BagItems)
            {
                if (BagItem.IsValid && BagItem.BagSlot != -1 && !MyBag.Items.Contains(BagItem.Name))
                {
                    MyBag.Items.Add(BagItem.Name);
                }
            }

        }

        private void AddToBagList_Click(object sender, EventArgs e)
        {
            if (InputAddToBagItem.Text != null)
            {

                MyBag.Items.Add(InputAddToBagItem.Text);
                slog("Added {0} to Inventory List", InputAddToBagItem.Text);
            }
        }

        private void RefreshBagItems_Click(object sender, EventArgs e)
        {
            MyBag.Items.Clear();
            ObjectManager.Update();
            foreach (WoWItem BagItem in Styx.StyxWoW.Me.BagItems)
            {
                if (BagItem.BagSlot != -1 && !MyBag.Items.Contains(BagItem.Name))
                {
                    MyBag.Items.Add(BagItem.Name);
                }
            }
        }

        private void AddToSellList_Click(object sender, EventArgs e)
        {
            if (MyBag.SelectedItems[0] != null)
            {
                SellList.Items.Add(MyBag.SelectedItem);
                Base._ItemNameSell.Add(MyBag.SelectedItem.ToString());
            }
        }

        private void AddToRemoveList_Click(object sender, EventArgs e)
        {
            if (MyBag.SelectedItems[0] != null)
            {
                RemoveList.Items.Add(MyBag.SelectedItem);
                Base._ItemName.Add(MyBag.SelectedItem.ToString());
            }
        }

        private void AddToProtList_Click(object sender, EventArgs e)
        {
            if (MyBag.SelectedItems[0] != null)
            {
                ProtectedList.Items.Add(MyBag.SelectedItem);
                Base._KeepList.Add(MyBag.SelectedItem.ToString());
            }
        }

        private void RemoveSellItem_Click(object sender, EventArgs e)
        {
            if (SellList.SelectedItem != null)
            {

                slog("{0} Removed", SellList.SelectedItem.ToString());
                Base._ItemNameSell.Remove(SellList.SelectedItem.ToString());
                SellList.Items.Remove(SellList.SelectedItem);
            }
        }

        private void RemoveRemoveItem_Click(object sender, EventArgs e)
        {
            if (RemoveList.SelectedItem != null)
            {

                slog("{0} Removed", RemoveList.SelectedItem.ToString());
                Base._ItemName.Remove(RemoveList.SelectedItem.ToString());
                RemoveList.Items.Remove(RemoveList.SelectedItem);
            }
        }

        private void RemoveProtectedItem_Click(object sender, EventArgs e)
        {
            if (ProtectedList.SelectedItem != null)
            {
                slog("{0} Removed", ProtectedList.SelectedItem.ToString());
                Base._KeepList.Remove(ProtectedList.SelectedItem.ToString());
                ProtectedList.Items.Remove(ProtectedList.SelectedItem);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Base.MIRSave();
            MrItemRemover2Settings.Instance.Save();
        }

        private void GrayItems_CheckedChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.DeleteAllGray = GrayItems.Checked;
        }
		
		private void WhiteItems_CheckedChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.DeleteAllWhite = WhiteItems.Checked;
        }
		
		private void GreenItems_CheckedChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.DeleteAllGreen = GreenItems.Checked;
        }
		
		private void BlueItems_CheckedChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.DeleteAllBlue = BlueItems.Checked;
        }

        private void RemoveQItems_CheckedChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.DeleteQuestItems = RemoveQItems.Checked;
        }

        private void SellGray_CheckedChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.SellGray = SellGray.Checked;
        }

        private void SellGreen_CheckedChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.SellGreen = SellGreen.Checked;
        }

        private void SellWhite_CheckedChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.SellWhite = SellWhite.Checked;
        }

        private void EnableSell_CheckedChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.EnableSell = EnableSell.Checked;
        }

        private void EnableRemove_CheckedChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.EnableRemove = EnableRemove.Checked;
        }

        private void Time_ValueChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.Time = int.Parse(Time.Value.ToString());
        }

        private void GoldGrays_TextChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.GoldGrays = int.Parse(GoldGrays.Text);
        }

        private void SilverGrays_TextChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.SilverGrays = int.Parse(SilverGrays.Text);
        }

        private void CopperGrays_TextChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.CopperGrays = int.Parse(CopperGrays.Text);
        }
		
		 private void GoldWhites_TextChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.GoldWhites = int.Parse(GoldWhites.Text);
        }

        private void SilverWhites_TextChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.SilverWhites = int.Parse(SilverWhites.Text);
        }

        private void CopperWhites_TextChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.CopperWhites = int.Parse(CopperWhites.Text);
        }
		
		 private void GoldGreens_TextChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.GoldGreens = int.Parse(GoldGreens.Text);
        }

        private void SilverGreens_TextChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.SilverGreens = int.Parse(SilverGreens.Text);
        }

        private void CopperGreens_TextChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.CopperGreens = int.Parse(CopperGreens.Text);
        }
		
		 private void GoldBlues_TextChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.GoldBlues = int.Parse(GoldBlues.Text);
        }

        private void SilverBlues_TextChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.SilverBlues = int.Parse(SilverBlues.Text);
        }

        private void CopperBlues_TextChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.CopperBlues = int.Parse(CopperBlues.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void RemoveOpenItem_Click(object sender, EventArgs e)
        {
            if (OpnList.SelectedItem != null)
            {

                slog("{0} Removed", OpnList.SelectedItem.ToString());
                Base._OpnList.Remove(OpnList.SelectedItem.ToString());
                OpnList.Items.Remove(OpnList.SelectedItem);
            }
        }

        private void EnableOpen_CheckedChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.EnableOpen = EnableOpen.Checked;
        }

        private void resf_Click(object sender, EventArgs e)
        {
            MyBag.Items.Clear();
            ObjectManager.Update();
            foreach (WoWItem BagItem in Styx.StyxWoW.Me.BagItems)
            {
                if (BagItem.BagSlot != -1 && !MyBag.Items.Contains(BagItem.Name))
                {
                    MyBag.Items.Add(BagItem.Name);
                }
            }
        }

        private void AddToOpnList_Click(object sender, EventArgs e)
        {
            if (MyBag.SelectedItems[0] != null)
            {
                OpnList.Items.Add(MyBag.SelectedItem);
                Base._OpnList.Add(MyBag.SelectedItem.ToString());
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            Logging.Write("Checking Bag Items Manually");
            Base.CheckForItems();
            Base.OpenBagItems();
        }

        private void LootEnable_CheckedChanged(object sender, EventArgs e)
        {
            MrItemRemover2Settings.Instance.LootEnable = LootEnable.Checked;
        }

      
     

    

    }
}
