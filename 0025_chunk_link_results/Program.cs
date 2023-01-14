string[] names = new string[] { "Anne", "Bob", "Charlie", "Dick", "Enid" };

var chunk = new List<string>();
foreach(var name in names)
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
    foreach(var name in chunk)
        Console.WriteLine($"  {name}");
}


// foreach(var chunk in names.Chunk(2))
// {
//     Console.WriteLine("Chunk");
//     foreach(var name in chunk)
//         Console.WriteLine($"  {name}");
// }