using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using System;

namespace _0010_null_reference_exception
{
    class ExampleClass
    {
        static void Main(string[] args)
        {
            // Single level of backtracking to find null
            ExampleClass e1 = null;
            Console.WriteLine(e1.ToString().ToUpper());

            // Two levels of backtracking to find null
            ExampleClass e2 = new ExampleClass();
            string typeOfDay = e2.TodayAsString();
            Console.WriteLine(typeOfDay.ToUpper());
        }

        public string TodayAsString()
        {
            switch(DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                    return "Workday";
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return "Weekend";
                default:
                    {
                        // Should never get here
                        // case for Friday is missing
                        return null;
                    }
            }
        }
    }
}