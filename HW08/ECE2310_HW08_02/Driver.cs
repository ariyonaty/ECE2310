using System;

namespace ECE2310_HW08_02
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("          | Net Pay Calculator |");
            Console.WriteLine(" ------------------------------------------");

            bool again = false;

            do
            {
                Console.Write("Employee Full Name? ");
                string name = Console.ReadLine();
                string[] nameSep = name.Split(' ');
                Console.Write("Employee ID? #");
                int employeeID;
                while (!Int32.TryParse(Console.ReadLine(), out employeeID) || employeeID < 0 || employeeID > 99999)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[-] Error! ID must be 5 digit number.");
                    Console.ResetColor();
                    Console.Write("Try again > ");
                }
                double sales;
                Console.Write("Total Sales? $");
                while (!Double.TryParse(Console.ReadLine(), out sales) || sales < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Sales must be positive number.");
                    Console.ResetColor();
                    Console.Write("Try again > ");
                }
                Employee emp = new Employee(nameSep[0], nameSep[nameSep.Length - 1], employeeID, sales);
                emp.CalculateDeductions();
                Console.Write("Again? (y/n) ");
                char againInput = Convert.ToChar(Console.ReadLine());
                if (againInput == 'y')
                {
                    again = true;
                    Console.WriteLine("------------------------------------");
                }
                else
                {
                    again = false;
                    Console.WriteLine("Goodbye.");
                    Environment.Exit(0);
                }
            } while (again);
        }
    }
}
