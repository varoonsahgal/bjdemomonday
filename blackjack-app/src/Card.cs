public class Card
{
    public string Suit { get; set; }
    public string Rank { get; set; }
    public int Value
    {
        get
        {
            switch (Rank)
            {
                case "Ace":
                    return 11;
                case "King":
                case "Queen":
                case "Jack":
                    return 10;
                default:
                    return int.Parse(Rank);
            }
        }
    }

    public Card(string rank, string suit) // Ensure the order is rank first, then suit
    {
        Rank = rank;
        Suit = suit;
    }

    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }
}