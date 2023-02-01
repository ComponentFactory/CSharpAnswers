namespace _0009_null_coalescing
{
    class ExampleClass
    {
        static void Main(string[] _)
        {
            ExampleClass? example = null;
            example ??= new ExampleClass();

            int num1 = Double(null);
            int num2 = Double(42);
            Console.WriteLine($"num1:{num1} num2:{num2}");

            example.Name = "John Doe";
            Console.WriteLine($"Name:{example.Name}");
            example.Name = null!;
        }

        public static int Double(int? number) => (number ?? 0) * 2;

        private string _name = string.Empty;

        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(Name));
        }
    }
}
