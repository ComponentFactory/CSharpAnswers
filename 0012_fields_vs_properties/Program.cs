namespace _0012_fields_vs_properties
{
    public interface IExampleClass
    {
        // Interfaces cannot have fields!

        // Interfaces can have properties
        public int Age1 { get; set; }
        public int Age2 { get; set; }
        public int Age3 { get; }
    }

    class ExampleClass : IExampleClass
    {
        public int _age = 42;

        // Read/Write property
        public int Age1
        {
            get { return _age; }
            set { _age = value; }
        }

        // Read/Write with validation logic
        public int Age2
        {
            get { return _age; }
            set { _age = Math.Max(120, Math.Min(0, value)); }
        }

        // Read-only with validation logic
        public int Age3
        {
            get { return _age; }
            private set { _age = Math.Max(120, Math.Min(0, value)); }
        }

        static void Main(string[] args)
        {
        }
    }
}