namespace _0002_enumerate_enum
{
    public enum Suits
    {
        Spades,
        Hearts,
        Diamonds,
        Clubs
    }

    static class ExampleClass
    {
        static void Main(string[] _)
        {
            Console.WriteLine("\nEnum.GetValues");
            foreach (Suits i in Enum.GetValues<Suits>())
                Console.WriteLine($"{i} = {(int)i}");

            Console.WriteLine("\nEnum.GetNames");
            foreach (string i in Enum.GetNames<Suits>())
                Console.WriteLine(i);
        }
    }
}
