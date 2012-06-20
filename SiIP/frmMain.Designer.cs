namespace SiIP
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cboxNetCard = new System.Windows.Forms.ComboBox();
            this.cboxProfile = new System.Windows.Forms.ComboBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.lblNetCard = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.bkWorker = new System.ComponentModel.BackgroundWorker();
            this.chkShowDetail = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCurrentConfig = new System.Windows.Forms.Label();
            this.lblProfilSelected = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbCurIP = new System.Windows.Forms.TextBox();
            this.tbCurSubnet = new System.Windows.Forms.TextBox();
            this.tbCurGateway = new System.Windows.Forms.TextBox();
            this.tbCurDNS = new System.Windows.Forms.TextBox();
            this.tbDNS = new System.Windows.Forms.TextBox();
            this.tbGateway = new System.Windows.Forms.TextBox();
            this.tbSubnet = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiFastestDNS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlushDNS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.bkWorkerLoadNic = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxNetCard
            // 
            this.cboxNetCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxNetCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxNetCard.DropDownWidth = 285;
            this.cboxNetCard.Enabled = false;
            this.cboxNetCard.FormattingEnabled = true;
            this.helpProvider1.SetHelpKeyword(this.cboxNetCard, "Network Card");
            this.helpProvider1.SetHelpNavigator(this.cboxNetCard, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetHelpString(this.cboxNetCard, "Tentukan network card yang akan di pasang IP/DNS sesuai profil yang dipilih");
            this.cboxNetCard.ItemHeight = 13;
            this.cboxNetCard.Location = new System.Drawing.Point(62, 43);
            this.cboxNetCard.Name = "cboxNetCard";
            this.helpProvider1.SetShowHelp(this.cboxNetCard, true);
            this.cboxNetCard.Size = new System.Drawing.Size(316, 21);
            this.cboxNetCard.TabIndex = 2;
            this.cboxNetCard.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboxProfile
            // 
            this.cboxProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProfile.Enabled = false;
            this.cboxProfile.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.cboxProfile, "Daftar profil yang tersedia");
            this.cboxProfile.ItemHeight = 13;
            this.cboxProfile.Location = new System.Drawing.Point(62, 92);
            this.cboxProfile.Name = "cboxProfile";
            this.helpProvider1.SetShowHelp(this.cboxProfile, true);
            this.cboxProfile.Size = new System.Drawing.Size(316, 21);
            this.cboxProfile.TabIndex = 3;
            this.cboxProfile.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnActivate
            // 
            this.btnActivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActivate.Enabled = false;
            this.helpProvider1.SetHelpString(this.btnActivate, "Jika \'Network Card\' dan \'Profil\' sudah ditentukan, klik tombil ini untuk mulai me" +
                    "masang konfigurasi");
            this.btnActivate.Image = global::SiIP.Properties.Resources.aplly;
            this.btnActivate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivate.Location = new System.Drawing.Point(147, 137);
            this.btnActivate.Name = "btnActivate";
            this.helpProvider1.SetShowHelp(this.btnActivate, true);
            this.btnActivate.Size = new System.Drawing.Size(110, 24);
            this.btnActivate.TabIndex = 0;
            this.btnActivate.Text = "Activate Profile";
            this.btnActivate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnManage
            // 
            this.btnManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManage.Enabled = false;
            this.helpProvider1.SetHelpString(this.btnManage, "Konfigurasi tingkat lanjut");
            this.btnManage.Image = global::SiIP.Properties.Resources.advance;
            this.btnManage.Location = new System.Drawing.Point(263, 137);
            this.btnManage.Name = "btnManage";
            this.helpProvider1.SetShowHelp(this.btnManage, true);
            this.btnManage.Size = new System.Drawing.Size(85, 24);
            this.btnManage.TabIndex = 1;
            this.btnManage.Text = "Manage...";
            this.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNetCard
            // 
            this.lblNetCard.AutoSize = true;
            this.lblNetCard.BackColor = System.Drawing.Color.Transparent;
            this.lblNetCard.Location = new System.Drawing.Point(59, 27);
            this.lblNetCard.Name = "lblNetCard";
            this.lblNetCard.Size = new System.Drawing.Size(75, 13);
            this.lblNetCard.TabIndex = 5;
            this.lblNetCard.Text = "Network &Card:";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblProfile.Location = new System.Drawing.Point(59, 76);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(39, 13);
            this.lblProfile.TabIndex = 6;
            this.lblProfile.Text = "&Profile:";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdvanced.Enabled = false;
            this.helpProvider1.SetHelpString(this.btnAdvanced, "Konfigurasi tingkat lanjut");
            this.btnAdvanced.Image = global::SiIP.Properties.Resources.tool;
            this.btnAdvanced.Location = new System.Drawing.Point(354, 137);
            this.btnAdvanced.Name = "btnAdvanced";
            this.helpProvider1.SetShowHelp(this.btnAdvanced, true);
            this.btnAdvanced.Size = new System.Drawing.Size(24, 24);
            this.btnAdvanced.TabIndex = 39;
            this.toolTip1.SetToolTip(this.btnAdvanced, "Advanced Tools");
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.helpProvider1.SetHelpString(this.pictureBox1, "Ikon ini sebagai indikator status kartu jaringan");
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.helpProvider1.SetShowHelp(this.pictureBox1, true);
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 359);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(384, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Value = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(3, 342);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 14);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "ready";
            // 
            // bkWorker
            // 
            this.bkWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkWorker_DoWork);
            this.bkWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkWorker_RunWorkerCompleted);
            // 
            // chkShowDetail
            // 
            this.chkShowDetail.AutoSize = true;
            this.chkShowDetail.BackColor = System.Drawing.Color.Transparent;
            this.chkShowDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowDetail.Location = new System.Drawing.Point(13, 144);
            this.chkShowDetail.Name = "chkShowDetail";
            this.chkShowDetail.Size = new System.Drawing.Size(81, 17);
            this.chkShowDetail.TabIndex = 10;
            this.chkShowDetail.Text = "Show detail";
            this.chkShowDetail.UseVisualStyleBackColor = false;
            this.chkShowDetail.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Subnet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gateway";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "DNS";
            // 
            // lblCurrentConfig
            // 
            this.lblCurrentConfig.AutoSize = true;
            this.lblCurrentConfig.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentConfig.Location = new System.Drawing.Point(3, 2);
            this.lblCurrentConfig.Name = "lblCurrentConfig";
            this.lblCurrentConfig.Size = new System.Drawing.Size(154, 14);
            this.lblCurrentConfig.TabIndex = 19;
            this.lblCurrentConfig.Text = "Current Configuration";
            // 
            // lblProfilSelected
            // 
            this.lblProfilSelected.AutoSize = true;
            this.lblProfilSelected.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilSelected.Location = new System.Drawing.Point(3, 80);
            this.lblProfilSelected.Name = "lblProfilSelected";
            this.lblProfilSelected.Size = new System.Drawing.Size(119, 14);
            this.lblProfilSelected.TabIndex = 28;
            this.lblProfilSelected.Text = "Profile Selected";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(14, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 14);
            this.label17.TabIndex = 23;
            this.label17.Text = "DNS";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 14);
            this.label18.TabIndex = 22;
            this.label18.Text = "Gateway";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 14);
            this.label19.TabIndex = 21;
            this.label19.Text = "Subnet";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(14, 94);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 14);
            this.label20.TabIndex = 20;
            this.label20.Text = "IP";
            // 
            // tbCurIP
            // 
            this.tbCurIP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCurIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCurIP.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurIP.Location = new System.Drawing.Point(81, 19);
            this.tbCurIP.Name = "tbCurIP";
            this.tbCurIP.Size = new System.Drawing.Size(290, 13);
            this.tbCurIP.TabIndex = 29;
            // 
            // tbCurSubnet
            // 
            this.tbCurSubnet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCurSubnet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCurSubnet.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurSubnet.Location = new System.Drawing.Point(81, 32);
            this.tbCurSubnet.Name = "tbCurSubnet";
            this.tbCurSubnet.Size = new System.Drawing.Size(290, 13);
            this.tbCurSubnet.TabIndex = 30;
            // 
            // tbCurGateway
            // 
            this.tbCurGateway.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCurGateway.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCurGateway.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurGateway.Location = new System.Drawing.Point(81, 44);
            this.tbCurGateway.Name = "tbCurGateway";
            this.tbCurGateway.Size = new System.Drawing.Size(290, 13);
            this.tbCurGateway.TabIndex = 31;
            // 
            // tbCurDNS
            // 
            this.tbCurDNS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCurDNS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCurDNS.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurDNS.Location = new System.Drawing.Point(81, 57);
            this.tbCurDNS.Name = "tbCurDNS";
            this.tbCurDNS.Size = new System.Drawing.Size(290, 13);
            this.tbCurDNS.TabIndex = 32;
            // 
            // tbDNS
            // 
            this.tbDNS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbDNS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDNS.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDNS.Location = new System.Drawing.Point(81, 132);
            this.tbDNS.Name = "tbDNS";
            this.tbDNS.Size = new System.Drawing.Size(290, 13);
            this.tbDNS.TabIndex = 36;
            // 
            // tbGateway
            // 
            this.tbGateway.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbGateway.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGateway.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGateway.Location = new System.Drawing.Point(81, 119);
            this.tbGateway.Name = "tbGateway";
            this.tbGateway.Size = new System.Drawing.Size(290, 13);
            this.tbGateway.TabIndex = 35;
            // 
            // tbSubnet
            // 
            this.tbSubnet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSubnet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSubnet.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubnet.Location = new System.Drawing.Point(81, 107);
            this.tbSubnet.Name = "tbSubnet";
            this.tbSubnet.Size = new System.Drawing.Size(290, 13);
            this.tbSubnet.TabIndex = 34;
            // 
            // tbIP
            // 
            this.tbIP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIP.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIP.Location = new System.Drawing.Point(81, 94);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(290, 13);
            this.tbIP.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.lblCurrentConfig);
            this.panel2.Controls.Add(this.tbDNS);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbGateway);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbSubnet);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbIP);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbCurDNS);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.tbCurGateway);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.tbCurSubnet);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.tbCurIP);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.lblProfilSelected);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(5, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 157);
            this.panel2.TabIndex = 38;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFastestDNS,
            this.tsmiFlushDNS,
            this.tsmiBackup,
            this.tsmiRestore});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 92);
            // 
            // tsmiFastestDNS
            // 
            this.tsmiFastestDNS.Enabled = false;
            this.tsmiFastestDNS.Image = global::SiIP.Properties.Resources.fastest;
            this.tsmiFastestDNS.Name = "tsmiFastestDNS";
            this.tsmiFastestDNS.Size = new System.Drawing.Size(133, 22);
            this.tsmiFastestDNS.Text = "Fastest DNS";
            // 
            // tsmiFlushDNS
            // 
            this.tsmiFlushDNS.Image = global::SiIP.Properties.Resources.flush;
            this.tsmiFlushDNS.Name = "tsmiFlushDNS";
            this.tsmiFlushDNS.Size = new System.Drawing.Size(133, 22);
            this.tsmiFlushDNS.Text = "Flush DNS";
            this.tsmiFlushDNS.Click += new System.EventHandler(this.tsmiFlushDNS_Click);
            // 
            // tsmiBackup
            // 
            this.tsmiBackup.Enabled = false;
            this.tsmiBackup.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBackup.Image")));
            this.tsmiBackup.Name = "tsmiBackup";
            this.tsmiBackup.Size = new System.Drawing.Size(133, 22);
            this.tsmiBackup.Text = "Backup";
            this.tsmiBackup.Visible = false;
            // 
            // tsmiRestore
            // 
            this.tsmiRestore.Enabled = false;
            this.tsmiRestore.Image = global::SiIP.Properties.Resources.restore;
            this.tsmiRestore.Name = "tsmiRestore";
            this.tsmiRestore.Size = new System.Drawing.Size(133, 22);
            this.tsmiRestore.Text = "Restore";
            // 
            // bkWorkerLoadNic
            // 
            this.bkWorkerLoadNic.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkWorkerLoadNic_DoWork);
            this.bkWorkerLoadNic.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkWorkerLoadNic_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SiIP.Properties.Resources.latar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chkShowDetail);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.lblNetCard);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.cboxProfile);
            this.Controls.Add(this.cboxNetCard);
            this.Controls.Add(this.btnAdvanced);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP/DNS Switcher";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxNetCard;
        private System.Windows.Forms.ComboBox cboxProfile;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Label lblNetCard;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblStatus;
        private System.ComponentModel.BackgroundWorker bkWorker;
        private System.Windows.Forms.CheckBox chkShowDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCurrentConfig;
        private System.Windows.Forms.Label lblProfilSelected;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbCurIP;
        private System.Windows.Forms.TextBox tbCurSubnet;
        private System.Windows.Forms.TextBox tbCurGateway;
        private System.Windows.Forms.TextBox tbCurDNS;
        private System.Windows.Forms.TextBox tbDNS;
        private System.Windows.Forms.TextBox tbGateway;
        private System.Windows.Forms.TextBox tbSubnet;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFastestDNS;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlushDNS;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackup;
        private System.Windows.Forms.ToolStripMenuItem tsmiRestore;
        private System.ComponentModel.BackgroundWorker bkWorkerLoadNic;
    }
}

