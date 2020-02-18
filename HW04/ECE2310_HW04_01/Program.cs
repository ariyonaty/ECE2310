using System;

namespace ECE2310_HW04_01
{
    class Program
    {
        private static int[] fib(int n)
        {
            int[] fibonacci = new int[n];
            fibonacci[0] = 1;
            fibonacci[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            }

            return fibonacci;
        }
        static void Main(string[] args)
        {
            int[] fibonacci = fib(30);

            int count = 0;


            Console.WriteLine("-----------FIBONACCI NUMBERS-----------");
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{fibonacci[count]}\t ");
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}

