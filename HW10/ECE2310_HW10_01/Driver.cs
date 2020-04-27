using System;

namespace ECE2310_HW10_01
{
    class Driver
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            Console.WriteLine(stud);

            Student stud2 = new Student(12345, "mreeves", "mreeves@calpoly.edu", 3.67);
            Console.WriteLine(stud2);

            Undergrad ugrad = new Undergrad();
            ugrad.Year = 2;
            ugrad.Email = "snoopdogg@420.edu";
            ugrad.GPA = 4.20;
            ugrad.ID = 420;
            ugrad.Username = "Snoop";
            Console.WriteLine(ugrad);

            Grad grad = new Grad();
            grad.DegreeType = "BS";
            grad.GPA = 3.21;
            grad.Email = "tonystark@starkindustries.io";
            grad.ResearchTopic = "FPGA-accelerated Network Architecture";
            Console.WriteLine(grad);
        }
    }
}
