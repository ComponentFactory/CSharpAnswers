using System;

namespace _0009_null_coalescing
{
    class ExampleClass
    {
        static void Main(string[] args)
        {
            ExampleClass? example = null;
            example ??= new ExampleClass();   

            int num1 = example.Double(null);
            int num2 = example.Double(42);
            Console.WriteLine($"num1:{num1} num2:{num2}");

            example.Name = "John Doe";
            Console.WriteLine($"Name:{example.Name}");
            example.Name = null!;        
        }

        public int Double(int? number)
        {
            return (number ?? 0) * 2;
        }

        private string _name = string.Empty;
        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(Name));
        }
    }
}
