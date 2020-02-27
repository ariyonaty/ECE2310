using System;

namespace Week0601
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];
            int[] index = new int[6];

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
            Console.Write("Find what number ? ");
            int num = Convert.ToInt32(Console.ReadLine());
            a[1] = 80;
            findIndex(a, index, num);

            // printArray(a);
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

        private static void findIndex(int[] array, int[] index, int number)
        {
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    index[j] = i;
                    j++;
                }
            }
            printArray(array);
            Console.WriteLine("Number found at index(s): ");
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine($"{index[i]}");
            }
        }
    }
}
