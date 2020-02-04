using System;

namespace LetterGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Letter Grade Calculator!");
            Console.WriteLine("------------------------");

            double grade = GetInput();

            ComputeInput(grade);
            
        }

        private static double GetInput()
        {
            Console.Write("Enter grade > ");
            double grade;
            
            // input validation. checks if input is double, makes sure it is in range of 0 and 100
            while (!double.TryParse(Console.ReadLine(), out grade) || grade > 100 || grade < 0)
            {
                Console.Write("Invalid input. Enter again > ");
            }
            
            return grade;
        }

        private static void ComputeInput(double grade)
        {
            // Conditionals testing diff grade ranges
            if (grade >= 90)
            {
                Console.WriteLine("Letter grade is 'A'!");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Letter grade is 'B'!");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Letter grade is 'C'!");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Letter grade is 'D'!");
            }
            else
            {
                Console.WriteLine("Letter grade is 'F'!");
            }
        }
    }
}
