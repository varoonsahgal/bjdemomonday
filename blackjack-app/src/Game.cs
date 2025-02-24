using System;


// This class represents the main game logic for Blackjack
// It has methods to start the game, deal cards, and display hands
public class Game
{
    private Deck deck;
    private Player player;
    private Player dealer;

   
    public Game()
    {
        deck = new Deck();
        player = new Player();
        dealer = new Player();
    }

    public void Start()
    {
        deck.Shuffle();
        DealInitialCards();
        DisplayHands();
        // Game loop logic will go here
    }

    private void DealInitialCards()
    {
        player.AddCard(deck.DrawCard());
        player.AddCard(deck.DrawCard());
        dealer.AddCard(deck.DrawCard());
        dealer.AddCard(deck.DrawCard());
    }

    private void DisplayHands()
    {
        Console.WriteLine("Player's Hand:");
        foreach (var card in player.Hand)
        {
            Console.WriteLine(card.ToString());
        }
        Console.WriteLine($"Total Value: {player.CalculateHandValue()}");

        Console.WriteLine("\nDealer's Hand:");
        foreach (var card in dealer.Hand)
        {
            Console.WriteLine(card.ToString());
        }
        Console.WriteLine($"Total Value: {dealer.CalculateHandValue()}");
    }

    // Additional game logic methods will go here
}