using System.Windows.Forms;

public class Bet
{
    public int Amount;
    public int Dog;
    public Player Bettor;

    public string GetDescription()
    {
        if (Amount == 0)
        {
            return Bettor.Name + " hasn't placed a bet.";
        }
        else
        {
            return Bettor.Name + " placed a bet of " + Amount + "$ on greyhound number " + Dog;
        }
    }

    public int PayOut(int Winner)
    {

    }
}
