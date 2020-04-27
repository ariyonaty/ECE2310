using System;

namespace ECE2310_HW10_01
{
    public class Grad : Student
    {
        private string _researchTopic = "Topic";
        private string _degreeType = "Type";
        public string ResearchTopic
        {
            get => _researchTopic;
            set => _researchTopic = value;
        }
        public string DegreeType
        {
            get => _degreeType;
            set
            {
                bool valid = value.Equals("BS") || value.Equals("BA");
                if (valid == false)
                {
                    Console.WriteLine("Error. Degree type must be either 'BA' or 'BS'.");
                    Environment.Exit(1);
                }
                _degreeType = value;
            }
        }

        public Grad() { }

        public override string ToString()
        {
            return ($"[+] Student Information:\n    ID: {ID.ToString("D5")}\n    Username: {Username}\n    Email: {Email}\n    GPA: {GPA:0.00}\n    Type: Graduate\n    Degree: {DegreeType}\n    Research: {ResearchTopic}");
        }
    }
}