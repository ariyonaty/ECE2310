using System;

namespace ECE2310_HW07_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[26];

            Console.WriteLine("------------------------------");
            Console.WriteLine("|       Grading System       |");
            Console.WriteLine("------------------------------");
            Console.WriteLine("[+] Please enter grades...");
            for (int i = 1; i <= myArr.Length; i++)
            {
                Console.Write($"Student #{i}: ");
                myArr[i - 1] = inputValidation();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }
            Console.WriteLine("[+] Done entering grades...");
            Console.WriteLine("------------------------------");

            bool earned100 = false;
            for (int i = 0; i < myArr.Length; i++)
            {
                if (search(myArr, 100) == i)
                {
                    earned100 = true;
                    Console.WriteLine($"Student #{i + 1} earned 100%");
                    myArr[i] = 0;
                }
            }
            if (earned100 == false)
            {
                Console.WriteLine("No student earned 100%");
            }
        }

        static int search(int[] array, int key)
        {
            return Array.IndexOf(array, key);
        }

        static int inputValidation()
        {
            int grade;
            while (!Int32.TryParse(Console.ReadLine(), out grade) || grade > 100 || grade < 0)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write("[-] Invalid input (0-100), try again: ");
            }
            return grade;
        }
    }
}