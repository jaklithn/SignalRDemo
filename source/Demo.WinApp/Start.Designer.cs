namespace Demo.WinApp
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Start()
        {
            InitializeComponent();
        }

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
			this.txtChatList = new System.Windows.Forms.TextBox();
			this.txtChatMessage = new System.Windows.Forms.TextBox();
			this.btnSendChat = new System.Windows.Forms.Button();
			this.txtSentLog = new System.Windows.Forms.TextBox();
			this.btnSendScreenDump = new System.Windows.Forms.Button();
			this.btnSendOnline = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.chkLogChat = new System.Windows.Forms.CheckBox();
			this.tabMain = new System.Windows.Forms.TabControl();
			this.tabChat = new System.Windows.Forms.TabPage();
			this.tabLunch = new System.Windows.Forms.TabPage();
			this.btnSuggestLunch = new System.Windows.Forms.Button();
			this.txtFishPrice = new System.Windows.Forms.TextBox();
			this.txtVegetarianPrice = new System.Windows.Forms.TextBox();
			this.txtMeatPrice = new System.Windows.Forms.TextBox();
			this.lblVegetarian = new System.Windows.Forms.Label();
			this.lblFish = new System.Windows.Forms.Label();
			this.lblMeat = new System.Windows.Forms.Label();
			this.btnSendLunch = new System.Windows.Forms.Button();
			this.txtFish = new System.Windows.Forms.TextBox();
			this.txtVegetarian = new System.Windows.Forms.TextBox();
			this.txtMeat = new System.Windows.Forms.TextBox();
			this.tabPublish = new System.Windows.Forms.TabPage();
			this.lstMachines = new System.Windows.Forms.ListBox();
			this.lblMachines = new System.Windows.Forms.Label();
			this.tabDashboard = new System.Windows.Forms.TabPage();
			this.optSensorPause = new System.Windows.Forms.RadioButton();
			this.optSensorStop = new System.Windows.Forms.RadioButton();
			this.optSensorSend = new System.Windows.Forms.RadioButton();
			this.tabMap = new System.Windows.Forms.TabPage();
			this.optPositionPause = new System.Windows.Forms.RadioButton();
			this.optPositionStop = new System.Windows.Forms.RadioButton();
			this.optPositionSend = new System.Windows.Forms.RadioButton();
			this.tabMain.SuspendLayout();
			this.tabChat.SuspendLayout();
			this.tabLunch.SuspendLayout();
			this.tabPublish.SuspendLayout();
			this.tabDashboard.SuspendLayout();
			this.tabMap.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtChatList
			// 
			this.txtChatList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtChatList.BackColor = System.Drawing.SystemColors.Window;
			this.txtChatList.Location = new System.Drawing.Point(6, 4);
			this.txtChatList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtChatList.Multiline = true;
			this.txtChatList.Name = "txtChatList";
			this.txtChatList.ReadOnly = true;
			this.txtChatList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtChatList.Size = new System.Drawing.Size(440, 412);
			this.txtChatList.TabIndex = 0;
			this.txtChatList.TabStop = false;
			this.txtChatList.Enter += new System.EventHandler(this.txtChatList_Enter);
			// 
			// txtChatMessage
			// 
			this.txtChatMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtChatMessage.Location = new System.Drawing.Point(8, 436);
			this.txtChatMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtChatMessage.Name = "txtChatMessage";
			this.txtChatMessage.Size = new System.Drawing.Size(251, 25);
			this.txtChatMessage.TabIndex = 1;
			// 
			// btnSendChat
			// 
			this.btnSendChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSendChat.Location = new System.Drawing.Point(266, 433);
			this.btnSendChat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSendChat.Name = "btnSendChat";
			this.btnSendChat.Size = new System.Drawing.Size(87, 30);
			this.btnSendChat.TabIndex = 2;
			this.btnSendChat.Text = "Send";
			this.btnSendChat.UseVisualStyleBackColor = true;
			this.btnSendChat.Click += new System.EventHandler(this.btnSendChat_Click);
			// 
			// txtSentLog
			// 
			this.txtSentLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSentLog.BackColor = System.Drawing.SystemColors.Window;
			this.txtSentLog.Location = new System.Drawing.Point(452, 4);
			this.txtSentLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtSentLog.Multiline = true;
			this.txtSentLog.Name = "txtSentLog";
			this.txtSentLog.ReadOnly = true;
			this.txtSentLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtSentLog.Size = new System.Drawing.Size(144, 412);
			this.txtSentLog.TabIndex = 3;
			this.txtSentLog.TabStop = false;
			this.txtSentLog.Visible = false;
			// 
			// btnSendScreenDump
			// 
			this.btnSendScreenDump.Location = new System.Drawing.Point(77, 313);
			this.btnSendScreenDump.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSendScreenDump.Name = "btnSendScreenDump";
			this.btnSendScreenDump.Size = new System.Drawing.Size(190, 30);
			this.btnSendScreenDump.TabIndex = 6;
			this.btnSendScreenDump.Text = "Send ScreenDump is Ready";
			this.btnSendScreenDump.UseVisualStyleBackColor = true;
			this.btnSendScreenDump.Click += new System.EventHandler(this.btnSendScreenDump_Click);
			// 
			// btnSendOnline
			// 
			this.btnSendOnline.Location = new System.Drawing.Point(77, 275);
			this.btnSendOnline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSendOnline.Name = "btnSendOnline";
			this.btnSendOnline.Size = new System.Drawing.Size(190, 30);
			this.btnSendOnline.TabIndex = 7;
			this.btnSendOnline.Text = "Send Machine is Online";
			this.btnSendOnline.UseVisualStyleBackColor = true;
			this.btnSendOnline.Click += new System.EventHandler(this.btnSendOnline_Click);
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnClear.Location = new System.Drawing.Point(359, 433);
			this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(87, 30);
			this.btnClear.TabIndex = 8;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClearHat_Click);
			// 
			// chkLogChat
			// 
			this.chkLogChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chkLogChat.AutoSize = true;
			this.chkLogChat.Location = new System.Drawing.Point(467, 438);
			this.chkLogChat.Name = "chkLogChat";
			this.chkLogChat.Size = new System.Drawing.Size(134, 21);
			this.chkLogChat.TabIndex = 9;
			this.chkLogChat.Text = "Log sending times";
			this.chkLogChat.UseVisualStyleBackColor = true;
			this.chkLogChat.CheckedChanged += new System.EventHandler(this.chkLogChat_CheckedChanged);
			// 
			// tabMain
			// 
			this.tabMain.Controls.Add(this.tabChat);
			this.tabMain.Controls.Add(this.tabPublish);
			this.tabMain.Controls.Add(this.tabLunch);
			this.tabMain.Controls.Add(this.tabDashboard);
			this.tabMain.Controls.Add(this.tabMap);
			this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabMain.ItemSize = new System.Drawing.Size(96, 32);
			this.tabMain.Location = new System.Drawing.Point(0, 0);
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(612, 514);
			this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabMain.TabIndex = 10;
			// 
			// tabChat
			// 
			this.tabChat.BackColor = System.Drawing.SystemColors.Control;
			this.tabChat.Controls.Add(this.txtChatList);
			this.tabChat.Controls.Add(this.chkLogChat);
			this.tabChat.Controls.Add(this.btnClear);
			this.tabChat.Controls.Add(this.txtChatMessage);
			this.tabChat.Controls.Add(this.txtSentLog);
			this.tabChat.Controls.Add(this.btnSendChat);
			this.tabChat.Location = new System.Drawing.Point(4, 36);
			this.tabChat.Name = "tabChat";
			this.tabChat.Padding = new System.Windows.Forms.Padding(3);
			this.tabChat.Size = new System.Drawing.Size(604, 474);
			this.tabChat.TabIndex = 1;
			this.tabChat.Text = "Chat";
			// 
			// tabLunch
			// 
			this.tabLunch.BackColor = System.Drawing.SystemColors.Control;
			this.tabLunch.Controls.Add(this.btnSuggestLunch);
			this.tabLunch.Controls.Add(this.txtFishPrice);
			this.tabLunch.Controls.Add(this.txtVegetarianPrice);
			this.tabLunch.Controls.Add(this.txtMeatPrice);
			this.tabLunch.Controls.Add(this.lblVegetarian);
			this.tabLunch.Controls.Add(this.lblFish);
			this.tabLunch.Controls.Add(this.lblMeat);
			this.tabLunch.Controls.Add(this.btnSendLunch);
			this.tabLunch.Controls.Add(this.txtFish);
			this.tabLunch.Controls.Add(this.txtVegetarian);
			this.tabLunch.Controls.Add(this.txtMeat);
			this.tabLunch.Location = new System.Drawing.Point(4, 36);
			this.tabLunch.Name = "tabLunch";
			this.tabLunch.Padding = new System.Windows.Forms.Padding(3);
			this.tabLunch.Size = new System.Drawing.Size(604, 474);
			this.tabLunch.TabIndex = 5;
			this.tabLunch.Text = "Lunch";
			// 
			// btnSuggestLunch
			// 
			this.btnSuggestLunch.Location = new System.Drawing.Point(202, 285);
			this.btnSuggestLunch.Name = "btnSuggestLunch";
			this.btnSuggestLunch.Size = new System.Drawing.Size(98, 35);
			this.btnSuggestLunch.TabIndex = 7;
			this.btnSuggestLunch.Text = "Suggest";
			this.btnSuggestLunch.UseVisualStyleBackColor = true;
			this.btnSuggestLunch.Click += new System.EventHandler(this.btnSuggestLunch_Click);
			// 
			// txtFishPrice
			// 
			this.txtFishPrice.Location = new System.Drawing.Point(541, 122);
			this.txtFishPrice.Name = "txtFishPrice";
			this.txtFishPrice.Size = new System.Drawing.Size(55, 25);
			this.txtFishPrice.TabIndex = 3;
			this.txtFishPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtVegetarianPrice
			// 
			this.txtVegetarianPrice.Location = new System.Drawing.Point(541, 186);
			this.txtVegetarianPrice.Name = "txtVegetarianPrice";
			this.txtVegetarianPrice.Size = new System.Drawing.Size(55, 25);
			this.txtVegetarianPrice.TabIndex = 5;
			this.txtVegetarianPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtMeatPrice
			// 
			this.txtMeatPrice.Location = new System.Drawing.Point(541, 58);
			this.txtMeatPrice.Name = "txtMeatPrice";
			this.txtMeatPrice.Size = new System.Drawing.Size(55, 25);
			this.txtMeatPrice.TabIndex = 1;
			this.txtMeatPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblVegetarian
			// 
			this.lblVegetarian.AutoSize = true;
			this.lblVegetarian.Location = new System.Drawing.Point(14, 189);
			this.lblVegetarian.Name = "lblVegetarian";
			this.lblVegetarian.Size = new System.Drawing.Size(70, 17);
			this.lblVegetarian.TabIndex = 6;
			this.lblVegetarian.Text = "Vegetarian";
			// 
			// lblFish
			// 
			this.lblFish.AutoSize = true;
			this.lblFish.Location = new System.Drawing.Point(14, 125);
			this.lblFish.Name = "lblFish";
			this.lblFish.Size = new System.Drawing.Size(30, 17);
			this.lblFish.TabIndex = 5;
			this.lblFish.Text = "Fish";
			// 
			// lblMeat
			// 
			this.lblMeat.AutoSize = true;
			this.lblMeat.Location = new System.Drawing.Point(14, 61);
			this.lblMeat.Name = "lblMeat";
			this.lblMeat.Size = new System.Drawing.Size(38, 17);
			this.lblMeat.TabIndex = 4;
			this.lblMeat.Text = "Meat";
			// 
			// btnSendLunch
			// 
			this.btnSendLunch.Location = new System.Drawing.Point(336, 285);
			this.btnSendLunch.Name = "btnSendLunch";
			this.btnSendLunch.Size = new System.Drawing.Size(98, 35);
			this.btnSendLunch.TabIndex = 6;
			this.btnSendLunch.Text = "Send";
			this.btnSendLunch.UseVisualStyleBackColor = true;
			this.btnSendLunch.Click += new System.EventHandler(this.btnSendLunch_Click);
			// 
			// txtFish
			// 
			this.txtFish.Location = new System.Drawing.Point(92, 122);
			this.txtFish.Multiline = true;
			this.txtFish.Name = "txtFish";
			this.txtFish.Size = new System.Drawing.Size(428, 51);
			this.txtFish.TabIndex = 2;
			// 
			// txtVegetarian
			// 
			this.txtVegetarian.Location = new System.Drawing.Point(92, 186);
			this.txtVegetarian.Multiline = true;
			this.txtVegetarian.Name = "txtVegetarian";
			this.txtVegetarian.Size = new System.Drawing.Size(428, 51);
			this.txtVegetarian.TabIndex = 4;
			// 
			// txtMeat
			// 
			this.txtMeat.Location = new System.Drawing.Point(92, 58);
			this.txtMeat.Multiline = true;
			this.txtMeat.Name = "txtMeat";
			this.txtMeat.Size = new System.Drawing.Size(428, 51);
			this.txtMeat.TabIndex = 0;
			// 
			// tabPublish
			// 
			this.tabPublish.BackColor = System.Drawing.SystemColors.Control;
			this.tabPublish.Controls.Add(this.lstMachines);
			this.tabPublish.Controls.Add(this.lblMachines);
			this.tabPublish.Controls.Add(this.btnSendOnline);
			this.tabPublish.Controls.Add(this.btnSendScreenDump);
			this.tabPublish.Location = new System.Drawing.Point(4, 36);
			this.tabPublish.Name = "tabPublish";
			this.tabPublish.Padding = new System.Windows.Forms.Padding(3);
			this.tabPublish.Size = new System.Drawing.Size(604, 474);
			this.tabPublish.TabIndex = 0;
			this.tabPublish.Text = "Publish";
			// 
			// lstMachines
			// 
			this.lstMachines.DisplayMember = "Name";
			this.lstMachines.FormattingEnabled = true;
			this.lstMachines.ItemHeight = 17;
			this.lstMachines.Location = new System.Drawing.Point(77, 57);
			this.lstMachines.Name = "lstMachines";
			this.lstMachines.Size = new System.Drawing.Size(120, 191);
			this.lstMachines.TabIndex = 10;
			this.lstMachines.ValueMember = "Id";
			// 
			// lblMachines
			// 
			this.lblMachines.AutoSize = true;
			this.lblMachines.Location = new System.Drawing.Point(86, 37);
			this.lblMachines.Name = "lblMachines";
			this.lblMachines.Size = new System.Drawing.Size(63, 17);
			this.lblMachines.TabIndex = 9;
			this.lblMachines.Text = "Machines";
			// 
			// tabDashboard
			// 
			this.tabDashboard.BackColor = System.Drawing.SystemColors.Control;
			this.tabDashboard.Controls.Add(this.optSensorPause);
			this.tabDashboard.Controls.Add(this.optSensorStop);
			this.tabDashboard.Controls.Add(this.optSensorSend);
			this.tabDashboard.Location = new System.Drawing.Point(4, 36);
			this.tabDashboard.Name = "tabDashboard";
			this.tabDashboard.Size = new System.Drawing.Size(604, 474);
			this.tabDashboard.TabIndex = 3;
			this.tabDashboard.Text = "Dashboard";
			// 
			// optSensorPause
			// 
			this.optSensorPause.Appearance = System.Windows.Forms.Appearance.Button;
			this.optSensorPause.Location = new System.Drawing.Point(194, 184);
			this.optSensorPause.Name = "optSensorPause";
			this.optSensorPause.Size = new System.Drawing.Size(140, 35);
			this.optSensorPause.TabIndex = 12;
			this.optSensorPause.Text = "Pause";
			this.optSensorPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.optSensorPause.UseVisualStyleBackColor = true;
			this.optSensorPause.CheckedChanged += new System.EventHandler(this.Sensor_CheckedChanged);
			// 
			// optSensorStop
			// 
			this.optSensorStop.Appearance = System.Windows.Forms.Appearance.Button;
			this.optSensorStop.Checked = true;
			this.optSensorStop.Location = new System.Drawing.Point(194, 235);
			this.optSensorStop.Name = "optSensorStop";
			this.optSensorStop.Size = new System.Drawing.Size(140, 35);
			this.optSensorStop.TabIndex = 11;
			this.optSensorStop.TabStop = true;
			this.optSensorStop.Text = "Stop";
			this.optSensorStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.optSensorStop.UseVisualStyleBackColor = true;
			this.optSensorStop.CheckedChanged += new System.EventHandler(this.Sensor_CheckedChanged);
			// 
			// optSensorSend
			// 
			this.optSensorSend.Appearance = System.Windows.Forms.Appearance.Button;
			this.optSensorSend.Location = new System.Drawing.Point(194, 133);
			this.optSensorSend.Name = "optSensorSend";
			this.optSensorSend.Size = new System.Drawing.Size(140, 35);
			this.optSensorSend.TabIndex = 10;
			this.optSensorSend.Text = "Send Sensor values";
			this.optSensorSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.optSensorSend.UseVisualStyleBackColor = true;
			this.optSensorSend.CheckedChanged += new System.EventHandler(this.Sensor_CheckedChanged);
			// 
			// tabMap
			// 
			this.tabMap.BackColor = System.Drawing.SystemColors.Control;
			this.tabMap.Controls.Add(this.optPositionPause);
			this.tabMap.Controls.Add(this.optPositionStop);
			this.tabMap.Controls.Add(this.optPositionSend);
			this.tabMap.Location = new System.Drawing.Point(4, 36);
			this.tabMap.Name = "tabMap";
			this.tabMap.Size = new System.Drawing.Size(604, 474);
			this.tabMap.TabIndex = 4;
			this.tabMap.Text = "Map";
			// 
			// optPositionPause
			// 
			this.optPositionPause.Appearance = System.Windows.Forms.Appearance.Button;
			this.optPositionPause.Location = new System.Drawing.Point(194, 184);
			this.optPositionPause.Name = "optPositionPause";
			this.optPositionPause.Size = new System.Drawing.Size(140, 35);
			this.optPositionPause.TabIndex = 14;
			this.optPositionPause.Text = "Pause";
			this.optPositionPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.optPositionPause.UseVisualStyleBackColor = true;
			this.optPositionPause.CheckedChanged += new System.EventHandler(this.Map_CheckedChanged);
			// 
			// optPositionStop
			// 
			this.optPositionStop.Appearance = System.Windows.Forms.Appearance.Button;
			this.optPositionStop.Checked = true;
			this.optPositionStop.Location = new System.Drawing.Point(194, 235);
			this.optPositionStop.Name = "optPositionStop";
			this.optPositionStop.Size = new System.Drawing.Size(140, 35);
			this.optPositionStop.TabIndex = 13;
			this.optPositionStop.TabStop = true;
			this.optPositionStop.Text = "Stop";
			this.optPositionStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.optPositionStop.UseVisualStyleBackColor = true;
			this.optPositionStop.CheckedChanged += new System.EventHandler(this.Map_CheckedChanged);
			// 
			// optPositionSend
			// 
			this.optPositionSend.Appearance = System.Windows.Forms.Appearance.Button;
			this.optPositionSend.Location = new System.Drawing.Point(194, 133);
			this.optPositionSend.Name = "optPositionSend";
			this.optPositionSend.Size = new System.Drawing.Size(140, 35);
			this.optPositionSend.TabIndex = 12;
			this.optPositionSend.Text = "Send Positions";
			this.optPositionSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.optPositionSend.UseVisualStyleBackColor = true;
			this.optPositionSend.CheckedChanged += new System.EventHandler(this.Map_CheckedChanged);
			// 
			// Start
			// 
			this.AcceptButton = this.btnSendChat;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(612, 514);
			this.Controls.Add(this.tabMain);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Start";
			this.Text = "SignalR Demo";
			this.Load += new System.EventHandler(this.Start_Load);
			this.tabMain.ResumeLayout(false);
			this.tabChat.ResumeLayout(false);
			this.tabChat.PerformLayout();
			this.tabLunch.ResumeLayout(false);
			this.tabLunch.PerformLayout();
			this.tabPublish.ResumeLayout(false);
			this.tabPublish.PerformLayout();
			this.tabDashboard.ResumeLayout(false);
			this.tabMap.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtChatList;
        private System.Windows.Forms.TextBox txtChatMessage;
        private System.Windows.Forms.Button btnSendChat;
        private System.Windows.Forms.Button btnSendScreenDump;
        private System.Windows.Forms.Button btnSendOnline;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.TextBox txtSentLog;
		private System.Windows.Forms.CheckBox chkLogChat;
		private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.TabPage tabPublish;
		private System.Windows.Forms.TabPage tabChat;
		private System.Windows.Forms.Label lblMachines;
		private System.Windows.Forms.ListBox lstMachines;
		private System.Windows.Forms.TabPage tabDashboard;
		private System.Windows.Forms.TabPage tabMap;
		private System.Windows.Forms.RadioButton optSensorStop;
		private System.Windows.Forms.RadioButton optSensorSend;
        private System.Windows.Forms.RadioButton optPositionStop;
        private System.Windows.Forms.RadioButton optPositionSend;
        private System.Windows.Forms.RadioButton optSensorPause;
        private System.Windows.Forms.RadioButton optPositionPause;
        private System.Windows.Forms.TabPage tabLunch;
        private System.Windows.Forms.Label lblVegetarian;
        private System.Windows.Forms.Label lblFish;
        private System.Windows.Forms.Label lblMeat;
        private System.Windows.Forms.Button btnSendLunch;
        private System.Windows.Forms.TextBox txtFish;
        private System.Windows.Forms.TextBox txtVegetarian;
        private System.Windows.Forms.TextBox txtMeat;
        private System.Windows.Forms.TextBox txtFishPrice;
        private System.Windows.Forms.TextBox txtVegetarianPrice;
        private System.Windows.Forms.TextBox txtMeatPrice;
        private System.Windows.Forms.Button btnSuggestLunch;
    }
}

