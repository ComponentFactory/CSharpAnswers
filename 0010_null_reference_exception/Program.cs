using System.Runtime.CompilerServices;
using System;

namespace _0010_null_reference_exception
{
    class ExampleClass
    {
        static void Main(string[] args)
        {
            ExampleClass e2 = new ExampleClass();
            string? typeOfDay = e2.TodayAsString();
            Console.WriteLine(typeOfDay!.ToUpper());
        }

        public string? TodayAsString()
        {
            switch(DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    return "Workday";
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return "Weekend";
                default:
                    return null;
            }
        }
    }
}