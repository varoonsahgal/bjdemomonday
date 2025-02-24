# Blackjack Application

## Overview
This is a simple Blackjack application implemented in C#. The game allows players to play against the dealer, following the classic rules of Blackjack.

## Game Rules
- The objective of the game is to have a hand value closer to 21 than the dealer's hand without exceeding 21.
- Each player is dealt two cards, and they can choose to "hit" (take another card) or "stand" (keep their current hand).
- Face cards (Kings, Queens, Jacks) are worth 10 points, Aces can be worth 1 or 11 points, and all other cards are worth their face value.
- If a player's hand exceeds 21, they "bust" and lose the game.
- A hand with an Ace and a 10-point card (10, Jack, Queen, King) is called a "Blackjack" and is the best possible hand. A Blackjack typically pays 3:2, meaning the player wins 1.5 times their bet.
- After all players have finished their turns, the dealer reveals the hole card.
- The dealer must hit until their hand value is 17 or higher.
- If the dealer busts, all remaining players win.
- If a player's hand value is higher than the dealer's without exceeding 21, the player wins.
- If the dealer's hand value is higher, the dealer wins.
- If both the player and dealer have the same hand value, it is a "push" (tie), and the player's bet is returned.

## How to Run the Application
1. Ensure you have the .NET SDK installed on your machine.
2. Clone the repository or download the source code.
3. Navigate to the project directory in your terminal.
4. Run the following command to build the project:
   ```
   dotnet build
   ```
5. After building, run the application using:
   ```
   dotnet run --project src/blackjack-app.csproj
   ```

Enjoy playing Blackjack!