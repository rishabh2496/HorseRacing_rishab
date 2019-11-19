using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacing_Rishab
{
    public partial class Form1 : Form
    {

        wholeProcess instace_process = new wholeProcess();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //calling the method of the check and pass the value of the argument to check and return accurate value
            if (instace_process.check(cbPlayer.SelectedItem.ToString(), cbHorse.SelectedItem.ToString(), Convert.ToInt32(betAmount.Value)) == 0) {
                //calling the method to display the bet setting like which player chooose which horse and how much amount
                instace_process.display(cbPlayer,cbHorse.SelectedItem.ToString(),Convert.ToInt32(betAmount.Value),cbPlayer.SelectedIndex);
                // visible the button2 to start the race 
                button2.Visible = true;    
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // creating the insance object of the soundplayer class and calling the method of the play 
            System.Media.SoundPlayer obj = new System.Media.SoundPlayer(Properties.Resources.fire);
            obj.Play();

            //code the start the process this is also known as recursion 
            timer1.Start();

          

        }
        //the code to decalre the winner of the game 
        public void declareWinner(int HorseNo)
        {
            MessageBox.Show("Horse No " + HorseNo +" won the race ");
            instace_process.resetAccount(cbPlayer, HorseNo);

            horseNo1.Top = 52;
            HorseNo2.Top = 52;
            HorseNo3.Top = 52;
            HorseNo4.Top = 52;

            betAmount.Value = 0;
            button2.Visible = false;
            cbPlayer.Text = "";
            cbHorse.Text = "";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int Top = 0;
            //move the horse to run in the game 
            Top = instace_process.rank();
            horseNo1.Top += Top;

            Top = instace_process.rank();
            HorseNo2.Top += Top;

            Top = instace_process.rank();
            HorseNo3.Top += Top;

            Top = instace_process.rank();
            HorseNo4.Top += Top;

            if (horseNo1.Top > 330) {
                timer1.Stop();
                declareWinner(1);
            } else if (HorseNo2.Top>330) {
                timer1.Stop();
                declareWinner(2);
            }
            else if (HorseNo3.Top > 330)
            {
                timer1.Stop();
                declareWinner(3);
            }
            else if (HorseNo4.Top > 330)
            {
                timer1.Stop();
                declareWinner(4);
            }

        }
    }
}
