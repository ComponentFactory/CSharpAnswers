using System;

namespace Example
{
    public enum Suits
    {
        Spades,
        Hearts,
        Diamonds,
        Clubs
    }

    class ExampleClass
    {
        static void Main(string[] args)
        {
            Suits x = Suits.Hearts;

            int cast = (int)x;
            Console.WriteLine($"ToInt: {x} = {cast}");

            Suits y = (Suits)cast;
            Console.WriteLine($"ToEnum: {y} = {cast}");

            string parse = "Diamonds";
            if (Enum.TryParse<Suits>(parse, out var z))
            {
                Console.WriteLine($"Parsed: {z} = {parse} = {(int)z}");
            }
        }
    }
}
