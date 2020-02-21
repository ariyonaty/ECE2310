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
            int age = startAge;

            double linda = startMoney;
            double john = startMoney;

            double lindaRate = 0.06;
            double johnRate = 0.015;

            for (int i = 20; i <= 60; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine($"{age,-13}{linda,-24:C2}{john,-10:C2}");
                    age += 10;
                }

                linda += linda * lindaRate;
                john += john * johnRate;
            }
        }

        private static void menu()
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("                       Investing vs Saving                       ");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Age          Linda's Account         John's Account              ");
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}
