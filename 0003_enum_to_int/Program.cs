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

            // Enum to int
            int cast = (int)x;
            Console.WriteLine($"ToInt: {x} = {cast}");

            // Int to Enum
            Suits y = (Suits)cast;
            Console.WriteLine($"ToEnum: {y} = {cast}");

            // String to Enum
            string parse = "Diamonds";
            if (Enum.TryParse<Suits>(parse, out var z))
            {
                Console.WriteLine($"Parsed: {z} = {parse} = {(int)z}");
            }
        }
    }
}
