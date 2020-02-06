using System;

namespace ECE2310_HW02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 5 digit number: ");
            int input = Int32.Parse(Console.ReadLine());

            int n1, n2, n3, n4, n5;
            n5 = (input % 10);
            n4 = (input % 100) / 10;
            n3 = (input % 1000) / 100;
            n2 = (input % 10000) / 1000;
            n1 = (input % 100000) / 10000;

            Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");

        }
    }
}
