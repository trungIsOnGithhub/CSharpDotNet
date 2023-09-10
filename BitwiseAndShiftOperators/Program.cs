using static System.Console;

namespace Chapter3 {
  internal class BitwiseAndShift {
    static string ToBinaryString(int value)
    {
      return Convert.ToString(value, toBase: 2).PadLeft(8, '0');
    }
    public static bool CheckPowerOf2(int number) {
      bool check = number > 0 && (number & (number -1)) == 0;
      WriteLine($"Number {number} is power of 2: { check }");
      return check;
    }
    public static int SetNthBit(int number, int N)
    {
      int afterSetBit = number | (1<<N);
      WriteLine($"Before Set Nth bit = { ToBinaryString(number) }");
      WriteLine($"After Set Nth bit = { ToBinaryString(afterSetBit) }");
      return afterSetBit;
    }
    public static void MultiplyByNthPowerOf2(int number, int N) {
      WriteLine($"number << N = { number << N }");
      // multiply a by 8
      WriteLine($"number * Math.Pow(2,N) = { number * Math.Pow(2,N) }");
    }
    public static void divideByNthPowerOf2(int number, int N) {
      WriteLine($"number >> N = { number >> N }");
      // multiply a by 8
      WriteLine($"number / Math.Pow(2,N) = { number / Math.Pow(2,N) }");
    }
    public static void flipSignOf(int number) {
      var flippedSign = ~number + 1;
      WriteLine($"Before flipping { number }");
      // multiply a by 8
      WriteLine($"After flipping { flippedSign }");
    }
    static void Main(string[] args)
    {
      int a = 10; // 00001010
      int b = 6;  // 00000110

      WriteLine($"a = {b}");
      WriteLine($"a = {a}");
      WriteLine($"a & b = {a & b}"); // 2-bit column only
      WriteLine($"a | b = {a | b}"); // 8, 4, and 2-bit columns
      WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit columns

      WriteLine($"b >> 1 = {b >> 1}");

      WriteLine();
      WriteLine("Outputting integers as binary:");
      WriteLine($"a =     {ToBinaryString(a)}");
      WriteLine($"b =     {ToBinaryString(b)}");
      WriteLine($"a & b = {ToBinaryString(a & b)}");
      WriteLine($"a | b = {ToBinaryString(a | b)}");
      WriteLine($"a ^ b = {ToBinaryString(a ^ b)}");

      bool t = true,
            f = false;

      WriteLine($"true & false: { t & f }");
      WriteLine($"true | false: { t | f }");
      WriteLine($"true | true: { t | t }");
      WriteLine($"false & false: { f & f }");

      CheckPowerOf2(5);  CheckPowerOf2(8);
      MultiplyByNthPowerOf2(2,3);
      flipSignOf(-3);  flipSignOf(69);
      SetNthBit(1,5);
    }
  }
}