namespace Slot_Machine
{
    partial class Earnings
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
            this.lblEarnings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEarnings
            // 
            this.lblEarnings.Font = new System.Drawing.Font("Bahnschrift Condensed", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEarnings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEarnings.Location = new System.Drawing.Point(-2, -2);
            this.lblEarnings.Name = "lblEarnings";
            this.lblEarnings.Size = new System.Drawing.Size(457, 160);
            this.lblEarnings.TabIndex = 0;
            this.lblEarnings.Text = "1000";
            this.lblEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEarnings.Click += new System.EventHandler(this.lblEarnings_Click);
            // 
            // Earnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(453, 156);
            this.Controls.Add(this.lblEarnings);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Earnings";
            this.Text = "Collect Winnings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblEarnings;
    }
}