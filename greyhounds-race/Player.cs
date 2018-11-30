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

    }

    public void PlaceBet(int Amount, int DogToWin)
    {

    }

    public void Collect(int Winner)
    {

    }
}
