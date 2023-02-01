Dictionary<int, string> winners = new()
{
    { 2014, "Germany" },
    { 2018, "France" },
    { 2022, "Argentina" },
};

// Standard approach using KeyValuePair instances
foreach (KeyValuePair<int, string> winner in winners)
{
    Console.WriteLine($"{winner.Key} = {winner.Value}");
}

// Use deconstruction for better naming of key/value
Console.WriteLine("");
foreach ((int year, string winner) in winners)
    Console.WriteLine($"{year} = {winner}");
