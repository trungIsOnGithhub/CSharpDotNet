using static System.Console;

static partial class Program {
  static string CardinalToOrdinal(int number) {
    switch(number)
    {
      case 11:
      case 12:
      case 13:
        return $"{number}th";
      default:
        int lastDigit = number % 10;

        string suffix = lastDigit switch {
          1 => "st",
          2 => "nd",
          3 => "rd",
          _ => "th"
        };
        return $"{number}{suffix}";
    }
  }
}


static partial class Program {
  // Lambda expression
  static int FibFunctional(int term) =>
    term switch
    {
      1 => 0,
      2 => 1,
      _ => FibFunctional(term - 1) + FibFunctional(term - 2)
    };
  static void RunFibImperative()
  {
    for (int i = 1; i <= 30; ++i)
    {
      WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
        arg0: CardinalToOrdinal(i),
        arg1: FibFunctional(term: i));
    }
  }
}

static partial class Program
{
    /// <summary>
    /// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
    /// </summary>
    /// <param name="number">Number is a cardinal value e.g. 1, 2, 3, and so on.</param>
    /// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
    static void CalculateTaxByRegion(decimal amount, string twoLetterRegionCode)
    {
      decimal rate = 0.0M;

      // since we are matching string values a switch
      // statement is easier than a switch expression

      switch (twoLetterRegionCode)
      {
        case "CH": // Switzerland 
          rate = 0.08M;
          break;
        case "DK": // Denmark
        case "NO": // Norway
          rate = 0.25M;
          break;
        case "GB": // United Kingdom
        case "FR": // France
          rate = 0.2M;
          break;
        case "HU": // Hungary
          rate = 0.27M;
          break;
        case "OR": // Oregon
        case "AK": // Alaska
        case "MT": // Montana
          rate = 0.0M;
          break;
        case "ND": // North Dakota
        case "WI": // Wisconsin
        case "ME": // Maine
        case "VA": // Virginia
          rate = 0.05M;
          break;
        case "CA": // California
          rate = 0.0825M;
          break;
        default: // most US states 
          rate = 0.06M;
          break;
      }

      decimal taxToPay = amount * rate;

      WriteLine($"You must pay {taxToPay:C} in tax."); // format the taxToPay output as currency by using {taxToPay:C}
    }
    static void RunCardinalToOrdinal(int upToNumber = 69)
    {
      for (int number = 1; number <= upToNumber; number++)
      {
        WriteLine($"{CardinalToOrdinal(number)}");
      }
    }
}

static partial class Program {
  static void Main(string[] args) {
    CalculateTaxByRegion(11.11M, "FR");
    RunCardinalToOrdinal();
    RunFibImperative();
  }
}
