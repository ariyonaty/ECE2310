using System;

namespace ECE2310_HW04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();

            double startMoney = 1000;
            int startAge = 20;

            double john = startMoney;
            double linda = startMoney;
        }
        private static void menu()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("                 Investing vs Saving                 ");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Age      Linda's Account         John's Account      ");
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
