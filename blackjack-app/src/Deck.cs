using System;
using System.Collections.Generic;

public class Deck
{
    private List<Card> cards;
    private Random random;

    public Deck()
    {
        random = new Random();
        cards = new List<Card>();
        InitializeDeck();
    }

    private void InitializeDeck()
    {
        // Add code to initialize the deck with 52 cards
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        foreach (var suit in suits)
        {
            foreach (var rank in ranks)
            {
                cards.Add(new Card(rank, suit)); // Ensure the order is rank first, then suit
            }
        }
    }

    public void Shuffle()
    {
        for (int i = 0; i < cards.Count; i++)
        {
            int j = random.Next(i, cards.Count);
            var temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
        }
    }

    public Card DrawCard()
    {
        if (cards.Count == 0) throw new InvalidOperationException("No cards left in the deck.");
        Card card = cards[0];
        cards.RemoveAt(0);
        return card;
    }
}