string[] names = new string[] { "Anne", "Bob", "Charlie", "Dick", "Enid" };

// Verbose pattern for processing chunks
var chunk = new List<string>();
foreach(string name in names)
{
    chunk.Add(name);
    if (chunk.Count == 2)
    {
        Console.WriteLine("Chunk");
        foreach(var item in chunk)
            Console.WriteLine($"  {item}");

        chunk.Clear();
    }
}

if (chunk.Count > 0) 
{
    Console.WriteLine("Chunk");
    foreach(string name in chunk)
        Console.WriteLine($"  {name}");
}


// Concise version using LINQ operator
foreach(IEnumerable<string> chunks in names.Chunk(2))
{
    Console.WriteLine("Chunk");
    foreach(string name in chunks)
        Console.WriteLine($"  {name}");
}