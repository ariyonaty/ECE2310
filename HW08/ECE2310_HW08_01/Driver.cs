using System;

namespace ECE2310_HW08_01
{
    class Driver
    {
        static void Main(string[] args)
        {
            Employee matt = new Employee();
            Employee michael = new Employee("michael", "reeves", 12345, 6000);

            matt.FirstName = "matt";
            matt.LastName = "damon";
            matt.EmployeeNumber = 1337;
            matt.MonthlySalary = 4500.00;

            matt.employeeInfo();
            michael.employeeInfo();
        }
    }
}
