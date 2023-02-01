namespace _0015_select_selectMany
{
    static class ExampleClass
    {
        public class Winner
        {
            public required string Country { get; set; }
            public required int[] Years { get; set; }
        }

        static void Main(string[] _)
        {
            List<Winner> list = new()
            {
                new Winner() { Country = "Argentina", Years = new[] { 1978, 1986, 2022 } },
                new Winner() { Country = "England  ", Years = new[] { 1966 } },
                new Winner() { Country = "Germany  ", Years = new[] { 1954, 1974, 1990, 2014 } },
            };
        }
   }
}