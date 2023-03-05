namespace Slot_Machine
{
    partial class Slots
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
            this.pcbxSlot1 = new System.Windows.Forms.PictureBox();
            this.pcbxSlot2 = new System.Windows.Forms.PictureBox();
            this.pcbxSlot3 = new System.Windows.Forms.PictureBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnNudge = new System.Windows.Forms.Button();
            this.lblDebug = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudBet = new System.Windows.Forms.NumericUpDown();
            this.btnHowTo = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.nudBalance = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSlot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSlot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxSlot1
            // 
            this.pcbxSlot1.Location = new System.Drawing.Point(12, 12);
            this.pcbxSlot1.Name = "pcbxSlot1";
            this.pcbxSlot1.Size = new System.Drawing.Size(150, 300);
            this.pcbxSlot1.TabIndex = 1;
            this.pcbxSlot1.TabStop = false;
            // 
            // pcbxSlot2
            // 
            this.pcbxSlot2.Location = new System.Drawing.Point(168, 12);
            this.pcbxSlot2.Name = "pcbxSlot2";
            this.pcbxSlot2.Size = new System.Drawing.Size(150, 300);
            this.pcbxSlot2.TabIndex = 2;
            this.pcbxSlot2.TabStop = false;
            // 
            // pcbxSlot3
            // 
            this.pcbxSlot3.Location = new System.Drawing.Point(324, 12);
            this.pcbxSlot3.Name = "pcbxSlot3";
            this.pcbxSlot3.Size = new System.Drawing.Size(150, 300);
            this.pcbxSlot3.TabIndex = 3;
            this.pcbxSlot3.TabStop = false;
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(7)))), ((int)(((byte)(13)))));
            this.btnSpin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpin.Font = new System.Drawing.Font("Bahnschrift Condensed", 70F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSpin.Location = new System.Drawing.Point(12, 318);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(462, 150);
            this.btnSpin.TabIndex = 0;
            this.btnSpin.Text = "SPIN";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnNudge
            // 
            this.btnNudge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(147)))), ((int)(((byte)(0)))));
            this.btnNudge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNudge.Font = new System.Drawing.Font("Bahnschrift Condensed", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNudge.Location = new System.Drawing.Point(479, 318);
            this.btnNudge.Name = "btnNudge";
            this.btnNudge.Size = new System.Drawing.Size(157, 150);
            this.btnNudge.TabIndex = 1;
            this.btnNudge.Text = "NUDGE";
            this.btnNudge.UseVisualStyleBackColor = false;
            this.btnNudge.Click += new System.EventHandler(this.btnNudge_Click);
            // 
            // lblDebug
            // 
            this.lblDebug.Location = new System.Drawing.Point(168, 12);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(150, 85);
            this.lblDebug.TabIndex = 6;
            this.lblDebug.Text = "debug panel";
            this.lblDebug.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(480, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "YOUR BET:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudBet
            // 
            this.nudBet.Font = new System.Drawing.Font("Bahnschrift Condensed", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudBet.Location = new System.Drawing.Point(480, 57);
            this.nudBet.Name = "nudBet";
            this.nudBet.Size = new System.Drawing.Size(157, 108);
            this.nudBet.TabIndex = 3;
            this.nudBet.ThousandsSeparator = true;
            // 
            // btnHowTo
            // 
            this.btnHowTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHowTo.Location = new System.Drawing.Point(606, 282);
            this.btnHowTo.Name = "btnHowTo";
            this.btnHowTo.Size = new System.Drawing.Size(30, 30);
            this.btnHowTo.TabIndex = 9;
            this.btnHowTo.Text = "?";
            this.btnHowTo.UseVisualStyleBackColor = true;
            this.btnHowTo.Click += new System.EventHandler(this.btnHowTo_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(480, 282);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(120, 29);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "new player";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // nudBalance
            // 
            this.nudBalance.Enabled = false;
            this.nudBalance.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nudBalance.Location = new System.Drawing.Point(480, 214);
            this.nudBalance.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudBalance.Minimum = new decimal(new int[] {
            -727379968,
            232,
            0,
            -2147483648});
            this.nudBalance.Name = "nudBalance";
            this.nudBalance.Size = new System.Drawing.Size(157, 38);
            this.nudBalance.TabIndex = 11;
            this.nudBalance.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(479, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 43);
            this.label2.TabIndex = 12;
            this.label2.Text = "GAME BALANCE:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(648, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudBalance);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnHowTo);
            this.Controls.Add(this.nudBet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.btnNudge);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.pcbxSlot3);
            this.Controls.Add(this.pcbxSlot2);
            this.Controls.Add(this.pcbxSlot1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Slots";
            this.Text = "Slots";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSlot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSlot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pcbxSlot1;
        private PictureBox pcbxSlot2;
        private PictureBox pcbxSlot3;
        private Button btnSpin;
        private Button btnNudge;
        private Label lblDebug;
        private Label label1;
        private NumericUpDown nudBet;
        private Button btnHowTo;
        private Button btnNew;
        private NumericUpDown nudBalance;
        private Label label2;
    }
}