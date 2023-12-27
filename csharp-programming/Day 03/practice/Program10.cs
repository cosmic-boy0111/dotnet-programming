namespace csharp_programming
{
    enum CardSuit { Hearts, Diamonds, Clubs, Spades };
    enum CardRank { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }
    internal class Program10
    {
        public class Card
        {
            private CardSuit Suit
            {
                get { return Suit; }
                set { Suit = value; }
            }

            private CardRank Rank { 
                get { return Rank; } 
                set { Rank = value; }
            }

            public int GetValue<T>(T card)
            {
                dynamic dCard = card;
                return (int)dCard + 1;
            }

        }
        public static void Main()
        {
            Card c = new Card();
            int result = c.GetValue(CardRank.Four);
            result = c.GetValue(CardSuit.Clubs);
        }
    }
}
