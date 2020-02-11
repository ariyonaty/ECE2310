using System;

namespace ECE2310_HW03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();

            double grade; 
            while(!Double.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid input. Quitting...");
                return;
            }

            switch (grade)
            {
                case double n when (n >= 90):
                    Console.WriteLine("Grade letter: A");
                    break;
                case double n when (n < 90 && n >= 80):
                    Console.WriteLine("Grade letter: B");
                    break;
                case double n when (n < 80 && n >= 70):
                    Console.WriteLine("Grade letter: C");
                    break;
                case double n when (n < 70 && n >= 60):
                    Console.WriteLine("Grade letter: D");
                    break;
                case double n when (n < 60):
                    Console.WriteLine("Grade letter: F");
                    break;
            }

        }

        private static void menu()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("\tGrade Letter");
            Console.WriteLine("--------------------------------");
            Console.Write("Enter your grade > ");
        }

    }
}
