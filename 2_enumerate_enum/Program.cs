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
            Console.WriteLine("\nEnum.GetValues");
            foreach(Suits i in Enum.GetValues<Suits>())
            {
                Console.WriteLine($"{i} = {(int)i}");
            }

            Console.WriteLine("\nEnum.GetNames");
            foreach(string i in Enum.GetNames<Suits>())
            {
                Console.WriteLine(i);
            }
        }
    }
}