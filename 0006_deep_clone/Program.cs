using System.Text.Json;

namespace _0006_deep_clone
{
    class ExampleClass
    {
        static void Main(string[] args)
        {
            Person original = new Person()
            {
                Name = "John Doe",
                Contacts = new()
                {
                    new Contact { ContactType = ContactType.Email, Value = "joe@doe.com" },
                    new Contact { ContactType = ContactType.Phone, Value = "911" },
                    new Contact { ContactType = ContactType.Address, Value = "12 Acacia Avenue" }
                }
            };

            Console.WriteLine(original.ToString());

            Person? clone = original.Clone();
            Console.WriteLine(clone!.ToString());
        }
    }

    static class CloneExtension
    {
        public static T? Clone<T>(this T obj)
        {
            string jsonString = JsonSerializer.Serialize(obj);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }
}
