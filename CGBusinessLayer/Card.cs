namespace BusinessLayer
{
    public class Card
    {
        public Card()
        {
            IsJoker = false;
        }

        public Suit Suit { get; set; }
        public CardNumber CardNumber { get; set; }
        public bool IsJoker { get; set; }

        public virtual int GetValue()
        {
            return (int) CardNumber * (int) Suit;
        }
    }

    public class JokerCard : Card
    {
        public JokerCard()
        {
            IsJoker = true;
        }
    }

    public enum Suit
    {
        Club = 1,
        Diamond = 2,
        Heart = 3,
        Spade = 4,
        None = 5
    }

    public enum CardNumber
    {
        Zero = 0,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14
    }
}