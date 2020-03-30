using System;

namespace ECE2310_HW08_01
{
    public class Employee
    {
        private string _first = "First";
        private string _last = "Last";
        private int _employeeNum = 00000;
        private double _monthly = 0.00;
        public string FirstName
        {
            get => _first;
            set
            {
                _first = char.ToUpper(value[0]) + value.Substring(1);
            }
        }
        public string LastName
        {
            get => _last;
            set
            {
                _last = char.ToUpper(value[0]) + value.Substring(1);
            }
        }
        public int EmployeeNumber
        {
            get => _employeeNum;
            set
            {
                if (value > 0 && value < 99999)
                {
                    _employeeNum = Convert.ToInt32(value.ToString("D5"));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[-] Error. Employee {_first}'s ID must be 5 digits.");
                    Console.ResetColor();
                }
            }
        }
        public double MonthlySalary
        {
            get => _monthly;
            set
            {
                if (value > 0)
                {
                    _monthly = value;
                }
            }
        }

        public Employee() { }
        public Employee(string first, string last, int number, double monthly)
        {
            this.EmployeeNumber = number;
            this.FirstName = first;
            this.LastName = last;
            this.MonthlySalary = monthly;
        }
        public double annualPay()
        {
            return _monthly * 12;
        }
        public void employeeInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[+] Employee Information:");
            Console.ResetColor();
            Console.WriteLine($"--> First Name:\t\t{_first}");
            Console.WriteLine($"--> Last Name:\t\t{_last}");
            Console.WriteLine($"--> ID: \t\t#{_employeeNum:D5}");
            Console.WriteLine($"--> Monthly Salary: \t{_monthly:C2}");
            Console.WriteLine($"--> Annual Salary: \t{annualPay():C2}");
            Console.WriteLine("------------------------------------");
        }
    }
}