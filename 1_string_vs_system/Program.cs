namespace Example
{
    class ExampleClass
    {
        static void Main(string[] args)
        {
            string a1 = "";     System.String b1 = a1;
            char a2 = 'a';      System.Char b2 = a2;

            sbyte a3 = 3;       System.SByte b3 = a3;
            byte a4 = 4;        System.Byte b4 = a4;
            short a5 = 5;       System.Int16 b5 = a5;
            ushort a6 = 6;      System.UInt16 b6 = a6;
            int a7 = 7;         System.Int32 b7 = a7;
            uint a8 = 8;        System.UInt32 b8 = a8;
            long a9 = 9;        System.Int64 b9 = a9;
            ulong a10 = 10;     System.UInt64 b10 = a10;

            decimal a11 = 11m;  System.Decimal b11 = a11;
            float a12 = 12f;    System.Single b12 = a12;
            double a13 = 13;    System.Double b13 = a13;

            bool a14 = true;    System.Boolean b14 = a14;

                                System.Int128 b15 = 15;
                                System.UInt128 b16 = 16;
        }
    }
}