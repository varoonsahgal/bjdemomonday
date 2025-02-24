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
        DisplayInitialHands();
        PlayerTurn();
        DealerTurn();
        DetermineOutcome();
        // Game loop logic will go here
    }

    private void DealInitialCards()
    {
        player.AddCard(deck.DrawCard());
        player.AddCard(deck.DrawCard());
        dealer.AddCard(deck.DrawCard());
        dealer.AddCard(deck.DrawCard());
    }

    private void DisplayInitialHands()
    {
        Console.WriteLine("Player's Hand:");
        foreach (var card in player.Hand)
        {
            Console.WriteLine(card.ToString());
        }
        Console.WriteLine($"Total Value: {player.CalculateHandValue()}");

        Console.WriteLine("\nDealer's Hand:");
        Console.WriteLine(dealer.Hand[0].ToString());
        Console.WriteLine("Hidden Card");
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

    private void PlayerTurn()
    {
        while (true)
        {
            Console.WriteLine("Do you want to (H)it or (S)tand?");
            string choice = Console.ReadLine().ToUpper();

            if (choice == "H")
            {
                player.AddCard(deck.DrawCard());
                Console.WriteLine("Player's Hand:");
                foreach (var card in player.Hand)
                {
                    Console.WriteLine(card.ToString());
                }
                Console.WriteLine($"Total Value: {player.CalculateHandValue()}");

                if (player.CalculateHandValue() > 21)
                {
                    Console.WriteLine("Player busts! Dealer wins.");
                    return;
                }
            }
            else if (choice == "S")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose (H)it or (S)tand.");
            }
        }
    }

    private void DealerTurn()
    {
        while (dealer.CalculateHandValue() < 17)
        {
            dealer.AddCard(deck.DrawCard());
        }
        Console.WriteLine("\nDealer's Final Hand:");
        foreach (var card in dealer.Hand)
        {
            Console.WriteLine(card.ToString());
        }
        Console.WriteLine($"Total Value: {dealer.CalculateHandValue()}");
    }

    private void DetermineOutcome()
    {
        int playerValue = player.CalculateHandValue();
        int dealerValue = dealer.CalculateHandValue();

        Console.WriteLine("\nGame Outcome:");
        if (playerValue > 21)
        {
            Console.WriteLine("Player busts! Dealer wins.");
        }
        else if (dealerValue > 21)
        {
            Console.WriteLine("Dealer busts! Player wins.");
        }
        else if (playerValue > dealerValue)
        {
            Console.WriteLine("Player wins!");
        }
        else if (dealerValue > playerValue)
        {
            Console.WriteLine("Dealer wins!");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }

    // Additional game logic methods will go here
}