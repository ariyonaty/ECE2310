using System;

namespace Week0601
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];

            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    a[i] = (i + 1) * 10;
                }
                else
                {
                    a[i] = (i + 1) * 10 * 2;
                }
                sum += a[i];
                
            }
            printArray(a);
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {sum / a.Length}");
        }

        private static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Index {i} ; Value = {array[i]}");
            }
        }
    }
}
