using System;
using System.Globalization;

namespace Example
{
    class ExampleClass
    {
        static void Main(string[] args)
        {
            string original = "MyCaseSensativeString";
            string contained = "casE";

            // 1 - Allocates two new strings
            // 2 - Uses the current threads CultureInfo
            var _a = original.ToLower().Contains(contained.ToLower());            
            
            // Solve 2 by passing culture as a parameter
            var _b = original.ToLower(CultureInfo.CurrentCulture).Contains(contained.ToLower(CultureInfo.CurrentCulture));
            
            // Solve 1 by using provided Contains/IndexOf methods
            var _c = original.Contains(contained, StringComparison.CurrentCultureIgnoreCase);
            var _d = original.IndexOf(contained, StringComparison.CurrentCultureIgnoreCase) != -1;

            // Solve 1 & 2 by using culture specific string IndexOf
            CultureInfo cultureInfo = new CultureInfo("tr-TR", false);
            var _e = cultureInfo.CompareInfo.IndexOf(original, contained, CompareOptions.IgnoreCase) != -1;
        }
    }
}
