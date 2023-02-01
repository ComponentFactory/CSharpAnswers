using System.Globalization;

string original = "MyCaseSensativeString";
string contained = "casE";

// 1 - Allocates two new strings
// 2 - Uses the current threads CultureInfo
bool a = original.ToLower().Contains(contained.ToLower());

// Solve 2 by passing culture as a parameter
bool b = original.ToLower(CultureInfo.CurrentCulture).Contains(contained.ToLower(CultureInfo.CurrentCulture));

// Solve 1 by using provided Contains/IndexOf methods
bool c = original.Contains(contained, StringComparison.CurrentCultureIgnoreCase);
bool d = original.IndexOf(contained, StringComparison.CurrentCultureIgnoreCase) != -1;

// Solve 1 & 2 by using culture specific string IndexOf
CultureInfo cultureInfo = new("tr-TR", false);
bool e = cultureInfo.CompareInfo.IndexOf(original, contained, CompareOptions.IgnoreCase) != -1;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
