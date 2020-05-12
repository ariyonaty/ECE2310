using System;
using System.Linq;

namespace ECE2310_Final
{
    public static class Utilities
    {
        public static void FindLargest(double[] array)
        {
            double maxValue = array.Max();
            int maxIndex = array.ToList().IndexOf(maxValue);
            Console.WriteLine($"{maxIndex + 1 } has largest value of {Math.Round(maxValue, 2)}");
        }
    }
}