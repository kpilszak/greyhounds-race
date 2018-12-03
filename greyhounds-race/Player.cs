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
            try
            {
                BetLabel.Text = MyBet.GetDescription();
            }
            catch(System.NullReferenceException e)
            {
                
            }
            finally
            {
                PlayerButton.Text = Name + " has " + Cash + "$";
            }
        }

        public void ClearBet()
        {
            PlaceBet(0, 0);
        }

        public bool PlaceBet(int Amount, int DogToWin)
        {
            MyBet = new Bet() { Amount = Amount, Dog = DogToWin, Bettor = this };
            return (Cash >= Amount);
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            UpdateLabels();
        }
    }
}