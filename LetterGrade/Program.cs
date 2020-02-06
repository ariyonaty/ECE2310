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
            char letterGrade;
            // Conditionals testing diff grade ranges
            if (grade >= 90)
            {
                letterGrade = 'A';
                Console.WriteLine($"Letter grade is {letterGrade}!");
            }
            else if (grade >= 80)
            {
                letterGrade = 'B';
                Console.WriteLine($"Letter grade is {letterGrade}!");
            }
            else if (grade >= 70)
            {
                letterGrade = 'C';
                Console.WriteLine($"Letter grade is {letterGrade}!");
            }
            else if (grade >= 60)
            {
                letterGrade = 'D';
                Console.WriteLine($"Letter grade is {letterGrade}!");
            }
            else
            {
                letterGrade = 'F';
                Console.WriteLine($"Letter grade is {letterGrade}!");
            }

            outputMessage(letterGrade);
        }

        public static void outputMessage(char letter)
        {
            switch (letter)
            {
                case 'A':
                    Console.WriteLine("Awesome job!");
                    break;
                case 'B':
                    Console.WriteLine("Well done.");
                    break;
                case 'C':
                    Console.WriteLine("Satisfactory.");
                    break;
                case 'D':
                    Console.WriteLine("Poor Performance.");
                    break;
                case 'F':
                    Console.WriteLine("You failed!");
                    break;
            }
        }
    }
}
