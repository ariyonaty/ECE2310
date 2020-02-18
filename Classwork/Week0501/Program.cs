using System;

namespace Week0501
{
    class Program
    {
        static void Main(string[] args)
        {
            accumulator(100, '+');
            accumulator(15, '*');
            accumulator(15, '^');

            Console.WriteLine();

            double moneyIn = 5000;
            int years = 10;

            double quarterly = moneyIn;
            double yearly = moneyIn;
            for (int i = 1; i <= years * 4; i++)
            {
                quarterly += quarterly * 0.005;                    
            }
            for (int i = 1; i <= years; i++)
            {
                yearly += yearly * 0.02;
            }

            Console.WriteLine($"Investment balance after {years} year.");
            Console.WriteLine($"Yearly investment balance: {yearly:C2}");
            Console.WriteLine($"Quarterly investment balance: {quarterly:C2}");

        }

        private static void accumulator(int n, char operation)
        {
            long t = 1;
            double x = 2;

            switch (operation)
            {
                case '+':
                    Console.WriteLine("Addition");
                    for (int i = 1; i <= n; i++)
                    {
                        t += i;
                    }
                    Console.WriteLine($"T = {t}");
                    break;
                case '*':
                    Console.WriteLine("Factorial");
                    for (int i = 1; i <= n; i++)
                    {
                        t *= i;
                    }
                    Console.WriteLine($"{n}! = {t}");
                    break;
                case '^':
                    Console.WriteLine("Power");
                    for (int i = 1; i < n; i++)
                    {
                       x *= 2;
                    }
                    Console.WriteLine($"2^{n} = {x}");
                    break;
            }
        }


    }
}
