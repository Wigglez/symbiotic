namespace MrItemRemover2.GUI
{
    partial class MrItemRemover2GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Time = new System.Windows.Forms.NumericUpDown();
            this.GoldGrays = new System.Windows.Forms.TextBox();
            this.SilverGrays = new System.Windows.Forms.TextBox();
            this.CopperGrays = new System.Windows.Forms.TextBox();
			this.GoldWhites = new System.Windows.Forms.TextBox();
            this.SilverWhites = new System.Windows.Forms.TextBox();
            this.CopperWhites = new System.Windows.Forms.TextBox();
			this.GoldGreens = new System.Windows.Forms.TextBox();
            this.SilverGreens = new System.Windows.Forms.TextBox();
            this.CopperGreens = new System.Windows.Forms.TextBox();
			this.GoldBlues = new System.Windows.Forms.TextBox();
            this.SilverBlues = new System.Windows.Forms.TextBox();
            this.CopperBlues = new System.Windows.Forms.TextBox();
            this.MyBag = new System.Windows.Forms.ListBox();
            this.RemoveList = new System.Windows.Forms.ListBox();
            this.SellList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resf = new System.Windows.Forms.PictureBox();
            this.AddToOpnList = new System.Windows.Forms.Button();
            this.AddToSellList = new System.Windows.Forms.Button();
            this.AddToProtList = new System.Windows.Forms.Button();
            this.AddToRemoveList = new System.Windows.Forms.Button();
            this.RefreshBagItems = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RemoveRemoveItem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RemoveSellItem = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ProtectedList = new System.Windows.Forms.ListBox();
            this.RemoveProtectedItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AddToBagList = new System.Windows.Forms.Button();
            this.InputAddToBagItem = new System.Windows.Forms.TextBox();
            this.EnableRemove = new System.Windows.Forms.CheckBox();
            this.EnableSell = new System.Windows.Forms.CheckBox();
            this.SellWhite = new System.Windows.Forms.CheckBox();
            this.SellGreen = new System.Windows.Forms.CheckBox();
            this.SellGray = new System.Windows.Forms.CheckBox();
            this.GrayItems = new System.Windows.Forms.CheckBox();
			this.WhiteItems = new System.Windows.Forms.CheckBox();
			this.GreenItems = new System.Windows.Forms.CheckBox();
			this.BlueItems = new System.Windows.Forms.CheckBox();
            this.RemoveQItems = new System.Windows.Forms.CheckBox();
            this.Save = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            this.opnlst = new System.Windows.Forms.GroupBox();
            this.RemoveOpenItem = new System.Windows.Forms.Button();
            this.OpnList = new System.Windows.Forms.ListBox();
            this.EnableOpen = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GoldBox = new System.Windows.Forms.PictureBox();
            this.LootEnable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Time)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resf)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.opnlst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoldBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(348, 340);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(51, 20);
            this.Time.TabIndex = 0;
            this.Time.ValueChanged += new System.EventHandler(this.Time_ValueChanged);
            // 
            // GoldGrays
            // 
            this.GoldGrays.BackColor = System.Drawing.Color.Black;
            this.GoldGrays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GoldGrays.ForeColor = System.Drawing.Color.White;
            this.GoldGrays.Location = new System.Drawing.Point(43, 352);
            this.GoldGrays.MaxLength = 4;
            this.GoldGrays.Name = "GoldGrays";
            this.GoldGrays.Size = new System.Drawing.Size(26, 13);
            this.GoldGrays.TabIndex = 1;
            this.GoldGrays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GoldGrays.TextChanged += new System.EventHandler(this.GoldGrays_TextChanged);
            // 
            // SilverGrays
            // 
            this.SilverGrays.BackColor = System.Drawing.Color.Black;
            this.SilverGrays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SilverGrays.ForeColor = System.Drawing.Color.White;
            this.SilverGrays.Location = new System.Drawing.Point(93, 352);
            this.SilverGrays.MaxLength = 2;
            this.SilverGrays.Name = "SilverGrays";
            this.SilverGrays.Size = new System.Drawing.Size(17, 13);
            this.SilverGrays.TabIndex = 2;
            this.SilverGrays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SilverGrays.TextChanged += new System.EventHandler(this.SilverGrays_TextChanged);
            // 
            // CopperGrays
            // 
            this.CopperGrays.BackColor = System.Drawing.Color.Black;
            this.CopperGrays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CopperGrays.ForeColor = System.Drawing.Color.White;
            this.CopperGrays.Location = new System.Drawing.Point(131, 352);
            this.CopperGrays.MaxLength = 2;
            this.CopperGrays.Name = "CopperGrays";
            this.CopperGrays.Size = new System.Drawing.Size(18, 13);
            this.CopperGrays.TabIndex = 3;
            this.CopperGrays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CopperGrays.TextChanged += new System.EventHandler(this.CopperGrays_TextChanged);
			
			
			// 
            // GoldWhites
            // 
            this.GoldWhites.BackColor = System.Drawing.Color.Black;
            this.GoldWhites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GoldWhites.ForeColor = System.Drawing.Color.White;
            this.GoldWhites.Location = new System.Drawing.Point(43, 352);
            this.GoldWhites.MaxLength = 4;
            this.GoldWhites.Name = "GoldWhites";
            this.GoldWhites.Size = new System.Drawing.Size(26, 13);
            this.GoldWhites.TabIndex = 1;
            this.GoldWhites.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GoldWhites.TextChanged += new System.EventHandler(this.GoldWhites_TextChanged);
            // 
            // SilverWhites
            // 
            this.SilverWhites.BackColor = System.Drawing.Color.Black;
            this.SilverWhites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SilverWhites.ForeColor = System.Drawing.Color.White;
            this.SilverWhites.Location = new System.Drawing.Point(93, 352);
            this.SilverWhites.MaxLength = 2;
            this.SilverWhites.Name = "SilverWhites";
            this.SilverWhites.Size = new System.Drawing.Size(17, 13);
            this.SilverWhites.TabIndex = 2;
            this.SilverWhites.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SilverWhites.TextChanged += new System.EventHandler(this.SilverWhites_TextChanged);
            // 
            // CopperWhites
            // 
            this.CopperWhites.BackColor = System.Drawing.Color.Black;
            this.CopperWhites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CopperWhites.ForeColor = System.Drawing.Color.White;
            this.CopperWhites.Location = new System.Drawing.Point(131, 352);
            this.CopperWhites.MaxLength = 2;
            this.CopperWhites.Name = "CopperWhites";
            this.CopperWhites.Size = new System.Drawing.Size(18, 13);
            this.CopperWhites.TabIndex = 3;
            this.CopperWhites.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CopperWhites.TextChanged += new System.EventHandler(this.CopperWhites_TextChanged);
			
			// 
            // GoldGreens
            // 
            this.GoldGreens.BackColor = System.Drawing.Color.Black;
            this.GoldGreens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GoldGreens.ForeColor = System.Drawing.Color.White;
            this.GoldGreens.Location = new System.Drawing.Point(43, 352);
            this.GoldGreens.MaxLength = 4;
            this.GoldGreens.Name = "GoldGreens";
            this.GoldGreens.Size = new System.Drawing.Size(26, 13);
            this.GoldGreens.TabIndex = 1;
            this.GoldGreens.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GoldGreens.TextChanged += new System.EventHandler(this.GoldGreens_TextChanged);
            // 
            // SilverGreens
            // 
            this.SilverGreens.BackColor = System.Drawing.Color.Black;
            this.SilverGreens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SilverGreens.ForeColor = System.Drawing.Color.White;
            this.SilverGreens.Location = new System.Drawing.Point(93, 352);
            this.SilverGreens.MaxLength = 2;
            this.SilverGreens.Name = "SilverGreens";
            this.SilverGreens.Size = new System.Drawing.Size(17, 13);
            this.SilverGreens.TabIndex = 2;
            this.SilverGreens.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SilverGreens.TextChanged += new System.EventHandler(this.SilverGreens_TextChanged);
            // 
            // CopperGreens
            // 
            this.CopperGreens.BackColor = System.Drawing.Color.Black;
            this.CopperGreens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CopperGreens.ForeColor = System.Drawing.Color.White;
            this.CopperGreens.Location = new System.Drawing.Point(131, 352);
            this.CopperGreens.MaxLength = 2;
            this.CopperGreens.Name = "CopperGreens";
            this.CopperGreens.Size = new System.Drawing.Size(18, 13);
            this.CopperGreens.TabIndex = 3;
            this.CopperGreens.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CopperGreens.TextChanged += new System.EventHandler(this.CopperGreens_TextChanged);
			
			// 
            // GoldBlues
            // 
            this.GoldBlues.BackColor = System.Drawing.Color.Black;
            this.GoldBlues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GoldBlues.ForeColor = System.Drawing.Color.White;
            this.GoldBlues.Location = new System.Drawing.Point(43, 352);
            this.GoldBlues.MaxLength = 4;
            this.GoldBlues.Name = "GoldBlues";
            this.GoldBlues.Size = new System.Drawing.Size(26, 13);
            this.GoldBlues.TabIndex = 1;
            this.GoldBlues.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GoldBlues.TextChanged += new System.EventHandler(this.GoldBlues_TextChanged);
            // 
            // SilverBlues
            // 
            this.SilverBlues.BackColor = System.Drawing.Color.Black;
            this.SilverBlues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SilverBlues.ForeColor = System.Drawing.Color.White;
            this.SilverBlues.Location = new System.Drawing.Point(93, 352);
            this.SilverBlues.MaxLength = 2;
            this.SilverBlues.Name = "SilverBlues";
            this.SilverBlues.Size = new System.Drawing.Size(17, 13);
            this.SilverBlues.TabIndex = 2;
            this.SilverBlues.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SilverBlues.TextChanged += new System.EventHandler(this.SilverBlues_TextChanged);
            // 
            // CopperBlues
            // 
            this.CopperBlues.BackColor = System.Drawing.Color.Black;
            this.CopperBlues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CopperBlues.ForeColor = System.Drawing.Color.White;
            this.CopperBlues.Location = new System.Drawing.Point(131, 352);
            this.CopperBlues.MaxLength = 2;
            this.CopperBlues.Name = "CopperBlues";
            this.CopperBlues.Size = new System.Drawing.Size(18, 13);
            this.CopperBlues.TabIndex = 3;
            this.CopperBlues.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CopperBlues.TextChanged += new System.EventHandler(this.CopperBlues_TextChanged);
			
            // 
            // MyBag
            // 
            this.MyBag.FormattingEnabled = true;
            this.MyBag.Location = new System.Drawing.Point(6, 19);
            this.MyBag.Name = "MyBag";
            this.MyBag.Size = new System.Drawing.Size(163, 173);
            this.MyBag.TabIndex = 4;
            // 
            // RemoveList
            // 
            this.RemoveList.FormattingEnabled = true;
            this.RemoveList.Location = new System.Drawing.Point(6, 19);
            this.RemoveList.Name = "RemoveList";
            this.RemoveList.Size = new System.Drawing.Size(130, 199);
            this.RemoveList.TabIndex = 5;
            // 
            // SellList
            // 
            this.SellList.FormattingEnabled = true;
            this.SellList.Location = new System.Drawing.Point(6, 19);
            this.SellList.Name = "SellList";
            this.SellList.Size = new System.Drawing.Size(130, 199);
            this.SellList.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resf);
            this.groupBox1.Controls.Add(this.AddToOpnList);
            this.groupBox1.Controls.Add(this.AddToSellList);
            this.groupBox1.Controls.Add(this.AddToProtList);
            this.groupBox1.Controls.Add(this.AddToRemoveList);
            this.groupBox1.Controls.Add(this.MyBag);
            this.groupBox1.Location = new System.Drawing.Point(7, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 293);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Bag Items";
            // 
            // resf
            // 
            this.resf.Location = new System.Drawing.Point(80, 0);
            this.resf.Name = "resf";
            this.resf.Size = new System.Drawing.Size(16, 16);
            this.resf.TabIndex = 38;
            this.resf.TabStop = false;
            this.resf.Click += new System.EventHandler(this.resf_Click);
            // 
            // AddToOpnList
            // 
            this.AddToOpnList.Location = new System.Drawing.Point(6, 244);
            this.AddToOpnList.Name = "AddToOpnList";
            this.AddToOpnList.Size = new System.Drawing.Size(163, 23);
            this.AddToOpnList.TabIndex = 8;
            this.AddToOpnList.Text = "Add Selected to Open List";
            this.AddToOpnList.UseVisualStyleBackColor = true;
            this.AddToOpnList.Click += new System.EventHandler(this.AddToOpnList_Click);
            // 
            // AddToSellList
            // 
            this.AddToSellList.Location = new System.Drawing.Point(6, 197);
            this.AddToSellList.Name = "AddToSellList";
            this.AddToSellList.Size = new System.Drawing.Size(163, 23);
            this.AddToSellList.TabIndex = 7;
            this.AddToSellList.Text = "Add Selected to Sell List";
            this.AddToSellList.UseVisualStyleBackColor = true;
            this.AddToSellList.Click += new System.EventHandler(this.AddToSellList_Click);
            // 
            // AddToProtList
            // 
            this.AddToProtList.Location = new System.Drawing.Point(6, 267);
            this.AddToProtList.Name = "AddToProtList";
            this.AddToProtList.Size = new System.Drawing.Size(163, 23);
            this.AddToProtList.TabIndex = 6;
            this.AddToProtList.Text = "Add Selected To Protected List";
            this.AddToProtList.UseVisualStyleBackColor = true;
            this.AddToProtList.Click += new System.EventHandler(this.AddToProtList_Click);
            // 
            // AddToRemoveList
            // 
            this.AddToRemoveList.Location = new System.Drawing.Point(6, 221);
            this.AddToRemoveList.Name = "AddToRemoveList";
            this.AddToRemoveList.Size = new System.Drawing.Size(163, 23);
            this.AddToRemoveList.TabIndex = 5;
            this.AddToRemoveList.Text = "Add Selected to Remove List";
            this.AddToRemoveList.UseVisualStyleBackColor = true;
            this.AddToRemoveList.Click += new System.EventHandler(this.AddToRemoveList_Click);
            // 
            // RefreshBagItems
            // 
            this.RefreshBagItems.Enabled = false;
            this.RefreshBagItems.Location = new System.Drawing.Point(485, 293);
            this.RefreshBagItems.Name = "RefreshBagItems";
            this.RefreshBagItems.Size = new System.Drawing.Size(162, 23);
            this.RefreshBagItems.TabIndex = 8;
            this.RefreshBagItems.Text = "Refresh Bag Items";
            this.RefreshBagItems.UseVisualStyleBackColor = true;
            this.RefreshBagItems.Visible = false;
            this.RefreshBagItems.Click += new System.EventHandler(this.RefreshBagItems_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RemoveRemoveItem);
            this.groupBox2.Controls.Add(this.RemoveList);
            this.groupBox2.Location = new System.Drawing.Point(342, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 256);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "My Remove List";
            // 
            // RemoveRemoveItem
            // 
            this.RemoveRemoveItem.Location = new System.Drawing.Point(6, 225);
            this.RemoveRemoveItem.Name = "RemoveRemoveItem";
            this.RemoveRemoveItem.Size = new System.Drawing.Size(129, 23);
            this.RemoveRemoveItem.TabIndex = 6;
            this.RemoveRemoveItem.Text = "Remove Selected Item";
            this.RemoveRemoveItem.UseVisualStyleBackColor = true;
            this.RemoveRemoveItem.Click += new System.EventHandler(this.RemoveRemoveItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RemoveSellItem);
            this.groupBox3.Controls.Add(this.SellList);
            this.groupBox3.Location = new System.Drawing.Point(194, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 256);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "My Sell List";
            // 
            // RemoveSellItem
            // 
            this.RemoveSellItem.Location = new System.Drawing.Point(6, 225);
            this.RemoveSellItem.Name = "RemoveSellItem";
            this.RemoveSellItem.Size = new System.Drawing.Size(129, 23);
            this.RemoveSellItem.TabIndex = 7;
            this.RemoveSellItem.Text = "Remove Selected Item";
            this.RemoveSellItem.UseVisualStyleBackColor = true;
            this.RemoveSellItem.Click += new System.EventHandler(this.RemoveSellItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ProtectedList);
            this.groupBox4.Controls.Add(this.RemoveProtectedItem);
            this.groupBox4.Location = new System.Drawing.Point(627, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(142, 256);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "My Protected List";
            // 
            // ProtectedList
            // 
            this.ProtectedList.FormattingEnabled = true;
            this.ProtectedList.Location = new System.Drawing.Point(6, 19);
            this.ProtectedList.Name = "ProtectedList";
            this.ProtectedList.Size = new System.Drawing.Size(130, 199);
            this.ProtectedList.TabIndex = 9;
            // 
            // RemoveProtectedItem
            // 
            this.RemoveProtectedItem.Location = new System.Drawing.Point(6, 224);
            this.RemoveProtectedItem.Name = "RemoveProtectedItem";
            this.RemoveProtectedItem.Size = new System.Drawing.Size(129, 23);
            this.RemoveProtectedItem.TabIndex = 8;
            this.RemoveProtectedItem.Text = "Remove Selected Item";
            this.RemoveProtectedItem.UseVisualStyleBackColor = true;
            this.RemoveProtectedItem.Click += new System.EventHandler(this.RemoveProtectedItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Minutes to Next Check";
            // 
            // AddToBagList
            // 
            this.AddToBagList.Location = new System.Drawing.Point(194, 1);
            this.AddToBagList.Name = "AddToBagList";
            this.AddToBagList.Size = new System.Drawing.Size(144, 23);
            this.AddToBagList.TabIndex = 17;
            this.AddToBagList.Text = "Add Item to My Bag Items";
            this.AddToBagList.UseVisualStyleBackColor = true;
            this.AddToBagList.Click += new System.EventHandler(this.AddToBagList_Click);
            // 
            // InputAddToBagItem
            // 
            this.InputAddToBagItem.Location = new System.Drawing.Point(12, 4);
            this.InputAddToBagItem.Name = "InputAddToBagItem";
            this.InputAddToBagItem.Size = new System.Drawing.Size(176, 20);
            this.InputAddToBagItem.TabIndex = 18;
            // 
            // EnableRemove
            // 
            this.EnableRemove.AutoSize = true;
            this.EnableRemove.Location = new System.Drawing.Point(544, 5);
            this.EnableRemove.Name = "EnableRemove";
            this.EnableRemove.Size = new System.Drawing.Size(110, 17);
            this.EnableRemove.TabIndex = 19;
            this.EnableRemove.Text = "Enable Removing";
            this.EnableRemove.UseVisualStyleBackColor = true;
            this.EnableRemove.CheckedChanged += new System.EventHandler(this.EnableRemove_CheckedChanged);
            // 
            // EnableSell
            // 
            this.EnableSell.AutoSize = true;
            this.EnableSell.Location = new System.Drawing.Point(445, 5);
            this.EnableSell.Name = "EnableSell";
            this.EnableSell.Size = new System.Drawing.Size(93, 17);
            this.EnableSell.TabIndex = 20;
            this.EnableSell.Text = "Enable Selling";
            this.EnableSell.UseVisualStyleBackColor = true;
            this.EnableSell.CheckedChanged += new System.EventHandler(this.EnableSell_CheckedChanged);
            // 
            // SellWhite
            // 
            this.SellWhite.AutoSize = true;
            this.SellWhite.Location = new System.Drawing.Point(200, 340);
            this.SellWhite.Name = "SellWhite";
            this.SellWhite.Size = new System.Drawing.Size(102, 17);
            this.SellWhite.TabIndex = 30;
            this.SellWhite.Text = "Sell White Items";
            this.SellWhite.UseVisualStyleBackColor = true;
            this.SellWhite.CheckedChanged += new System.EventHandler(this.SellWhite_CheckedChanged);
            // 
            // SellGreen
            // 
            this.SellGreen.AutoSize = true;
            this.SellGreen.Location = new System.Drawing.Point(200, 316);
            this.SellGreen.Name = "SellGreen";
            this.SellGreen.Size = new System.Drawing.Size(103, 17);
            this.SellGreen.TabIndex = 29;
            this.SellGreen.Text = "Sell Green Items";
            this.SellGreen.UseVisualStyleBackColor = true;
            this.SellGreen.CheckedChanged += new System.EventHandler(this.SellGreen_CheckedChanged);
            // 
            // SellGray
            // 
            this.SellGray.AutoSize = true;
            this.SellGray.Location = new System.Drawing.Point(200, 294);
            this.SellGray.Name = "SellGray";
            this.SellGray.Size = new System.Drawing.Size(96, 17);
            this.SellGray.TabIndex = 28;
            this.SellGray.Text = "Sell Gray Items";
            this.SellGray.UseVisualStyleBackColor = true;
            this.SellGray.CheckedChanged += new System.EventHandler(this.SellGray_CheckedChanged);
            // 
            // GrayItems
            // 
            this.GrayItems.AutoSize = true;
            this.GrayItems.Location = new System.Drawing.Point(346, 293);
            this.GrayItems.Name = "GrayItems";
            this.GrayItems.Size = new System.Drawing.Size(132, 17);
            this.GrayItems.TabIndex = 27;
            this.GrayItems.Text = "Delete Grays";
            this.GrayItems.UseVisualStyleBackColor = true;
            this.GrayItems.CheckedChanged += new System.EventHandler(this.GrayItems_CheckedChanged);
			// 
            // WhiteItems
            // 
            this.WhiteItems.AutoSize = true;
            this.WhiteItems.Location = new System.Drawing.Point(478, 293);
            this.WhiteItems.Name = "WhiteItems";
            this.WhiteItems.Size = new System.Drawing.Size(132, 17);
            this.WhiteItems.TabIndex = 27;
            this.WhiteItems.Text = "Delete Whites";
            this.WhiteItems.UseVisualStyleBackColor = true;
            this.WhiteItems.CheckedChanged += new System.EventHandler(this.WhiteItems_CheckedChanged);
			// 
            // GreenItems
            // 
            this.GreenItems.AutoSize = true;
            this.GreenItems.Location = new System.Drawing.Point(610, 293);
            this.GreenItems.Name = "GreenItems";
            this.GreenItems.Size = new System.Drawing.Size(132, 17);
            this.GreenItems.TabIndex = 27;
            this.GreenItems.Text = "Delete Greens";
            this.GreenItems.UseVisualStyleBackColor = true;
            this.GreenItems.CheckedChanged += new System.EventHandler(this.GreenItems_CheckedChanged);
			// 
            // BlueItems
            // 
            this.BlueItems.AutoSize = true;
            this.BlueItems.Location = new System.Drawing.Point(742, 293);
            this.BlueItems.Name = "BlueItems";
            this.BlueItems.Size = new System.Drawing.Size(132, 17);
            this.BlueItems.TabIndex = 27;
            this.BlueItems.Text = "Delete Blues";
            this.BlueItems.UseVisualStyleBackColor = true;
            this.BlueItems.CheckedChanged += new System.EventHandler(this.BlueItems_CheckedChanged);
            // 
            // RemoveQItems
            // 
            this.RemoveQItems.AutoSize = true;
            this.RemoveQItems.Location = new System.Drawing.Point(346, 317);
            this.RemoveQItems.Name = "RemoveQItems";
            this.RemoveQItems.Size = new System.Drawing.Size(180, 17);
            this.RemoveQItems.TabIndex = 31;
            this.RemoveQItems.Text = "Remove Items That Start Quests";
            this.RemoveQItems.UseVisualStyleBackColor = true;
            this.RemoveQItems.CheckedChanged += new System.EventHandler(this.RemoveQItems_CheckedChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(669, 341);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 26);
            this.Save.TabIndex = 32;
            this.Save.Text = "Save Settings";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(663, 312);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(100, 26);
            this.Run.TabIndex = 33;
            this.Run.Text = "Check Items Now";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // opnlst
            // 
            this.opnlst.Controls.Add(this.RemoveOpenItem);
            this.opnlst.Controls.Add(this.OpnList);
            this.opnlst.Location = new System.Drawing.Point(485, 31);
            this.opnlst.Name = "opnlst";
            this.opnlst.Size = new System.Drawing.Size(142, 256);
            this.opnlst.TabIndex = 34;
            this.opnlst.TabStop = false;
            this.opnlst.Text = "My Open List";
            // 
            // RemoveOpenItem
            // 
            this.RemoveOpenItem.Location = new System.Drawing.Point(8, 225);
            this.RemoveOpenItem.Name = "RemoveOpenItem";
            this.RemoveOpenItem.Size = new System.Drawing.Size(129, 23);
            this.RemoveOpenItem.TabIndex = 9;
            this.RemoveOpenItem.Text = "Remove Selected Item";
            this.RemoveOpenItem.UseVisualStyleBackColor = true;
            this.RemoveOpenItem.Click += new System.EventHandler(this.RemoveOpenItem_Click);
            // 
            // OpnList
            // 
            this.OpnList.FormattingEnabled = true;
            this.OpnList.Location = new System.Drawing.Point(7, 20);
            this.OpnList.Name = "OpnList";
            this.OpnList.Size = new System.Drawing.Size(130, 199);
            this.OpnList.TabIndex = 0;
            // 
            // EnableOpen
            // 
            this.EnableOpen.AutoSize = true;
            this.EnableOpen.Location = new System.Drawing.Point(660, 6);
            this.EnableOpen.Name = "EnableOpen";
            this.EnableOpen.Size = new System.Drawing.Size(102, 17);
            this.EnableOpen.TabIndex = 35;
            this.EnableOpen.Text = "Enable Opening";
            this.EnableOpen.UseVisualStyleBackColor = true;
            this.EnableOpen.CheckedChanged += new System.EventHandler(this.EnableOpen_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Remove Gray Items that cost less then";
            // 
            // GoldBox
            // 
            this.GoldBox.Location = new System.Drawing.Point(19, 347);
            this.GoldBox.Name = "GoldBox";
            this.GoldBox.Size = new System.Drawing.Size(151, 24);
            this.GoldBox.TabIndex = 37;
            this.GoldBox.TabStop = false;
            // 
            // LootEnable
            // 
            this.LootEnable.AutoSize = true;
            this.LootEnable.Location = new System.Drawing.Point(522, 317);
            this.LootEnable.Name = "LootEnable";
            this.LootEnable.Size = new System.Drawing.Size(142, 17);
            this.LootEnable.TabIndex = 38;
            this.LootEnable.Text = "Enable Check After Loot";
            this.LootEnable.UseVisualStyleBackColor = true;
            this.LootEnable.CheckedChanged += new System.EventHandler(this.LootEnable_CheckedChanged);
            // 
            // MrItemRemover2GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 372);
            this.Controls.Add(this.LootEnable);
            this.Controls.Add(this.RefreshBagItems);
            this.Controls.Add(this.GoldGrays);
			this.Controls.Add(this.SilverGrays);
            this.Controls.Add(this.CopperGrays);
			this.Controls.Add(this.GoldWhites);
			this.Controls.Add(this.SilverWhites);
            this.Controls.Add(this.CopperWhites);
			this.Controls.Add(this.GoldGreens);
			this.Controls.Add(this.SilverGreens);
            this.Controls.Add(this.CopperGreens);
			this.Controls.Add(this.GoldBlues);
			this.Controls.Add(this.SilverBlues);
            this.Controls.Add(this.CopperBlues);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EnableOpen);
            this.Controls.Add(this.opnlst);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.RemoveQItems);
            this.Controls.Add(this.SellWhite);
            this.Controls.Add(this.SellGreen);
            this.Controls.Add(this.SellGray);
            this.Controls.Add(this.GrayItems);
			this.Controls.Add(this.WhiteItems);
			this.Controls.Add(this.GreenItems);
			this.Controls.Add(this.BlueItems);
            this.Controls.Add(this.EnableSell);
            this.Controls.Add(this.EnableRemove);
            this.Controls.Add(this.InputAddToBagItem);
            this.Controls.Add(this.AddToBagList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.GoldBox);
            this.Name = "MrItemRemover2GUI";
            this.Text = "Mr.ItemRemover2 - Removing useless stuff from your bags since the last time you u" +
    "sed this plugin.";
            this.Load += new System.EventHandler(this.MrItemRemover2GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Time)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resf)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.opnlst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GoldBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Time;
        private System.Windows.Forms.TextBox GoldGrays;
        private System.Windows.Forms.TextBox SilverGrays;
        private System.Windows.Forms.TextBox CopperGrays;
		private System.Windows.Forms.TextBox GoldWhites;
        private System.Windows.Forms.TextBox SilverWhites;
        private System.Windows.Forms.TextBox CopperWhites;
		private System.Windows.Forms.TextBox GoldGreens;
        private System.Windows.Forms.TextBox SilverGreens;
        private System.Windows.Forms.TextBox CopperGreens;
		private System.Windows.Forms.TextBox GoldBlues;
        private System.Windows.Forms.TextBox SilverBlues;
        private System.Windows.Forms.TextBox CopperBlues;
        private System.Windows.Forms.ListBox MyBag;
        private System.Windows.Forms.ListBox RemoveList;
        private System.Windows.Forms.ListBox SellList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddToRemoveList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button AddToProtList;
        private System.Windows.Forms.Button AddToSellList;
        private System.Windows.Forms.Button RemoveRemoveItem;
        private System.Windows.Forms.Button RemoveSellItem;
        private System.Windows.Forms.ListBox ProtectedList;
        private System.Windows.Forms.Button RemoveProtectedItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddToBagList;
        private System.Windows.Forms.TextBox InputAddToBagItem;
        private System.Windows.Forms.CheckBox EnableRemove;
        private System.Windows.Forms.CheckBox EnableSell;
        private System.Windows.Forms.Button RefreshBagItems;
        private System.Windows.Forms.CheckBox SellWhite;
        private System.Windows.Forms.CheckBox SellGreen;
        private System.Windows.Forms.CheckBox SellGray;
        private System.Windows.Forms.CheckBox GrayItems;
		private System.Windows.Forms.CheckBox WhiteItems;
		private System.Windows.Forms.CheckBox GreenItems;
		private System.Windows.Forms.CheckBox BlueItems;
        private System.Windows.Forms.CheckBox RemoveQItems;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.GroupBox opnlst;
        private System.Windows.Forms.Button RemoveOpenItem;
        private System.Windows.Forms.ListBox OpnList;
        private System.Windows.Forms.CheckBox EnableOpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox GoldBox;
        private System.Windows.Forms.PictureBox resf;
        private System.Windows.Forms.Button AddToOpnList;
        private System.Windows.Forms.CheckBox LootEnable;
    }
}