string[] names = new string[] { "Anne", "Bob", "Charlie", "Dick", "Enid" };

var page1 = names.Take(2);
var page2 = names.Skip(2).Take(2);
var page3 = names.Skip(4).Take(2);

Console.WriteLine("\nPage 1");
foreach(var name in page1)
    Console.WriteLine(name);

Console.WriteLine("\nPage 2");
foreach(var name in page2)
    Console.WriteLine(name);

Console.WriteLine("\nPage 3");
foreach(var name in page3)
    Console.WriteLine(name);
Console.WriteLine("");

var list1 = names.TakeLast(2);
var list2 = names.SkipLast(2);

Console.WriteLine("\nTakeLast");
foreach(var name in list1)
    Console.WriteLine(name);

Console.WriteLine("\nSkipLast");
foreach(var name in list2)
    Console.WriteLine(name);
Console.WriteLine("");


var list3 = names.TakeWhile(n => n.Length == 4);
var list4 = names.SkipWhile(n => n.Length == 4);

Console.WriteLine("\nTakeWhile");
foreach(var name in list3)
    Console.WriteLine(name);

Console.WriteLine("\nSkipWhile");
foreach(var name in list4)
    Console.WriteLine(name);
Console.WriteLine("");

var page2 = (from n in names select n).Skip(2).Take(2);