Random rand = new();

// >= 0 && < int.MaxValue
int anyPositive = rand.Next();

// >= 1024 && < int.MaxValue
int almostAnyPostive = rand.Next(1024);

// >= 1 && < 7
int diceRoll = rand.Next(1, 7);

// Upper limit is long.MaxValue
long anyPositive1 = rand.NextInt64();
long anyPositive2 = rand.NextInt64(1024);
long anyPositive3 = rand.NextInt64(1, 7);

// Cannot specify range
float s = rand.NextSingle();
double d = rand.NextDouble();

// Fill entire byte array
byte[] bytes = new byte[8];
rand.NextBytes(bytes);

// Fill just span of a byte array
var span = new Span<byte>(bytes, 0, 4);
rand.NextBytes(span);
