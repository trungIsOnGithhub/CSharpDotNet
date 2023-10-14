using System;
using System.Numerics;

uint kindasmall = 1;
Console.WriteLine($"{kindasmall}");

ulong big = ulong.MaxValue;
Console.WriteLine($"{big,40:N0}");

BigInteger bigger = BigInteger.Parse("123456789012345678901234567890");
Console.WriteLine($"{bigger,40:N0}");