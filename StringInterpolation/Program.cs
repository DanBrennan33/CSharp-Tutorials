using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Daniel";
            var lastName = "Brennan";
            var strFormat = String.Format("Format: My name is {0} {1}.", firstName, lastName);
            var strInterp = $"Interpolation: My name is {firstName} {lastName}.";
            Console.WriteLine(strFormat);
            Console.WriteLine(strInterp);

            for (var i = 0; i < 5; i++)
                Console.WriteLine($"This is line number {i + 1}.");

            var rand = new Random();
            for (var i = 998; i < 1005; i++) 
            {
                var randomDecimal = rand.NextDouble() * 10000;
                Console.WriteLine($"{i, -10} {randomDecimal, 6:N2}");
            }
        }
    }
}
