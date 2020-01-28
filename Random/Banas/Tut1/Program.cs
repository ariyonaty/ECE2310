using System;

namespace Tut1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg {i} : {args[i]}");
            }

            string[] myArgs = Environment.GetCommandLineArgs();
            Console.WriteLine(string.Join(", ", myArgs));

            SayHello();

            Console.WriteLine($"Biggest Integer : {int.MaxValue}");
            Console.WriteLine($"Biggest Long : {long.MaxValue}");
            Console.WriteLine($"Biggest Decimal : {decimal.MaxValue}");
            Console.WriteLine($"Biggest Double : {double.MaxValue}");
            Console.WriteLine($"Biggest Float : {float.MaxValue}");

        }

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");
        }
    }
}
