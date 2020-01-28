using System;

namespace Week0101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // prompt user for name
            Console.Write("What is your name? ");
            // accept input from name
            string name = Console.ReadLine();
            // display name to console
            Console.WriteLine("Hello, " + name + "!");
         
            // Convert faren to celsius
            Console.Write("What is the temp in Farenheit? ");
            double tempF = Convert.ToDouble(Console.ReadLine());
            double tempC = (tempF - 32) * 5 / 9;
            Console.WriteLine($"{tempF} F* is {Math.Round(tempC, 1)} C*");

        }
    }
}
