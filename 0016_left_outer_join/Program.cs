namespace _0016_left_outer_join
{
    static class ExampleClass
    {
        public class Player
        {
            public required string Country { get; set; }
            public required string Name { get; set; }
        }

        static void Main(string[] _)
        {
            List<Player> players = new()
            {
                 new Player() { Country = "Argentina", Name = "Lionel Messi" },
                 new Player() { Country = "England", Name = "Geoff Hurst" },
                 new Player() { Country = "England", Name = "Bobby Charlton" },
                 new Player() { Country = "England", Name = "Gordon Banks" },
                 new Player() { Country = "Portugal", Name = "Cristiano Ronaldo" },
            };

            string[] countries = new[] { "Argentina", "England", "Spain" };

            // Step 1: Group Joinn
            var results1 = countries.GroupJoin(players,
                                               c => c,
                                               p => p.Country,
                                               (c, ps) => new { Country = c, Players = ps });

            results1 = from c in countries
                       join p in players on c equals p.Country into ps
                       select new { Country = c, Players = ps };

            // Step 2: Flattent into single list
            var results2 = countries.GroupJoin(players,
                                               c => c,
                                               p => p.Country,
                                               (c, ps) => new { Country = c, Players = ps })
                                    .SelectMany(g => g.Players,
                                               (g, p) => new { g.Country, p.Name });

            results2 = from c in countries
                       join p in players on c equals p.Country into ps
                       from ge in ps
                       select new { Country = c, ge.Name };

            // Step 3: Handle empty lists so it becomes left outer
            var results3 = countries.GroupJoin(players,
                                               c => c,
                                               p => p.Country,
                                               (c, ps) => new { Country = c, Players = ps })
                                    .SelectMany(g => g.Players.DefaultIfEmpty(),
                                                (g, p) => new { g.Country, Name = p?.Name ?? string.Empty });

            results3 = from c in countries
                       join p in players on c equals p.Country into ps
                       from ge in ps.DefaultIfEmpty()
                       select new { Country = c, Name = ge?.Name ?? string.Empty };

            Console.WriteLine("");
            foreach(var result in results1)
                Console.WriteLine(result);

            Console.WriteLine("");
            foreach(var result in results2)
                Console.WriteLine(result);

            Console.WriteLine("");
            foreach(var result in results3)
                Console.WriteLine(result);

            Console.WriteLine("");
       }
   }
}