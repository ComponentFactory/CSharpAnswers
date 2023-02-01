namespace _0014_multiple_orderBy
{
    static class ExampleClass
    {
        public class Person
        {
            public required int Age { get; set; }
            public required string Name { get; set; }
        }

        static void Main(string[] _)
        {
            List<Person> list = new()
            {
                new Person() { Age = 30, Name = "Alice"},
                new Person() { Age = 28, Name = "Bob"},
                new Person() { Age = 28, Name = "Charlie"},
                new Person() { Age = 28, Name = "David"},
                new Person() { Age = 27, Name = "Ethan"},
            };

            // LINQ sort using 1 property
            list = list.OrderBy(p => p.Age).ToList();

            // LINQ sort using 2 levels of property
            list = list.OrderBy(p => p.Age).ThenByDescending(p => p.Name).ToList();

            Console.WriteLine("");
            foreach(Person persion in list)
                Console.WriteLine($"{persion.Age} = {persion.Name}");
        }
    }
}