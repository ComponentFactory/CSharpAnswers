string[] names = new string[] { "Anne", "Bob", "Charlie", "Dick", "Enid" };

IEnumerable<string> page1 = names.Take(2);
IEnumerable<string> page2 = names.Skip(2).Take(2);
IEnumerable<string> page3 = names.Skip(4).Take(2);

Console.WriteLine("\nPage 1");
foreach(string name in page1)
    Console.WriteLine(name);

Console.WriteLine("\nPage 2");
foreach(string name in page2)
    Console.WriteLine(name);

Console.WriteLine("\nPage 3");
foreach(string name in page3)
    Console.WriteLine(name);
Console.WriteLine("");

IEnumerable<string> list1 = names.TakeLast(2);
IEnumerable<string> list2 = names.SkipLast(2);

Console.WriteLine("\nTakeLast");
foreach(string name in list1)
    Console.WriteLine(name);

Console.WriteLine("\nSkipLast");
foreach(string name in list2)
    Console.WriteLine(name);
Console.WriteLine("");

IEnumerable<string> list3 = names.TakeWhile(n => n.Length == 4);
IEnumerable<string> list4 = names.SkipWhile(n => n.Length == 4);

Console.WriteLine("\nTakeWhile");
foreach(string name in list3)
    Console.WriteLine(name);

Console.WriteLine("\nSkipWhile");
foreach(string name in list4)
    Console.WriteLine(name);
Console.WriteLine("");

IEnumerable<string> mixed = (from n in names select n).Skip(2).Take(2);