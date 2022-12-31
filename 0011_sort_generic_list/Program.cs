

namespace _0011_sort_generic_list
{
    class ExampleClass
    {
        public class Winner
        {
            public required int Year { get; set; }
            public required string Country { get; set; }
        }

        static void Main(string[] args)
        {
            List<Winner> list = new()
            {
                new Winner() { Year = 2022, Country = "Argentina"},
                new Winner() { Year = 2014, Country = "Germany"},
                new Winner() { Year = 2018, Country = "France"},
            };

            foreach(var entry in list)
                Console.WriteLine($"{entry.Year} = {entry.Country}");

            // Sort in place
            list.Sort((l, r) => l.Year.CompareTo(r.Year));

            // Sort using LINQ
            list = list.OrderBy(w => w.Year).ToList();
            list = list.OrderByDescending(w => w.Country).ToList();

            Console.WriteLine("");
            foreach(var entry in list)
                Console.WriteLine($"{entry.Year} = {entry.Country}");
        }
    }
}