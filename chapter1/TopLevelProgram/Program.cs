using System;
/**
* O(LogN) power method
**/
double pow(double x, int n)
{
    if(x == 0.0)
    {
        return 0.0;
    }

    if(n == 0 || x == 1.0)
    {
        return 1.0;
    }
    
    if(n % 2 == 0)
    {
        var temp = pow(x, n/2);
        return temp * temp;
    }

    return x * pow(x, n-1);
}

Console.WriteLine("Test Top-Level Program(only after C# 9):");

Console.WriteLine($"We are working in {Environment.CurrentDirectory}");

for(var d=0.0; d<10.0; d+=1.0)
{
    Console.WriteLine($"power of {d} to itself(converted and rounded): {pow( d, Convert.ToInt32(Math.Round(d, MidpointRounding.ToZero)) )}");
}