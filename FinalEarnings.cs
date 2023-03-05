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
    public partial class FinalEarnings : Form
    {
        int finalBalance;
        public FinalEarnings(int _finalBalance)
        {
            InitializeComponent();
            finalBalance = _finalBalance;
        }

        private void lblFinalEarnings_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private async void FinalEarnings_Load(object sender, EventArgs e)
        {
            int currentDisp = 0;

            if (finalBalance > 0)
            {
                //scroll up from 0 to give a real reward feeling
                while (currentDisp < finalBalance + 1)
                {
                    lblFinalEarnings.Text = currentDisp.ToString();
                    await Task.Delay(1);

                    //display title and image appropriate to prize level
                    //higher values have a more excited title
                    //and confetti
                    if (currentDisp > 800)
                    {
                        this.Text = "!!!MASSIVE WINNINGS!!!";
                        lblFinalEarnings.Image = Image.FromFile("falling.png");
                    } else if (currentDisp > 500)
                    {
                        this.Text = "OUTSTANDING WINNINGS!!";
                        lblFinalEarnings.Image = Image.FromFile("confetti.png");
                    }
                    else if (currentDisp > 300)
                    {
                        this.Text = "INCREDIBLE WINNINGS";
                        lblFinalEarnings.Image = Image.FromFile("confetti.png");
                    }
                    else if (currentDisp > 0)
                    {
                        this.Text = "Impressive Winnings!";
                        lblFinalEarnings.Image = null;
                    }
                    else if (currentDisp == 0)
                    {
                        this.Text = "Break Even!";
                    }
                    currentDisp++;
                }
            } else
            {
                lblFinalEarnings.Image = Image.FromFile("empty.png");

                //scroll down from 0 to give a real loss feeling
                while (currentDisp > finalBalance - 1)
                {
                    lblFinalEarnings.Text = currentDisp.ToString();
                    await Task.Delay(1);

                    //display title and image appropriate to prize level
                    //higher values have a more excited title
                    //and confetti
                    if (currentDisp < -800)
                    {
                        this.Text = "HUGE LOSS";
                    }
                    else if (currentDisp < -500)
                    {
                        this.Text = "Heartbreaking Loss";
                    }
                    else if (currentDisp < -300)
                    {
                        this.Text = "Painful Loss";
                    }
                    else
                    {
                        this.Text = "Loss";
                    }
                    currentDisp--;
                }
            }
        }
    }
}
