namespace _0017_join_multiple_properties
{
    static class ExampleClass
    {
        public class PersonAge
        {
            public required string Country { get; set; }
            public required string Name { get; set; }
            public required int Age { get; set; }
        }

        public class PersonPay
        {
            public required string Country { get; set; }
            public required string Name { get; set; }
            public required int Pay { get; set; }
        }

        static void Main(string[] _)
        {
            List<PersonAge> ages = new()
            {
                 new PersonAge() { Country = "Belgium", Name = "John Doe", Age = 21 },
                 new PersonAge() { Country = "England", Name = "John Doe", Age = 24 },
                 new PersonAge() { Country = "England", Name = "Jane Doe", Age = 30 },
            };

            List<PersonPay> paid = new()
            {
                 new PersonPay() { Country = "Belgium", Name = "John Doe", Pay = 1000 },
                 new PersonPay() { Country = "England", Name = "John Doe", Pay = 2000 },
                 new PersonPay() { Country = "England", Name = "Jane Doe", Pay = 3000 },
            };

            // Method syntax
            var results = ages.Join(paid,
                                    age => new { age.Country, age.Name },
                                    pay => new { pay.Country, pay.Name },
                                    (age, pay) => new {
                                        age.Country,
                                        age.Name,
                                        age.Age,
                                        pay.Pay,
                                    });

            // Query syntax
            results = from a in ages
                      join p in paid on new { a.Country, a.Name } equals
                                        new { p.Country, p.Name }
                      select new {
                          a.Country,
                          a.Name,
                          a.Age,
                          p.Pay,
                      };

           Console.WriteLine("");
            foreach(var result in results)
                Console.WriteLine(result);

            Console.WriteLine("");
       }
   }
}