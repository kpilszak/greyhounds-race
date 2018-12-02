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
                MyBet = null,
                Cash = 100,
                PlayerButton = playerRadioButton1,
                BetLabel = playerLabel1
            };

            PlayerArray[1] = new Player()
            {
                Name = "Nate",
                MyBet = null,
                Cash = 70,
                PlayerButton = playerRadioButton2,
                BetLabel = playerLabel2
            };

            PlayerArray[2] = new Player()
            {
                Name = "Dan",
                MyBet = null,
                Cash = 10,
                PlayerButton = playerRadioButton3,
                BetLabel = playerLabel3
            };
        }
    }
}
