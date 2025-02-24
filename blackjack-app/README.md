# Blackjack Application

## Overview
This is a simple Blackjack application implemented in C#. The game allows players to play against the dealer, following the classic rules of Blackjack.

## Game Rules
- The objective of the game is to have a hand value closer to 21 than the dealer's hand without exceeding 21.
- Each player is dealt two cards, and they can choose to "hit" (take another card) or "stand" (keep their current hand).
- Face cards (Kings, Queens, Jacks) are worth 10 points, Aces can be worth 1 or 11 points, and all other cards are worth their face value.
- If a player's hand exceeds 21, they "bust" and lose the game.

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