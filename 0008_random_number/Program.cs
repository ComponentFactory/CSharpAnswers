Random rand = new Random();

// >= 0 && < int.MaxValue
int AnyPositive = rand.Next();

// >= 1024 && < int.MaxValue
int AlmostAnyPostive = rand.Next(1024);

// >= 1 && < 7
int DiceRoll = rand.Next(1, 7);

// Upper limit is long.MaxValue
long AnyPositive = rand.NextInt64();
long AnyPositive = rand.NextInt64(1024);
long AnyPositive = rand.NextInt64(1, 7);

// Cannot specify range
int s = rand.NextSingle();
int d = rand.NextDouble();

// Fill entire byte array
byte[] bytes = new byte[8];
rand.NextBytes(bytes);

// Fill just span of a byte array
var span = new Span<bytes>(bytes, 0, 4);
rand.NextBytes(span);
