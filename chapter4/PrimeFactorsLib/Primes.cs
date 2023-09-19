using System;
using System.Collections;
using System.Collections.Generic;

// need replacing with proper unit test
class Program
{
	static void Main(string[] args)
	{
		bool is12Prime = Primes.Functions.IsPrime(number: 12);
		bool is17Prime = Primes.Functions.IsPrime(number: 17);
		Console.WriteLine($"12 is prime number: {is12Prime}, 17 is prime number: {is17Prime}");
		Primes.Functions.GetAllPrimesUpTo(69).ForEach(number => { Console.Write($"{number}, "); });
		Console.WriteLine(Primes.Functions.PrimeFactorsOf(27));
	}
}

namespace Primes
{
  public class Functions
  {
    public static bool IsPrime(Int32 number)
    {
      if( number < 2 )
        return false;

      for(Int32 divisor = 2; divisor * divisor <= number; ++divisor)
      {
        if( number % divisor == 0 )
          return false;
      }

      return true;
    }

    public static List<Int32> GetAllPrimesUpTo(Int32 target)
    {
      var result = new List<Int32>();

      // Prime numbers are greater than 1 that only have two factors, 1 and itself.
      for(Int32 number = 0; number <= target; ++number)
        if( IsPrime(number) )
          result.Add(number);

      return result;
    }

    public static string PrimeFactorsOf(int number)
    {
      var PrimeNumbers = GetAllPrimesUpTo(number);

      string factors = string.Empty;

      foreach (Int32 divisor in PrimeNumbers)
      {
        int remainder = 1; // Generic Initial Value
        do
        {
          remainder = number % divisor;
          if (remainder == 0)
          {
            number = number / divisor;
            if (number == 1)
              factors += $"{divisor}";
            else
              factors += $"{divisor} x ";
          }
        } while (remainder == 0);
      }

      return $"{factors}";
    }
  }
}
