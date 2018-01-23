using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public enum Suit
    {
        Clubs, 
        Diamonds,
        Hearts,
        Spades
    }

    public enum Rank
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public class Program
    {
        static IEnumerable<Suit> Suits() => Enum.GetValues(typeof(Suit)) as IEnumerable<Suit>;

        static IEnumerable<Rank> Ranks() => Enum.GetValues(typeof(Rank)) as IEnumerable<Rank>;
        
        static void Main(string[] args)
        {
            var startingDeck = (from s in Suits().LogQuery("Suit Generation")
                                from r in Ranks().LogQuery("Rank Generation")
                                select new PlayingCard(s, r))
                                .LogQuery("Starting Deck")
                                .ToArray();
                                
            // foreach (var c in startingDeck) 
            // {
            //     Console.WriteLine(c);
            // }
            
            var shuffle = startingDeck;
            var times = 0;

            do {
                shuffle = shuffle.Take(26)
                    .LogQuery("Top Half")
                    .InterleaveSequenceWith(shuffle.Skip(26).LogQuery("Bottom Half"))
                    .LogQuery("shuffle")
                    .ToArray();

                // foreach (var c in shuffle)
                // {
                //    Console.WriteLine(c);
                // }

                times++;
            } while (!startingDeck.SequenceEquals(shuffle));

            Console.WriteLine(times);
        }
    }
}
