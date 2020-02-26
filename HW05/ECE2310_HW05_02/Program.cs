using System;

namespace ECE2310_HW05_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[26];
            int[] grades = new int[26];

            int sum = 0;
            int max = 0;
            int avgCount = 0;
            int maxIndex = 0;

            Console.WriteLine("*****************************");
            Console.WriteLine("     Class Grade System");
            Console.WriteLine("*****************************");

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter name > ");
                names[i] = Console.ReadLine();

                Console.Write("Enter grade > ");
                while (!Int32.TryParse(Console.ReadLine(), out grades[i]) || grades[i] > 100 || grades[i] < 0)
                {
                    Console.Write("Invalid input. Try again > ");
                }
                sum += grades[i];
                if (grades[i] > max)
                {
                    max = grades[i];
                }
            }

            Console.WriteLine("*****************************");
            Console.WriteLine("Grade            Score");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i],-16} {grades[i],-13}");
            }

            maxIndex = Array.IndexOf(grades, max);
            int avg = sum / grades.Length;

            Console.WriteLine("*****************************");
            Console.WriteLine($"{names[maxIndex]} has the highest grade, {max}, in class.");
            Console.WriteLine($"Average class grade is {avg}");

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] > avg)
                {
                    avgCount++;
                }
            }

            Console.WriteLine($"{avgCount} students are above average score.");
        }
    }
}