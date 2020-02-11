using System;

namespace ECE2310_HW01_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double miles, kilometers;

            Console.WriteLine("Enter Miles.");
            Console.Write("> ");
            userInput = Console.ReadLine();
            miles = Convert.ToDouble(userInput);
            kilometers = miles * 1.60934;

            Console.WriteLine("Miles: " + miles);
            Console.WriteLine("Kilometers: " + kilometers);
        }
    }
}
