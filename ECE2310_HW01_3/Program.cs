/* 
    Ari Yonaty
    1.21.2020
    ECE2310
    HW 1, Problem 3
 */

using System;

namespace ECE2310_HW01_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double homework, projects, quizzes, exams, final;
            double percentHW = 0.1, percentProj = 0.25, percentQuiz = 0.2, percentExam = 0.2, percentFinal = 0.25;
            double overallGrade;

            Console.WriteLine("------------------------");
            Console.WriteLine("+++ Grade Calculator +++");
            Console.WriteLine("------------------------");

            // Get homework
            Console.Write("Enter HW (10%)    > ");
            userInput = Console.ReadLine();
            homework = Convert.ToDouble(userInput);

            // Get projects
            Console.Write("Enter Proj (25%)  > ");
            userInput = Console.ReadLine();
            projects = Convert.ToDouble(userInput);

            // Get quizzes
            Console.Write("Enter Quiz (20%)  > ");
            userInput = Console.ReadLine();
            quizzes = Convert.ToDouble(userInput);

            // Get exams
            Console.Write("Enter Exam (20%)  > ");
            userInput = Console.ReadLine();
            exams = Convert.ToDouble(userInput);

            // Get final
            Console.Write("Enter Final (25%) > ");
            userInput = Console.ReadLine();
            final = Convert.ToDouble(userInput);

            // Calculate overall grade
            overallGrade = (((homework * percentHW) + (projects * percentProj) + (quizzes * percentQuiz) + (exams * percentExam) + (final * percentFinal)) / (percentHW + percentProj + percentQuiz + percentExam + percentFinal));

            Console.WriteLine("------------------------");
            Console.WriteLine("Total Grade: " + string.Format("{0:0.0}", overallGrade));
            Console.WriteLine("------------------------");

        }
    }
}
