namespace Slot_Machine
{
    //icon values

    //TRIPLEBAR     =   1
    //7s            =   2
    //diamonds      =   3
    //clovers       =   4
    //banknotes     =   5
    //coins         =   6
    //cherries      =   7
    //grapes        =   8
    //melons        =   9

    public partial class Slots : Form
    {
        //set up random rotations as public array
        public int[] randomVars = new int[100];
        //set up array of slot values
        public int[] oldSlots = new int[3];
        public int[] currentSlots = new int[3];
        public int[] expectedSlots = new int[3];
        //set up earnings variable
        public int earnings = 0;

        public Slots()
        {
            //run essential startup elements
            InitializeComponent();
            storeRandomVars();
            currentSlots[0] = 1;
            currentSlots[1] = 1;
            currentSlots[2] = 1;
            showSlots();
            lblDebug.Visible = false;
            btnNudge.Enabled = false;

            //constant values
            nudBet.Minimum = 1;
            nudBet.Maximum = 100;
        }

        public void storeRandomVars()
        {
            //truly random integer set
            //minimum rotation amount for effect
            //maximum rotation to avoid excess time taken
            //generated using random.org
            randomVars[00] = 9;
            randomVars[01] = 1;
            randomVars[02] = 1;
            randomVars[03] = 3;
            randomVars[04] = 6;
            randomVars[05] = 8;
            randomVars[06] = 8;
            randomVars[07] = 6;
            randomVars[08] = 2;
            randomVars[09] = 2;
            randomVars[10] = 4;
            randomVars[11] = 6;
            randomVars[12] = 8;
            randomVars[13] = 8;
            randomVars[14] = 4;
            randomVars[15] = 7;
            randomVars[16] = 4;
            randomVars[17] = 6;
            randomVars[18] = 9;
            randomVars[19] = 7;
            randomVars[20] = 5;
            randomVars[21] = 8;
            randomVars[22] = 2;
            randomVars[23] = 2;
            randomVars[24] = 8;
            randomVars[25] = 6;
            randomVars[26] = 9;
            randomVars[27] = 1;
            randomVars[28] = 4;
            randomVars[29] = 5;
            randomVars[30] = 5;
            randomVars[31] = 2;
            randomVars[32] = 6;
            randomVars[33] = 9;
            randomVars[34] = 3;
            randomVars[35] = 2;
            randomVars[36] = 2;
            randomVars[37] = 6;
            randomVars[38] = 2;
            randomVars[39] = 2;
            randomVars[40] = 3;
            randomVars[41] = 3;
            randomVars[42] = 8;
            randomVars[43] = 8;
            randomVars[44] = 5;
            randomVars[45] = 1;
            randomVars[46] = 6;
            randomVars[47] = 1;
            randomVars[48] = 1;
            randomVars[49] = 7;
            randomVars[50] = 8;
            randomVars[51] = 2;
            randomVars[52] = 8;
            randomVars[53] = 9;
            randomVars[54] = 3;
            randomVars[55] = 1;
            randomVars[56] = 1;
            randomVars[57] = 5;
            randomVars[58] = 4;
            randomVars[59] = 5;
            randomVars[60] = 6;
            randomVars[61] = 9;
            randomVars[62] = 2;
            randomVars[63] = 2;
            randomVars[64] = 6;
            randomVars[65] = 7;
            randomVars[66] = 5;
            randomVars[67] = 1;
            randomVars[68] = 6;
            randomVars[69] = 3;
            randomVars[70] = 2;
            randomVars[71] = 2;
            randomVars[72] = 3;
            randomVars[73] = 3;
            randomVars[74] = 8;
            randomVars[75] = 5;
            randomVars[76] = 9;
            randomVars[77] = 4;
            randomVars[78] = 8;
            randomVars[79] = 7;
            randomVars[80] = 5;
            randomVars[81] = 5;
            randomVars[82] = 3;
            randomVars[83] = 9;
            randomVars[84] = 7;
            randomVars[85] = 3;
            randomVars[86] = 9;
            randomVars[87] = 9;
            randomVars[88] = 9;
            randomVars[89] = 3;
            randomVars[90] = 5;
            randomVars[91] = 1;
            randomVars[92] = 2;
            randomVars[93] = 3;
            randomVars[94] = 8;
            randomVars[95] = 5;
            randomVars[96] = 5;
            randomVars[97] = 6;
            randomVars[98] = 4;
            randomVars[99] = 3;
        }

        private async void btnSpin_Click(object sender, EventArgs e)
        {
            if (btnSpin.Text == "SPIN")
            {
                //reset nudge
                btnNudge.Enabled = true;

                //set up type random
                Random randVal = new Random();

                //store current slot values in an array
                oldSlots = expectedSlots;

                //generate and store the three rotations
                for (int c = 0; c < 3; c++)
                {
                    expectedSlots[c] = randomVars[randVal.Next(0, 100)];
                }

                //debug info
                lblDebug.Text = ($"Reel1 = {expectedSlots[0]}, Reel2 = {expectedSlots[1]}, Reel3 = {expectedSlots[2]}");

                //spin slots
                animSlots();

                //update balance
                nudBalance.Value = nudBalance.Value - nudBet.Value;

                //only show option to claim if the earnings are above 0
                //determine the final prize
                earnings = findWinnings(Convert.ToInt32(nudBet.Value));
                if (earnings > 0)
                {
                    //set to collect button
                    btnSpin.Text = "COLLECT";
                }
            } else
            {
                //disable nudge
                btnNudge.Enabled = false;

                //determine the final prize
                earnings = findWinnings(Convert.ToInt32(nudBet.Value));

                //display the earnings figure
                Earnings newEarnings = new Earnings(earnings);
                newEarnings.ShowDialog();

                //update balance
                nudBalance.Value = nudBalance.Value + earnings;

                //set to spin button
                btnSpin.Text = "SPIN";
            }
        }

        private void btnNudge_Click(object sender, EventArgs e)
        {
            //disable nudge for this round
            btnNudge.Enabled = false;

            //set up type random
            Random randColumn = new Random();
            int col = randColumn.Next(0, 3);
            Random progressOrDegress = new Random();
                int randVal = progressOrDegress.Next(0, 3);
            bool progOrDeg = false;
            if (randVal == 0)
            {
                progOrDeg = false;
            } else
            {
                progOrDeg = true;
            }

            //check to progress or degress value in slot
            if (progOrDeg == false)
            {
                //progress
               expectedSlots[col]++;
            }
            else
            {
                //degress
                expectedSlots[col]--;
            }

            //ensure it rolls over correctly
            if (expectedSlots[col] == 0)
            {
                expectedSlots[col] = 9;
            }
            else if (expectedSlots[col] == 10)
            {
                expectedSlots[col] = 1;
            }

            //update icons
            currentSlots = expectedSlots;
            showSlots();

            //debug info
            lblDebug.Text = ($"Nudged; Reel1 = {expectedSlots[0]}, Reel2 = {expectedSlots[1]}, Reel3 = {expectedSlots[2]}");

            //only show option to claim if the earnings are above 0
            //determine the final prize
            earnings = findWinnings(Convert.ToInt32(nudBet.Value));
            if (earnings > 0)
            {
                //set to collect button
                btnSpin.Text = "COLLECT";
            } else
            {
                //as nudge can LOSE the edge it can roll back to spin
                //set to spin button
                btnSpin.Text = "SPIN";
            }
        }

        private int findWinnings(int _bet)
        {
            int earnings = 0;
            //check the matches, huuuuge if statement
            if (expectedSlots[0] == expectedSlots[1] && expectedSlots[0] == expectedSlots[2]) //triple match
            {
                //check what the value of the triple match is
                switch (expectedSlots[0])
                {
                    case 1:
                        //jackpot
                        //triple match with TRIPLEBAR
                        earnings = _bet * 10;
                        break;
                    case 2:
                        //triple match with 7s
                        earnings = _bet * 9;
                        break;
                    case 3:
                        //triple match with diamonds
                        earnings = _bet * 7;
                        break;
                    case 4:
                        //triple match with clovers
                        earnings = _bet * 5;
                        break;
                    case 5:
                        //triple match with banknotes
                        earnings = _bet * 4;
                        break;
                    case 6:
                        //triple match with coins
                        earnings = Convert.ToInt32(Math.Ceiling(_bet * 2.5));
                        break;
                    case 7:
                        //triple match with cherries
                        earnings = _bet * 2;
                        break;
                    case 8:
                        //triple match with grapes
                        earnings = Convert.ToInt32(Math.Ceiling(_bet * 1.5));
                        break;
                    case 9:
                        //triple match with melons
                        earnings = _bet * 1;
                        break;
                }
            } else if (expectedSlots[0] == expectedSlots[1] || expectedSlots[1] == expectedSlots[2]) //adjacent double match
            {
                if (expectedSlots[1] == 1)
                {
                    //adjacent match with TRIPLEBAR
                    earnings = Convert.ToInt32(Math.Ceiling(_bet * 0.5));
                } else
                {
                    //adjacent match non-TRIPLEBAR
                    earnings = Convert.ToInt32(Math.Ceiling(_bet * 0.25));
                }
            }

            //return the earning value for win screen
            return earnings;
        }

        private void showSlots()
        {
            //store the images in the array
            Image[] slotimages = new Image[9];
            slotimages[0] = Image.FromFile("slotTRIPLEBAR.png");
            slotimages[1] = Image.FromFile("slot7.png");
            slotimages[2] = Image.FromFile("slotDiamond.png");
            slotimages[3] = Image.FromFile("slotClover.png");
            slotimages[4] = Image.FromFile("slotBanknote.png");
            slotimages[5] = Image.FromFile("slotCoin.png");
            slotimages[6] = Image.FromFile("slotCherry.png");
            slotimages[7] = Image.FromFile("slotGrapes.png");
            slotimages[8] = Image.FromFile("slotMelons.png");

            //display the slot icons corresponding to the generated number
            switch (currentSlots[0])
            {
                case 1:
                    pcbxSlot1.Image = slotimages[0];
                    break;
                case 2:
                    pcbxSlot1.Image = slotimages[1];
                    break;
                case 3:
                    pcbxSlot1.Image = slotimages[2];
                    break;
                case 4:
                    pcbxSlot1.Image = slotimages[3];
                    break;
                case 5:
                    pcbxSlot1.Image = slotimages[4];
                    break;
                case 6:
                    pcbxSlot1.Image = slotimages[5];
                    break;
                case 7:
                    pcbxSlot1.Image = slotimages[6];
                    break;
                case 8:
                    pcbxSlot1.Image = slotimages[7];
                    break;
                case 9:
                    pcbxSlot1.Image = slotimages[8];
                    break;
            }
            switch (currentSlots[1])
            {
                case 1:
                    pcbxSlot2.Image = slotimages[0];
                    break;
                case 2:
                    pcbxSlot2.Image = slotimages[1];
                    break;
                case 3:
                    pcbxSlot2.Image = slotimages[2];
                    break;
                case 4:
                    pcbxSlot2.Image = slotimages[3];
                    break;
                case 5:
                    pcbxSlot2.Image = slotimages[4];
                    break;
                case 6:
                    pcbxSlot2.Image = slotimages[5];
                    break;
                case 7:
                    pcbxSlot2.Image = slotimages[6];
                    break;
                case 8:
                    pcbxSlot2.Image = slotimages[7];
                    break;
                case 9:
                    pcbxSlot2.Image = slotimages[8];
                    break;
            }
            switch (currentSlots[2])
            {
                case 1:
                    pcbxSlot3.Image = slotimages[0];
                    break;
                case 2:
                    pcbxSlot3.Image = slotimages[1];
                    break;
                case 3:
                    pcbxSlot3.Image = slotimages[2];
                    break;
                case 4:
                    pcbxSlot3.Image = slotimages[3];
                    break;
                case 5:
                    pcbxSlot3.Image = slotimages[4];
                    break;
                case 6:
                    pcbxSlot3.Image = slotimages[5];
                    break;
                case 7:
                    pcbxSlot3.Image = slotimages[6];
                    break;
                case 8:
                    pcbxSlot3.Image = slotimages[7];
                    break;
                case 9:
                    pcbxSlot3.Image = slotimages[8];
                    break;
            }
        }

        private async void animSlots()
        {
            currentSlots = oldSlots;

            //triple rotate
            //this is just for effect
            for (int y = 0; y < 36; y++)
            {
                //loop 1st slot
                if (currentSlots[0] == 9)
                {
                    currentSlots[0] = 0;
                }

                //loop 2nd slot
                if (currentSlots[1] == 9)
                {
                    currentSlots[1] = 0;
                }

                //loop 3rd slot
                if (currentSlots[2] == 9)
                {
                    currentSlots[2] = 0;
                }

                //increment all slots
                currentSlots[0]++;
                currentSlots[1]++;
                currentSlots[2]++;

                await Task.Delay(2);
                showSlots();
            }
        }

        private void btnHowTo_Click(object sender, EventArgs e)
        {
            //display information on playing and scoring
            MessageBox.Show($"You can bet a minimum of {nudBet.Minimum} and a maximum of {nudBet.Maximum}" 
                + Environment.NewLine + "You place your bet by typing your number into the betting box, or using the arrows"
                + Environment.NewLine + "Click 'SPIN' to spin the slots"
                + Environment.NewLine + "After you have spun the slots you can choose to collect your earnings using 'COLLECT'"
                + Environment.NewLine + "However, you can choose to nudge the slots using 'NUDGE' instead of collecting"
                + Environment.NewLine + "Nudging the slots will move a random slot by 1-2 positions, this will influence the amount you can collect"
                + Environment.NewLine + "You can only nudge the slots once per spin, and all nudges are final"
                + Environment.NewLine + "Pressing 'COLLECT' will display your winnings for that round, please wait until you are done playing to settle your balance" 
                + Environment.NewLine + "When you are done playing, please click 'new player'"
                + Environment.NewLine + "this will display your final balance to be settled and reset the game for the next player"
                + Environment.NewLine + "Please ask the person running the slots for your winnings"
                + Environment.NewLine + Environment.NewLine + "Matching three BAR symbols is the jackpot"
                + Environment.NewLine + "Matching any three of another symbol will increase your winnings based on the symbol rank proportionally to your bet"
                + Environment.NewLine + "Matching two BAR symbols in adjacent slots will return some of your bet"
                + Environment.NewLine + "Matching any other two symbols in adjacent slots will return some of your bet, but less than two BAR symbols"
                + Environment.NewLine + "Any other symbol combination will not give any winnings"
                + Environment.NewLine + "The winnings window can be closed by clicking anywhere on it"
                , "How To Play");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //display the final balance
            FinalEarnings finalBalance = new FinalEarnings(Convert.ToInt32(nudBalance.Value));
            finalBalance.Show();

            //reset balance
            nudBalance.Value = 0;
            nudBet.Value = 1;
        }
    }
}