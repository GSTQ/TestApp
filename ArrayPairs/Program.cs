using System;

namespace ArrayPairs
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("All pairs for (1, 1, 2, 1, 1, 0, 1), sum = 2");
            ArrayPairs.PrintPairSums(new int[] { 1, 1, 2, 1, 1, 0, 1 }, 2);
            Console.WriteLine("All pairs for (1, 1, 2, 1, 1, 0, 1), sum = 3");
            ArrayPairs.PrintPairSums(new int[] { 1, 1, 2, 1, 1, 0, 1 }, 3);
            Console.WriteLine("All pairs for (1, 1, 2, 3, 4, 2, 1, 0), sum = 4");
            ArrayPairs.PrintPairSums(new int[] { 1, 1, 2, 3, 4, 2, 1, 0 }, 4);
            Console.ReadKey();
        }
    }
}
