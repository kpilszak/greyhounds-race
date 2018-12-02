using System;
using System.Windows.Forms;

namespace greyhounds_race
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random MyRandom;

        public bool Run()
        {
            Location += MyRandom.Next(1, 5);
            MyPictureBox.Left = StartingPosition + Location;
            return (MyPictureBox.Left >= RaceTrackLength);
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}