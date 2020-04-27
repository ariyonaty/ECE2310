using System;

namespace ECE2310_HW10_01
{
    class Driver
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student);

            Student student2 = new Student(12345, "mreeves", "mreeves@calpoly.edu", 3.67);
            Console.WriteLine(student2);

            Undergrad ugrad = new Undergrad();
            ugrad.Year = 2;
            ugrad.Email = "jackdaniels@harvard.edu";
            ugrad.GPA = 3.98;
            ugrad.ID = 14562;
            ugrad.Username = "jdaniels";
            Console.WriteLine(ugrad);

            Grad grad = new Grad();
            grad.ID = 57752;
            grad.Username = "tstark";
            grad.DegreeType = "BS";
            grad.GPA = 3.21;
            grad.Email = "tonystark@starkindustries.io";
            grad.ResearchTopic = "FPGA-accelerated Network Architecture";
            Console.WriteLine(grad);
        }
    }
}
