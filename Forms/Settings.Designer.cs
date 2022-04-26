namespace Sumix
{
    partial class Settings
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.tips = new System.Windows.Forms.ToolTip(this.components);
            this.restoreBox = new System.Windows.Forms.CheckBox();
            this.upperCheck = new System.Windows.Forms.CheckBox();
            this.trayCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.algoDefaultBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(175, 155);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(145, 36);
            this.saveBtn.TabIndex = 17;
            this.saveBtn.Text = "Save changes";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // restoreBtn
            // 
            this.restoreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreBtn.BackColor = System.Drawing.Color.Transparent;
            this.restoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restoreBtn.FlatAppearance.BorderSize = 0;
            this.restoreBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.restoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.restoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreBtn.Location = new System.Drawing.Point(12, 155);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(145, 36);
            this.restoreBtn.TabIndex = 22;
            this.restoreBtn.Text = "Restore default";
            this.restoreBtn.UseVisualStyleBackColor = false;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // restoreBox
            // 
            this.restoreBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.restoreBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restoreBox.FlatAppearance.BorderSize = 0;
            this.restoreBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.restoreBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.restoreBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.restoreBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreBox.Location = new System.Drawing.Point(12, 12);
            this.restoreBox.Name = "restoreBox";
            this.restoreBox.Size = new System.Drawing.Size(308, 32);
            this.restoreBox.TabIndex = 29;
            this.restoreBox.Text = "Restore last session";
            this.restoreBox.UseVisualStyleBackColor = true;
            // 
            // upperCheck
            // 
            this.upperCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upperCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.upperCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upperCheck.FlatAppearance.BorderSize = 0;
            this.upperCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.upperCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.upperCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.upperCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upperCheck.Location = new System.Drawing.Point(12, 50);
            this.upperCheck.Name = "upperCheck";
            this.upperCheck.Size = new System.Drawing.Size(308, 32);
            this.upperCheck.TabIndex = 28;
            this.upperCheck.Text = "Upper case hash";
            this.upperCheck.UseVisualStyleBackColor = true;
            // 
            // trayCheck
            // 
            this.trayCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trayCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.trayCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trayCheck.FlatAppearance.BorderSize = 0;
            this.trayCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.trayCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.trayCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.trayCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trayCheck.Location = new System.Drawing.Point(12, 88);
            this.trayCheck.Name = "trayCheck";
            this.trayCheck.Size = new System.Drawing.Size(308, 32);
            this.trayCheck.TabIndex = 24;
            this.trayCheck.Text = "Minimize window to tray icon";
            this.trayCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Default hash to compare";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // algoDefaultBox
            // 
            this.algoDefaultBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.algoDefaultBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.algoDefaultBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.algoDefaultBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algoDefaultBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.algoDefaultBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.algoDefaultBox.FormattingEnabled = true;
            this.algoDefaultBox.Items.AddRange(new object[] {
            "MD 5",
            "SHA 1",
            "SHA 256",
            "SHA 384",
            "SHA 512"});
            this.algoDefaultBox.Location = new System.Drawing.Point(186, 123);
            this.algoDefaultBox.Name = "algoDefaultBox";
            this.algoDefaultBox.Size = new System.Drawing.Size(134, 25);
            this.algoDefaultBox.TabIndex = 42;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(332, 203);
            this.Controls.Add(this.algoDefaultBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restoreBox);
            this.Controls.Add(this.upperCheck);
            this.Controls.Add(this.trayCheck);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.saveBtn);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button saveBtn;
        private Button restoreBtn;
        private ToolTip tips;
        private CheckBox restoreBox;
        private CheckBox upperCheck;
        private CheckBox trayCheck;
        private Label label1;
        private ComboBox algoDefaultBox;
    }
}