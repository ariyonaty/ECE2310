namespace ECE2310_HW10_01
{
    public class Undergrad : Student
    {
        private int _year = 1;

        public int Year
        {
            get => _year;
            set
            {
                if (value >= 1 && value <= 5)
                    _year = value;
            }
        }

        public Undergrad() { }

        public string Standing(int year)
        {
            string standing;
            switch (year)
            {
                case 1:
                    standing = "Freshman";
                    break;
                case 2:
                    standing = "Sophomore";
                    break;
                case 3:
                    standing = "Junior";
                    break;
                case 4:
                    standing = "Senior";
                    break;
                case 5:
                    standing = "Super Senior";
                    break;
                default:
                    standing = "Standing";
                    break;
            }
            return standing;
        }

        public override string ToString()
        {
            return ($"[+] Student Information:\n    ID: {ID.ToString("D5")}\n    Username: {Username}\n    Email: {Email}\n    GPA: {GPA:0.00}\n    Type: Undergrad\n    Academic Standing: {Standing(Year)}");
        }
    }
}