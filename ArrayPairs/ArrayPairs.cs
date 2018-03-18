using System;

namespace ArrayPairs
{
    public class ArrayPairs
    {
        public static void PrintPairSums(int[] array, int sum)
        {
            Array.Sort(array);
            var first = 0;
            var last = array.Length - 1;
            while (first < last)
            {
                var s = array[first] + array[last];
                if (s == sum)
                {
                    Console.WriteLine($"{array[first]}  {array[last]}");
                    first++;
                    last--;
                }
                else
                {
                    if (s < sum)
                    {
                        first++;
                    }
                    else
                    {
                        last--;
                    }
                }
            }
        }
    }
}
