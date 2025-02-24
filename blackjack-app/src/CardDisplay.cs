using System;

public static class CardDisplay
{
    public static string[] GetCardArt(Card card, bool hidden = false)
    {
        if (hidden)
        {
            return new string[]
            {
                "┌─────────┐",
                "│░░░░░░░░░│",
                "│░░░░░░░░░│",
                "│░░░░░░░░░│",
                "│░░░░░░░░░│",
                "└─────────┘"
            };
        }

        string rank = card.Rank.PadRight(2);
        string suit = card.Suit[0].ToString();
        
        return new string[]
        {
            "┌─────────┐",
            $"│ {rank}      │",
            $"│    {suit}    │",
            $"│         │",
            $"│      {rank} │",
            "└─────────┘"
        };
    }

    public static void DisplayCardRow(Card[] cards, bool[] hidden = null)
    {
        string[] output = new string[6];
        for (int i = 0; i < 6; i++) output[i] = "";

        foreach (var card in cards)
        {
            var isHidden = hidden != null && hidden[Array.IndexOf(cards, card)];
            var cardArt = GetCardArt(card, isHidden);
            for (int i = 0; i < 6; i++)
            {
                output[i] += cardArt[i] + " ";
            }
        }

        foreach (var line in output)
        {
            Console.WriteLine(line);
        }
    }
}
