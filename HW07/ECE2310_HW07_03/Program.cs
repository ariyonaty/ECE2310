using System;

namespace ECE2310_HW07_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("|            Net Pay Calculator            |");
            Console.WriteLine(" ------------------------------------------");

            bool again = false;

            do
            {
                Console.Write("Employee Name? ");
                string name = Console.ReadLine();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[+] Employee Name: {name}");
                Console.ResetColor();
                Console.Write("Employee Weekly Sales? $");
                double sales = input();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[+] Weekly Salary: {sales:C2}");
                Console.ResetColor();
                Console.WriteLine(" ------------------------------------------");
                Console.Write("Determine net? (y/n) ");
                if (Console.ReadLine() == "y")
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.WriteLine(" ------------------------------------------");
                    calculate(sales);
                }
                else
                {
                    Console.WriteLine(" ------------------------------------------");
                    Console.WriteLine("Goodbye.");
                    Environment.Exit(0);
                }
                Console.WriteLine(" ------------------------------------------");
                Console.Write("Again? (y/n) ");
                char againInput = Convert.ToChar(Console.ReadLine());
                if (againInput == 'y')
                {
                    again = true;
                }
                else
                {
                    Console.WriteLine(" ------------------------------------------");
                    Console.WriteLine("Goodbye.");
                    Environment.Exit(0);
                }
            } while (again);

        }

        static double input()
        {
            double input = 0;
            while (!Double.TryParse(Console.ReadLine(), out input) || input < 0)
            {
                Console.Write("[-] Invalid Input. Try again > ");
            }
            return input;
        }

        static void calculate(double sales)
        {
            double net;
            double deducFed, deducRet, deducSoc;

            double federalTax = 0.18;
            double retirementCont = 0.15;
            double socialSec = 0.09;

            deducFed = Math.Round(sales * federalTax, 2);
            deducRet = Math.Round(sales * retirementCont, 2);
            deducSoc = Math.Round(sales * socialSec, 2);

            net = sales - deducFed - deducRet - deducSoc;
            display(deducFed, deducRet, deducSoc, net);
        }
        static void display(double deducFed, double deducRet, double deducSoc, double net)
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.WriteLine("[+] Deductions: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"- Federal Tax (18%)             >  {deducFed:C2}");
            Console.WriteLine($"- Retirement Contribution (15%) >  {deducRet:C2}");
            Console.WriteLine($"- Social Security (9%)          >  {deducSoc:C2}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"---> Net Pay                    >  {net:C2}");
            Console.ResetColor();
        }
    }
}
