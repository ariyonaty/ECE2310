using System;

namespace ECE2310_HW07_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseN = 2;
            int power = 10;
            int sum = 1;

            Console.WriteLine(" --------------------------");
            Console.WriteLine("|      Sigma & Power       |");
            Console.WriteLine(" --------------------------");

            Console.WriteLine("[+] Calculating :");
            Console.Write($"> {sum}");
            for (int i = 1; i <= power; i++)
            {
                sum += integerPower(baseN, i);
                Console.Write($" + {integerPower(baseN, i)}");
            }
            Console.WriteLine($" = {sum}");
            Console.WriteLine(" --------------------------");
            Console.WriteLine("Goodbye.");
        }

        static int integerPower(int baseN, int exponent)
        {
            // baseN ^ exponent
            int res = 1;

            for (int i = 0; i < exponent; i++)
            {
                res = res * baseN;

            }

            return res;
        }
    }
}
