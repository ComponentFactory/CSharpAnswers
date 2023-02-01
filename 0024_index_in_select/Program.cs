string[] names = new string[] { "Dick", "Bob", "Anne", "Enid", "Charlie" };

IOrderedEnumerable<string> sorted1 = names.OrderBy(n => n);
Console.WriteLine(string.Join(",", sorted1));

var sorted2 = names.Select((name, index) => new { Name = name, Index = index }).OrderBy(n => n.Name);
Console.WriteLine(string.Join("\n", sorted2));

int i = 0;
foreach(string name in names)
{
    Console.WriteLine($"{name} = {i}");
    i++;
}

foreach((string value, int index) in names.WithIndex())
    Console.WriteLine($"{value} = {index}");

public static class LinqExtensions
{
    public static IEnumerable<(T, int)> WithIndex<T>(this IEnumerable<T> input)
    {
        return input.Select((value, index) => (value, index));
    }
}