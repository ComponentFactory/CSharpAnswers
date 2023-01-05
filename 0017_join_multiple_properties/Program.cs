namespace _0017_join_multiple_properties
{
    class ExampleClass
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

        static void Main(string[] args)
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
                                    age => new { Country = age.Country, Name = age.Name },
                                    pay => new { Country = pay.Country, Name = pay.Name },
                                    (age, pay) => new {
                                        Country = age.Country, 
                                        Name = age.Name,
                                        Age = age.Age,
                                        Pay = pay.Pay,
                                    });

            // Query syntax
            results = from a in ages
                      join p in paid on new { Country = a.Country, Name = a.Name } equals
                                        new { Country = p.Country, Name = p.Name }
                      select new {
                          Country = a.Country, 
                          Name = a.Name,
                          Age = a.Age,
                          Pay = p.Pay,
                      };

           Console.WriteLine("");                                               
            foreach(var result in results)                                              
                Console.WriteLine(result);
            Console.WriteLine("");                                               
       }
   }
}