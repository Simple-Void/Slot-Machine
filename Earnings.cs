using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_Machine
{
    public partial class Earnings : Form
    {
        public int earnings;
        public Earnings(int _earnings)
        {
            InitializeComponent();
            earnings = _earnings;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            int currentDisp = 0;

            //scroll up from 0 to give a real reward feeling
            while (currentDisp < earnings+1)
            {
                lblEarnings.Text = currentDisp.ToString();
                await Task.Delay(1);

                //display title and image appropriate to prize level
                //higher values have a more excited title
                //and confetti
                if (currentDisp > 800)
                {
                    this.Text = "OUTSTANDING!!";
                    lblEarnings.Image = Image.FromFile("confetti.png");
                }
                else if (currentDisp > 500)
                {
                    this.Text = "INCREDIBLE";
                    lblEarnings.Image = Image.FromFile("confetti.png");
                }
                else if (currentDisp > 0)
                {
                    this.Text = "Impressive";
                    lblEarnings.Image = null;
                }
                else if (currentDisp == 0)
                {
                    if (earnings == 0)
                    {
                        this.Text = "No Prize";
                        lblEarnings.Image = Image.FromFile("empty.png");
                    }
                }
                currentDisp++;
            }

            //checks for jackpot after the scroll as I was encountering issues
            //making it display while also scrolling
            if (earnings == 1000)
            {
                this.Text = "!!!JACKPOT!!!";
                lblEarnings.Image = Image.FromFile("falling.png");
            }
        }

        private void lblEarnings_Click(object sender, EventArgs e)
        {
            //close when clicked for ease of use
            this.Close();
        }
    }
}
