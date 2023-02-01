namespace _0020_groupBy_multiple_properties
{
    static class ExampleClass
    {
        public record class Sale(string Country, string Product, int Quantity);

        static void Main(string[] _)
        {
            List<Sale> sales = new()
            {
                 new Sale("Belgium", "Laptop", 7),
                 new Sale("Belgium", "Desktop", 7),
                 new Sale("England", "Laptop", 4),
                 new Sale("England", "Desktop", 6),
                 new Sale("England", "Laptop", 3),
                 new Sale("England", "Desktop", 1),
            };

            // Method syntax
            var byCountry = sales.GroupBy(s => s.Country)
                                 .Select(g => new
                                 {
                                    Country = g.Key,
                                    Quantity = g.Sum(s => s.Quantity)
                                 });

            var byCountryProduct = sales.GroupBy(s => new { s.Country, s.Product })
                                        .Select(g => new
                                        {
                                            g.Key.Country,
                                            g.Key.Product,
                                            Quantity = g.Sum(s => s.Quantity)
                                        });

            // Query syntax
            byCountry = from s in sales
                        group s by s.Country into g
                        select new
                        {
                            Country = g.Key,
                            Quantity = g.Sum(s => s.Quantity)
                        };

            byCountryProduct = from s in sales
                               group s by new { s.Country, s.Product } into g
                               select new
                               {
                                   g.Key.Country,
                                   g.Key.Product,
                                   Quantity = g.Sum(s => s.Quantity)
                               };

            Console.WriteLine("");
            foreach(var result in byCountry)
                Console.WriteLine(result);

            Console.WriteLine("");
            foreach(var result in byCountryProduct)
                Console.WriteLine(result);

            Console.WriteLine("");
       }
   }
}