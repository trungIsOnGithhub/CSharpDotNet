using static System.Console;

namespace Chapter3
{
    class Operator
    {
        // Need improve with LinQ
        static Int32 FindOutlier(Int32[] array)
        {
            Int32 countEven = 0,
                    countOdd = 0;
            bool oddEncountered = false,
                    evenEncountered = false;
            Int32 lastOddEncountered = -1,
                    lastEvenEncountered = -1;

            for(var index = 0; index < array.Length; ++index)
            {
                if(array[index] % 2 == 0)
                {
                    ++countEven;

                    evenEncountered = true;
                    lastEvenEncountered = array[index];
                }
                else
                {
                    ++countOdd;
                
                    oddEncountered = true;
                    lastOddEncountered = array[index];
                }

                if(countEven > 1 && oddEncountered)
                {
                    break;
                }

                if(countOdd > 1 && evenEncountered)
                {
                    break;
                }
            }

            return (countEven > 1) ? lastOddEncountered : lastEvenEncountered;
        }
         public static void Main(string[] args)
        {
            // length must be at least 3
            Int32[] array = new[] { 12, 12, 12, 11, 8, 8, 8 };

            WriteLine($"The outlier from previous Array: {FindOutlier(array)}");
        }
    }
}