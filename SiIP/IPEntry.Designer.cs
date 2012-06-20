namespace SiIP
{
    partial class IPEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDot3 = new System.Windows.Forms.Label();
            this.lblDot2 = new System.Windows.Forms.Label();
            this.lblDot1 = new System.Windows.Forms.Label();
            this.tbIP4 = new System.Windows.Forms.TextBox();
            this.tbIP3 = new System.Windows.Forms.TextBox();
            this.tbIP2 = new System.Windows.Forms.TextBox();
            this.tbIP1 = new System.Windows.Forms.TextBox();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDot3
            // 
            this.lblDot3.AutoSize = true;
            this.lblDot3.BackColor = System.Drawing.SystemColors.Window;
            this.lblDot3.Location = new System.Drawing.Point(98, 4);
            this.lblDot3.Name = "lblDot3";
            this.lblDot3.Size = new System.Drawing.Size(10, 13);
            this.lblDot3.TabIndex = 24;
            this.lblDot3.Text = ".";
            // 
            // lblDot2
            // 
            this.lblDot2.AutoSize = true;
            this.lblDot2.BackColor = System.Drawing.SystemColors.Window;
            this.lblDot2.Location = new System.Drawing.Point(63, 4);
            this.lblDot2.Name = "lblDot2";
            this.lblDot2.Size = new System.Drawing.Size(10, 13);
            this.lblDot2.TabIndex = 23;
            this.lblDot2.Text = ".";
            // 
            // lblDot1
            // 
            this.lblDot1.AutoSize = true;
            this.lblDot1.BackColor = System.Drawing.SystemColors.Window;
            this.lblDot1.Location = new System.Drawing.Point(30, 4);
            this.lblDot1.Name = "lblDot1";
            this.lblDot1.Size = new System.Drawing.Size(10, 13);
            this.lblDot1.TabIndex = 22;
            this.lblDot1.Text = ".";
            // 
            // tbIP4
            // 
            this.tbIP4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIP4.Location = new System.Drawing.Point(104, 4);
            this.tbIP4.MaxLength = 3;
            this.tbIP4.Name = "tbIP4";
            this.tbIP4.Size = new System.Drawing.Size(28, 13);
            this.tbIP4.TabIndex = 20;
            this.tbIP4.Text = "256";
            this.tbIP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIP3
            // 
            this.tbIP3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIP3.Location = new System.Drawing.Point(71, 4);
            this.tbIP3.MaxLength = 3;
            this.tbIP3.Name = "tbIP3";
            this.tbIP3.Size = new System.Drawing.Size(28, 13);
            this.tbIP3.TabIndex = 19;
            this.tbIP3.Text = "256";
            this.tbIP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIP2
            // 
            this.tbIP2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIP2.Location = new System.Drawing.Point(36, 4);
            this.tbIP2.MaxLength = 3;
            this.tbIP2.Name = "tbIP2";
            this.tbIP2.Size = new System.Drawing.Size(28, 13);
            this.tbIP2.TabIndex = 18;
            this.tbIP2.Text = "256";
            this.tbIP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIP1
            // 
            this.tbIP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIP1.Location = new System.Drawing.Point(4, 4);
            this.tbIP1.MaxLength = 3;
            this.tbIP1.Name = "tbIP1";
            this.tbIP1.Size = new System.Drawing.Size(28, 13);
            this.tbIP1.TabIndex = 17;
            this.tbIP1.Text = "256";
            this.tbIP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMain
            // 
            this.tbMain.BackColor = System.Drawing.SystemColors.Window;
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.ReadOnly = true;
            this.tbMain.Size = new System.Drawing.Size(136, 20);
            this.tbMain.TabIndex = 21;
            this.tbMain.TabStop = false;
            // 
            // IPEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDot3);
            this.Controls.Add(this.lblDot2);
            this.Controls.Add(this.lblDot1);
            this.Controls.Add(this.tbIP4);
            this.Controls.Add(this.tbIP3);
            this.Controls.Add(this.tbIP2);
            this.Controls.Add(this.tbIP1);
            this.Controls.Add(this.tbMain);
            this.MaximumSize = new System.Drawing.Size(136, 20);
            this.MinimumSize = new System.Drawing.Size(136, 20);
            this.Name = "IPEntry";
            this.Size = new System.Drawing.Size(136, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDot3;
        private System.Windows.Forms.Label lblDot2;
        private System.Windows.Forms.Label lblDot1;
        private System.Windows.Forms.TextBox tbIP4;
        private System.Windows.Forms.TextBox tbIP3;
        private System.Windows.Forms.TextBox tbIP2;
        private System.Windows.Forms.TextBox tbIP1;
        private System.Windows.Forms.TextBox tbMain;
    }
}
