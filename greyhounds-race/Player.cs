using System.Windows.Forms;

namespace greyhounds_race
{
    public class Player
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton PlayerButton;
        public Label BetLabel;

        public void UpdateLabels()
        {
            BetLabel.Text = MyBet.GetDescription();
            PlayerButton.Text = Name + " has " + Cash + "$";
        }

        public void ClearBet()
        {
            MyBet = null;
        }

        public bool PlaceBet(int Amount, int DogToWin)
        {
            MyBet = new Bet() { Amount = Amount, Dog = DogToWin };
            return (Cash >= Amount);
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            UpdateLabels();
        }
    }
}