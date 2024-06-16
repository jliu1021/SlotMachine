using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class frmSlot : Form
    {
        //This form level variable allows for randomizon of stops
        Random myrndStop = new Random();
        //This is where money is stored
        decimal mydecMoney = 1000;
        decimal mydecWinnings = 0;
        decimal mydecBet = 20;
        public frmSlot()
        {
            InitializeComponent();
        }
        void Money()
        {
            if (mydecMoney <=0 )
            {
                MessageBox.Show("You have lost all your money."); //shows a message when you lose all your money and reset game
                ResetTheGame();                                                                                         
            }
            if (mydecBet > mydecMoney)
            {
                mydecBet = mydecMoney; //can't bet more than what you have
            }
            btnBet50.Enabled = mydecMoney >= 50; //enables the bet $50 button if you have more than $50, if less than $50, it disables the button
            btnBet20.Enabled = mydecMoney >= 20; //enables the bet $20 button if you have more than $20, if less than $20, it disables the button

            lblBalance.Text = mydecMoney.ToString("C"); //turns the numbers into currency
            lblBet.Text = mydecBet.ToString("C");
            lblWinnings.Text = mydecWinnings.ToString("C");
        }
        private void tmrWheel1_Tick(object sender, EventArgs e)
        {
            //This will change the picture on the first wheels
            //it will then randomly stop the timer on a picture
            PictureWheel(lblWheel1, pbxWheel1);
            tmrWheel1.Enabled = !StopWheel();
        }
        void PictureWheel(Label lbl, PictureBox PicBox)
        {
            //This will set the next picture for a given wheel
            int intCounter = int.Parse(lbl.Text);
            intCounter++;
            if (intCounter == 8)
            {
                intCounter = 1;
            }
            lbl.Text = intCounter.ToString();
            PictureBox pbx = (PictureBox)this.Controls["pbx" + intCounter.ToString()];
            PicBox.Image = pbx.Image;
        }
        bool StopWheel()
        {
            int intStopNumber = myrndStop.Next(10);
            if (intStopNumber == 6)
            {
                return true;
            }
            return false;
        }
        private void btnHandle_Click(object sender, EventArgs e)
        {
            //this is the same as mydecMoney = mydecMoney - mydecBet;
            mydecMoney -= mydecBet;
            
            //This will stop any winning lights
            tmrWinWheel.Enabled = false;
            pbxWinWheel1.Visible = false;
            pbxWinWheel2.Visible = false;
            pbxWinWheel3.Visible = false;

            tmrWheel1.Enabled = true;
            tmrWheel2.Enabled = true;
            tmrWheel3.Enabled = true;

            // Disables all buttons while game is in progess
            btnBet20.Enabled = false;
            btnBet50.Enabled = false;
            btnBetDouble.Enabled = false;
            btnHandle.Enabled = false;
            btnReset.Enabled = false;
        }
        private void tmrWheel2_Tick(object sender, EventArgs e)
        {
            PictureWheel(lblWheel2, pbxWheel2);
            if (!tmrWheel1.Enabled)
            {
                tmrWheel2.Enabled = !StopWheel();
            }
        }
        private void tmrWheel3_Tick(object sender, EventArgs e)
        {
            PictureWheel(lblWheel3, pbxWheel3);
            if (!tmrWheel2.Enabled)
            {
                tmrWheel3.Enabled = !StopWheel();
                //Checking for wins
                if (!tmrWheel3.Enabled)
                {
                    WinLose();
                }
            }
        }
        void WinLose()
        {
            mydecWinnings = 0;
            //This will check if the game is won and set up the 
            //winning lights
            pbxWinWheel1.Visible = false;
            pbxWinWheel2.Visible = false;
            pbxWinWheel3.Visible = false;
            if (lblWheel1.Text == lblWheel2.Text && lblWheel2.Text == lblWheel3.Text)
            {
                //Winner winner chicken dinner
                pbxWinWheel1.Visible = true;
                pbxWinWheel2.Visible = true;
                pbxWinWheel3.Visible = true;
                mydecWinnings = mydecBet * 10;
            }
            else if (lblWheel1.Text == lblWheel2.Text)
            {
                //kinda a winner
                pbxWinWheel1.Visible = true;
                pbxWinWheel2.Visible = true;
                mydecWinnings = mydecBet * 2;
            }
            else if (lblWheel1.Text == lblWheel3.Text)
            {
                //kinda a winner
                pbxWinWheel1.Visible = true;
                pbxWinWheel3.Visible = true;
                mydecWinnings = mydecBet * 2;
            }
            else if (lblWheel2.Text == lblWheel3.Text)
            {
                //kinda a winner
                pbxWinWheel2.Visible = true;
                pbxWinWheel3.Visible = true;
                mydecWinnings = mydecBet * 2;
            }
            else
            {
                //LOOSER!
            }
            // Re-enables the buttons after game finishes
            btnBetDouble.Enabled = true;
            btnHandle.Enabled = true;
            btnReset.Enabled = true;
            tmrWinWheel.Enabled = true;
            mydecMoney += mydecWinnings;
            Money();
        }
        private void tmrWinWheel_Tick(object sender, EventArgs e)
        {
            if (pbxWinWheel1.BackColor == Color.YellowGreen)
            {
                pbxWinWheel1.BackColor = Color.Salmon;
            }
            else if (pbxWinWheel1.BackColor == Color.Salmon)
            {
                pbxWinWheel1.BackColor = Color.Orchid;
            }
            else
            {
                pbxWinWheel1.BackColor = Color.YellowGreen;
            }
            pbxWinWheel2.BackColor = pbxWinWheel1.BackColor;
            pbxWinWheel3.BackColor = pbxWinWheel1.BackColor;
        }
        private void frmSlot_Load(object sender, EventArgs e)
        {
            ResetTheGame();//This will dispay the money on the screen
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTheGame(); 
        }
        void ResetTheGame() //resets the game
        {
            mydecMoney = 1000;
            mydecBet= 20;
            mydecWinnings = 0;
            Money();
        }
        private void btnBet50_Click(object sender, EventArgs e) //bets $50
        {
            mydecBet = 50;
            Money();
        }
        private void btnBet20_Click(object sender, EventArgs e) //bets $20
        {
            mydecBet = 20;
            Money();
        }
        private void btnBetDouble_Click(object sender, EventArgs e) //doubles your bet
        {
            mydecBet *= 2;
            Money();
        }
    }
}
