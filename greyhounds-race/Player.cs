using System.Windows.Forms;

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

    public void PlaceBet(int Amount, int DogToWin)
    {
        MyBet = new Bet() { this.Amount = Amount, this.Dog = DogToWin };
        return (Cash >= Amount);
    }

    public void Collect(int Winner)
    {

    }
}
