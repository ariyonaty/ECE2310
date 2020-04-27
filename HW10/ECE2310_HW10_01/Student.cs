using System;

namespace ECE2310_HW10_01
{
    public class Student
    {
        private int _id = 0;
        private string _username = "student";
        private string _email = "student@school.edu";
        private double _gpa = 0.00;

        public int ID
        {
            get => _id;
            set
            {
                if (value > 0)
                    _id = value;
            }
        }
        public string Username
        {
            get => _username;
            set => _username = value;
        }
        public string Email
        {
            get => _email;
            set
            {
                if (!(value.Contains('@')))
                {
                    Console.WriteLine("Email not valid.");
                    Environment.Exit(1);
                }
                _email = value;
            }
        }
        public double GPA
        {
            get => _gpa;
            set
            {
                if (value > 0 && value <= 4)
                    _gpa = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[-] GPA not between 0 and 4");
                    Console.ResetColor();
                }
            }
        }

        public Student() { }
        public Student(int id, string username, string email, double gpa)
        {
            this.ID = id;
            this.Username = username;
            this.Email = email;
            this.GPA = gpa;
        }

        public override string ToString()
        {
            return ($"[+] Student Information:\n    ID: {ID.ToString("D5")}\n    Username: {Username}\n    Email: {Email}\n    GPA: {GPA:0.00}");
        }
    }
}