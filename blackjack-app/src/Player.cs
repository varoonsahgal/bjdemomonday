using System.Collections.Generic;

public class Player
{
    public List<Card> Hand { get; private set; }

    public Player()
    {
        Hand = new List<Card>();
    }

    public void AddCard(Card card)
    {
        Hand.Add(card);
    }

    public int CalculateHandValue()
    {
        int value = 0;
        int aceCount = 0;

        foreach (var card in Hand)
        {
            value += card.Value; // Assuming Card class has a Value property
            if (card.Rank == "Ace") // Assuming Card class has a Rank property
            {
                aceCount++;
            }
        }

        while (value > 21 && aceCount > 0)
        {
            value -= 10; // Adjust for Ace value
            aceCount--;
        }

        return value;
    }
}