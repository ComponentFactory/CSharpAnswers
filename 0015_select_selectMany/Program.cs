namespace _0015_select_selectMany
{
    class ExampleClass
    {
        public class Winner
        {
            public required string Country { get; set; }
            public required int[] Years { get; set; }
        }

        static void Main(string[] args)
        {
            List<Winner> list = new()
            {
                new Winner() { Country = "Argentina", Years = new[] { 1978, 1986, 2022 } },
                new Winner() { Country = "England  ", Years = new[] { 1966 } },
                new Winner() { Country = "Germany  ", Years = new[] { 1954, 1974, 1990, 2014 } },
            };

            // Select is a 1-to-1 mapping
            List<string> countries = list.Select(w => w.Country).ToList();
            List<int[]> listOfArrays = list.Select(w => w.Years).ToList();

            Console.WriteLine("\nlistOfArrays :-");
            foreach(var entry in listOfArrays)
                Console.WriteLine(entry);
                
            // Select many is a 1-to-Many mapping
            List<int> aggregatedList = list.SelectMany(w => w.Years).ToList();

            Console.WriteLine("\naggregatedList :-");
            foreach(var entry in aggregatedList)
                Console.WriteLine(entry);

            // Use the second paramter to customize the values aggregated into a new list
            var customList = list.SelectMany(w => w.Years, (w, y) => new { Country = w.Country, Year = y })
                                 .ToList();

            Console.WriteLine("\ncustomList :-");
            foreach(var entry in customList)
                Console.WriteLine(entry);

            var orderedList = list.SelectMany(w => w.Years, (w, y) => new { Country = w.Country, Year = y })
                                  .OrderBy(e => e.Year)
                                  .ToList();

            Console.WriteLine("\norderedList :-");
            foreach(var entry in orderedList)
                Console.WriteLine(entry);

            string[] cols = new[] { "A", "B", "C" };
            string[] rows = new[] { "1", "2", "3" };

            // Return a fixed list in the first parameter to perform a cross join
            var crossApply = cols.SelectMany(col => rows, (col, row) => $"{col}{row}").ToList();
            Console.WriteLine("\ncrossApply :-");
            foreach(var entry in crossApply)
                Console.WriteLine(entry);
        }
   }
}