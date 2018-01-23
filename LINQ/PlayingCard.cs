using System;

namespace LINQ
{
    public class PlayingCard
    {
        public Suit CardSuit { get; set; }
        public Rank CardRank { get; set; }

        public PlayingCard(Suit s, Rank r)
        {
            CardSuit = s;
            CardRank = r;
        }

        public override string ToString() => $"{ CardRank } of { CardSuit }";
    }
}