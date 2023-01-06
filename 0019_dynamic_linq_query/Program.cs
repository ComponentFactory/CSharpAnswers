using System.Diagnostics;
using System.Linq.Expressions;

namespace _0019_dynamic_linq_query
{
    class ExampleClass
    {
        public record class Person(string Country, string Name, int Age);

        public enum OrderColumn
        {
            Country,
            Name,
            Age
        }

        static void Main(string[] _)
        {
            List<Person> people = new()
            {
                new Person("France",  "John Doe", 41),
                new Person("Belgium", "John Doe", 20),
                new Person("England", "John Doe", 35),
                new Person("Germany", "Jane Doe", 18),
            };

            // Static query
            var result1 = people.Where(p => p.Age > 18)
                                            .OrderBy(p => p.Country)
                                            .ToList();

            // Dynamic OrderBy
            bool checkAge = false;
            OrderColumn ordering = OrderColumn.Age;

            IEnumerable<Person> result2 = people;

            // Only filter by age if required
            if (checkAge)
                result2 = result2.Where(p => p.Age > 18);

            // Order by dynamic column
            result2 = ordering switch
            {
                OrderColumn.Country => result2.OrderBy(p => p.Country),
                OrderColumn.Name => result2.OrderBy(p => p.Name),
                OrderColumn.Age => result2.OrderBy(p => p.Age),
                _ => throw new ArgumentOutOfRangeException()
            };

            var result4 = result2.ToList();

            Debug.WriteLine("");
            foreach (var result in result4)
                Debug.WriteLine(result);
            Debug.WriteLine("");
        }
    }
}
