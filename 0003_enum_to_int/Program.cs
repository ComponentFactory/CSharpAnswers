namespace _0003_enum_to_int
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
            const Suits x = Suits.Hearts;

            // Enum to int
            const int cast = (int)x;
            Console.WriteLine($"ToInt: {x} = {cast}");

            // Int to Enum
            const Suits y = (Suits)cast;
            Console.WriteLine($"ToEnum: {y} = {cast}");

            // String to Enum
            const string parse = "Diamonds";
            if (Enum.TryParse<Suits>(parse, out Suits z))
                Console.WriteLine($"Parsed: {z} = {parse} = {(int)z}");
        }
    }
}
