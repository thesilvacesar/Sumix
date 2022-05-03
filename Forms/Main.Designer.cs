namespace Sumix
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.openBtn = new System.Windows.Forms.Button();
            this.copyHash = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.algoBox = new System.Windows.Forms.ComboBox();
            this.fileInput = new System.Windows.Forms.TextBox();
            this.openDlg = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tips = new System.Windows.Forms.ToolTip(this.components);
            this.restoreBtn = new System.Windows.Forms.Button();
            this.compareBtn = new System.Windows.Forms.Button();
            this.pasteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.saveDlg = new System.Windows.Forms.SaveFileDialog();
            this.hashInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.compareCheck = new System.Windows.Forms.CheckBox();
            this.showWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.hideWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.verifyChecksum = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.base64Box = new System.Windows.Forms.CheckBox();
            this.hashCompareInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.algoCompareBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.panelVerify = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.panelVerify.SuspendLayout();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openBtn.BackColor = System.Drawing.Color.Transparent;
            this.openBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.openBtn.FlatAppearance.BorderSize = 0;
            this.openBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.openBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openBtn.Image = ((System.Drawing.Image)(resources.GetObject("openBtn.Image")));
            this.openBtn.Location = new System.Drawing.Point(416, 70);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(38, 30);
            this.openBtn.TabIndex = 0;
            this.tips.SetToolTip(this.openBtn, "Open file...");
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // copyHash
            // 
            this.copyHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyHash.BackColor = System.Drawing.Color.Transparent;
            this.copyHash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyHash.FlatAppearance.BorderSize = 0;
            this.copyHash.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.copyHash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.copyHash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.copyHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyHash.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyHash.Image = ((System.Drawing.Image)(resources.GetObject("copyHash.Image")));
            this.copyHash.Location = new System.Drawing.Point(372, 137);
            this.copyHash.Name = "copyHash";
            this.copyHash.Size = new System.Drawing.Size(38, 30);
            this.copyHash.TabIndex = 7;
            this.tips.SetToolTip(this.copyHash, "Copy hash");
            this.copyHash.UseVisualStyleBackColor = false;
            this.copyHash.Click += new System.EventHandler(this.copyHash_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportBtn.BackColor = System.Drawing.Color.Transparent;
            this.exportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportBtn.FlatAppearance.BorderSize = 0;
            this.exportBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.exportBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.exportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exportBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportBtn.Image")));
            this.exportBtn.Location = new System.Drawing.Point(416, 137);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(38, 30);
            this.exportBtn.TabIndex = 5;
            this.tips.SetToolTip(this.exportBtn, "Export hash");
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // algoBox
            // 
            this.algoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.algoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.algoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.algoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algoBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.algoBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.algoBox.FormattingEnabled = true;
            this.algoBox.Items.AddRange(new object[] {
            "MD 5",
            "SHA 1",
            "SHA 256",
            "SHA 384",
            "SHA 512"});
            this.algoBox.Location = new System.Drawing.Point(12, 173);
            this.algoBox.Name = "algoBox";
            this.algoBox.Size = new System.Drawing.Size(108, 25);
            this.algoBox.TabIndex = 5;
            this.algoBox.SelectedValueChanged += new System.EventHandler(this.algoBox_SelectedValueChanged);
            // 
            // fileInput
            // 
            this.fileInput.AllowDrop = true;
            this.fileInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.fileInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fileInput.Location = new System.Drawing.Point(12, 106);
            this.fileInput.Name = "fileInput";
            this.fileInput.ReadOnly = true;
            this.fileInput.Size = new System.Drawing.Size(442, 25);
            this.fileInput.TabIndex = 4;
            this.fileInput.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // openDlg
            // 
            this.openDlg.Title = "Open file";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.homeBtn);
            this.panel2.Controls.Add(this.settingsBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 64);
            this.panel2.TabIndex = 5;
            // 
            // homeBtn
            // 
            this.homeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeBtn.BackgroundImage")));
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.homeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Location = new System.Drawing.Point(0, 0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.homeBtn.Size = new System.Drawing.Size(158, 64);
            this.homeBtn.TabIndex = 14;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.settingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.settingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.Location = new System.Drawing.Point(402, 0);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.settingsBtn.Size = new System.Drawing.Size(64, 64);
            this.settingsBtn.TabIndex = 11;
            this.tips.SetToolTip(this.settingsBtn, "Setting\'s");
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // restoreBtn
            // 
            this.restoreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreBtn.BackColor = System.Drawing.Color.Transparent;
            this.restoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restoreBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.restoreBtn.FlatAppearance.BorderSize = 0;
            this.restoreBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.restoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.restoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restoreBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.restoreBtn.Location = new System.Drawing.Point(293, 70);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(117, 30);
            this.restoreBtn.TabIndex = 13;
            this.restoreBtn.Text = "Restore session";
            this.restoreBtn.UseVisualStyleBackColor = false;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // compareBtn
            // 
            this.compareBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compareBtn.BackColor = System.Drawing.Color.Transparent;
            this.compareBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compareBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.compareBtn.FlatAppearance.BorderSize = 0;
            this.compareBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.compareBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.compareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compareBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.compareBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.compareBtn.Location = new System.Drawing.Point(340, 67);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(99, 34);
            this.compareBtn.TabIndex = 43;
            this.compareBtn.Text = "Compare";
            this.tips.SetToolTip(this.compareBtn, "Open file...");
            this.compareBtn.UseVisualStyleBackColor = false;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // pasteBtn
            // 
            this.pasteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pasteBtn.BackColor = System.Drawing.Color.Transparent;
            this.pasteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pasteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pasteBtn.FlatAppearance.BorderSize = 0;
            this.pasteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pasteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pasteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pasteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pasteBtn.Image = ((System.Drawing.Image)(resources.GetObject("pasteBtn.Image")));
            this.pasteBtn.Location = new System.Drawing.Point(404, 0);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(38, 30);
            this.pasteBtn.TabIndex = 45;
            this.tips.SetToolTip(this.pasteBtn, "Paste hash");
            this.pasteBtn.UseVisualStyleBackColor = false;
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label3.Size = new System.Drawing.Size(262, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "File path";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveDlg
            // 
            this.saveDlg.DefaultExt = "SHA 1";
            this.saveDlg.Title = "Save hash";
            // 
            // hashInput
            // 
            this.hashInput.AllowDrop = true;
            this.hashInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hashInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.hashInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hashInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hashInput.Location = new System.Drawing.Point(126, 173);
            this.hashInput.Name = "hashInput";
            this.hashInput.ReadOnly = true;
            this.hashInput.Size = new System.Drawing.Size(328, 25);
            this.hashInput.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(126, 134);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label1.Size = new System.Drawing.Size(240, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hash";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label2.Size = new System.Drawing.Size(108, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "Algorithm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // compareCheck
            // 
            this.compareCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compareCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.compareCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compareCheck.FlatAppearance.BorderSize = 0;
            this.compareCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.compareCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.compareCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.compareCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compareCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.compareCheck.Location = new System.Drawing.Point(12, 204);
            this.compareCheck.Name = "compareCheck";
            this.compareCheck.Size = new System.Drawing.Size(127, 36);
            this.compareCheck.TabIndex = 30;
            this.compareCheck.Text = "Compare mode";
            this.compareCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.compareCheck.UseVisualStyleBackColor = true;
            this.compareCheck.CheckedChanged += new System.EventHandler(this.compareCheck_CheckedChanged);
            // 
            // showWindow
            // 
            this.showWindow.Name = "showWindow";
            this.showWindow.Size = new System.Drawing.Size(160, 22);
            this.showWindow.Text = "Show window";
            // 
            // hideWindow
            // 
            this.hideWindow.Name = "hideWindow";
            this.hideWindow.Size = new System.Drawing.Size(160, 22);
            this.hideWindow.Text = "Hide window";
            this.hideWindow.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // verifyChecksum
            // 
            this.verifyChecksum.Name = "verifyChecksum";
            this.verifyChecksum.Size = new System.Drawing.Size(160, 22);
            this.verifyChecksum.Text = "Verify checksum";
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showWindow,
            this.hideWindow,
            this.toolStripSeparator1,
            this.verifyChecksum});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(161, 76);
            // 
            // base64Box
            // 
            this.base64Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.base64Box.Appearance = System.Windows.Forms.Appearance.Button;
            this.base64Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.base64Box.FlatAppearance.BorderSize = 0;
            this.base64Box.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.base64Box.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.base64Box.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.base64Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.base64Box.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.base64Box.Location = new System.Drawing.Point(145, 204);
            this.base64Box.Name = "base64Box";
            this.base64Box.Size = new System.Drawing.Size(125, 36);
            this.base64Box.TabIndex = 32;
            this.base64Box.Text = "Base64 encode";
            this.base64Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.base64Box.UseVisualStyleBackColor = true;
            this.base64Box.CheckedChanged += new System.EventHandler(this.base64Box_CheckedChanged);
            // 
            // hashCompareInput
            // 
            this.hashCompareInput.AllowDrop = true;
            this.hashCompareInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hashCompareInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.hashCompareInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hashCompareInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hashCompareInput.Location = new System.Drawing.Point(114, 36);
            this.hashCompareInput.Name = "hashCompareInput";
            this.hashCompareInput.Size = new System.Drawing.Size(328, 25);
            this.hashCompareInput.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(114, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label4.Size = new System.Drawing.Size(208, 33);
            this.label4.TabIndex = 39;
            this.label4.Text = "Hash/File to compare";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // algoCompareBox
            // 
            this.algoCompareBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.algoCompareBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.algoCompareBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.algoCompareBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algoCompareBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.algoCompareBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.algoCompareBox.FormattingEnabled = true;
            this.algoCompareBox.Items.AddRange(new object[] {
            "Auto detect",
            "MD 5",
            "SHA 1",
            "SHA 256",
            "SHA 384",
            "SHA 512"});
            this.algoCompareBox.Location = new System.Drawing.Point(0, 35);
            this.algoCompareBox.Name = "algoCompareBox";
            this.algoCompareBox.Size = new System.Drawing.Size(108, 25);
            this.algoCompareBox.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label5.Size = new System.Drawing.Size(108, 33);
            this.label5.TabIndex = 42;
            this.label5.Text = "Algorithm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resultLbl
            // 
            this.resultLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resultLbl.Location = new System.Drawing.Point(3, 64);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.resultLbl.Size = new System.Drawing.Size(331, 36);
            this.resultLbl.TabIndex = 44;
            this.resultLbl.Text = "Result";
            this.resultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelVerify
            // 
            this.panelVerify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVerify.Controls.Add(this.pasteBtn);
            this.panelVerify.Controls.Add(this.resultLbl);
            this.panelVerify.Controls.Add(this.compareBtn);
            this.panelVerify.Controls.Add(this.label5);
            this.panelVerify.Controls.Add(this.algoCompareBox);
            this.panelVerify.Controls.Add(this.label4);
            this.panelVerify.Controls.Add(this.hashCompareInput);
            this.panelVerify.Location = new System.Drawing.Point(12, 246);
            this.panelVerify.Name = "panelVerify";
            this.panelVerify.Size = new System.Drawing.Size(442, 104);
            this.panelVerify.TabIndex = 31;
            this.panelVerify.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(466, 362);
            this.Controls.Add(this.base64Box);
            this.Controls.Add(this.panelVerify);
            this.Controls.Add(this.compareCheck);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hashInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.copyHash);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.fileInput);
            this.Controls.Add(this.algoBox);
            this.Controls.Add(this.openBtn);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sumix";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel2.ResumeLayout(false);
            this.trayMenu.ResumeLayout(false);
            this.panelVerify.ResumeLayout(false);
            this.panelVerify.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button openBtn;
        private TextBox fileInput;
        private ComboBox algoBox;
        private OpenFileDialog openDlg;
        private System.Windows.Forms.Timer timer;
        private Button exportBtn;
        private Panel panel2;
        private Button copyHash;
        private NotifyIcon trayIcon;
        private Button settingsBtn;
        private ToolTip tips;
        private Label label3;
        private Button homeBtn;
        private SaveFileDialog saveDlg;
        private TextBox hashInput;
        private Label label1;
        private Label label2;
        private Button restoreBtn;
        private CheckBox compareCheck;
        private ToolStripMenuItem showWindow;
        private ToolStripMenuItem hideWindow;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem verifyChecksum;
        private ContextMenuStrip trayMenu;
        private CheckBox base64Box;
        private TextBox hashCompareInput;
        private Label label4;
        private ComboBox algoCompareBox;
        private Label label5;
        private Button compareBtn;
        private Label resultLbl;
        private Panel panelVerify;
        private Button pasteBtn;
    }
}