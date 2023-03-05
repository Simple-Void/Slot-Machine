namespace Slot_Machine
{
    partial class FinalEarnings
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
            this.lblFinalEarnings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFinalEarnings
            // 
            this.lblFinalEarnings.Font = new System.Drawing.Font("Bahnschrift Condensed", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinalEarnings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFinalEarnings.Location = new System.Drawing.Point(-2, -2);
            this.lblFinalEarnings.Name = "lblFinalEarnings";
            this.lblFinalEarnings.Size = new System.Drawing.Size(457, 160);
            this.lblFinalEarnings.TabIndex = 1;
            this.lblFinalEarnings.Text = "1000";
            this.lblFinalEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinalEarnings.Click += new System.EventHandler(this.lblFinalEarnings_Click);
            // 
            // FinalEarnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(453, 156);
            this.Controls.Add(this.lblFinalEarnings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FinalEarnings";
            this.Text = "FinalEarnings";
            this.Load += new System.EventHandler(this.FinalEarnings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblFinalEarnings;
    }
}