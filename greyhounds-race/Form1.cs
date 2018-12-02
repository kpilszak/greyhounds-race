using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greyhounds_race
{
    public partial class Form1 : Form
    {
        public Greyhound[] GreyhoundArray = new Greyhound[4];
        public Player[] PlayerArray = new Player[3];

        public Form1()
        {
            InitializeComponent();
            InitializeGreyhounds();
            InitializePlayers();
        }

        private void InitializeGreyhounds()
        {
            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = greyhoundPictureBox1,
                StartingPosition = greyhoundPictureBox1.Left,
                RaceTrackLength = raceTrackPictureBox.Width - greyhoundPictureBox1.Width                       
            };

            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = greyhoundPictureBox2,
                StartingPosition = greyhoundPictureBox2.Left,
                RaceTrackLength = raceTrackPictureBox.Width - greyhoundPictureBox2.Width
            };

            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = greyhoundPictureBox3,
                StartingPosition = greyhoundPictureBox3.Left,
                RaceTrackLength = raceTrackPictureBox.Width - greyhoundPictureBox3.Width
            };

            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = greyhoundPictureBox4,
                StartingPosition = greyhoundPictureBox4.Left,
                RaceTrackLength = raceTrackPictureBox.Width - greyhoundPictureBox4.Width
            };
        }

        private void InitializePlayers()
        {
            PlayerArray[0] = new Player()
            {
                Name = "Chuck",
                Cash = 100,
                PlayerButton = playerRadioButton1,
                BetLabel = playerLabel1
            };

            PlayerArray[1] = new Player()
            {
                Name = "Nate",     
                Cash = 70,
                PlayerButton = playerRadioButton2,
                BetLabel = playerLabel2
            };

            PlayerArray[2] = new Player()
            {
                Name = "Dan",
                Cash = 10,
                PlayerButton = playerRadioButton3,
                BetLabel = playerLabel3
            };

            for (int i = 0; i < PlayerArray.Length; i++)
            {
                PlayerArray[i].ClearBet();
                PlayerArray[i].UpdateLabels();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            timer1.Start();
        }

        private void playerRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = PlayerArray[0].Name;
        }

        private void playerRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = PlayerArray[1].Name;
        }

        private void playerRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = PlayerArray[2].Name;
        }
        
        private void betsButton_Click(object sender, EventArgs e)
        {
            if (playerRadioButton1.Checked)
            {
                PlayerArray[0].PlaceBet((int)amountButton.Value, (int)greyhoundNumberButton.Value);
                PlayerArray[0].UpdateLabels();
            }
            else if (playerRadioButton2.Checked)
            {
                PlayerArray[1].PlaceBet((int)amountButton.Value, (int)greyhoundNumberButton.Value);
                PlayerArray[1].UpdateLabels();
            }
            else if (playerRadioButton3.Checked)
            {
                PlayerArray[2].PlaceBet((int)amountButton.Value, (int)greyhoundNumberButton.Value);
                PlayerArray[2].UpdateLabels();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < GreyhoundArray.Length; i++)
            {                
                if (GreyhoundArray[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("The winner is Greyhound number " + (i + 1));
                    for (int j = 0; i < PlayerArray.Length; j++)
                    {
                        PlayerArray[j].Collect(i);
                        PlayerArray[j].ClearBet();
                    }
                    for (int k = 0; i < GreyhoundArray.Length; k++)
                    {
                        GreyhoundArray[k].TakeStartingPosition();
                    }
                    groupBox1.Enabled = true;
                }
            }
        }
    }
}
