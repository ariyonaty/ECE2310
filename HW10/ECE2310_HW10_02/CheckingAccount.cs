using System;

namespace ECE2310_HW10_02
{
    public class CheckingAccount : BankAccount
    {
        private double _credit = 0;
        private double _creditLimit = 1000;

        public double Credit
        {
            get => _credit;
            set
            {
                if (value > Balance)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[-] Credit charge {value:C2} is more than account balance.");
                    Console.ResetColor();
                }
                else if (value > _creditLimit)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[-] Credit charge limit is {_creditLimit:C2}");
                    Console.WriteLine($"    Credit charge of {value:C2} not complete.");
                    Console.ResetColor();
                }
                else
                {
                    _credit = value;
                }
            }
        }

        public CheckingAccount() { }

        public void PayCredit()
        {
            Balance -= Credit;
            Credit = 0;
        }
        public void PayCredit(double amount)
        {
            Balance -= amount;
            Credit -= amount;
        }
        public void ChargeCredit(double amount)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[+] Attempting to charge credit {amount:C2}.");
            Console.ResetColor();
            Credit += amount;
        }

        public override string ToString()
        {
            return ($"[+] Account Information:\n    Name: {LastName}, {FirstName}\n    Account Type: Checking\n    Account Number: {AccountNumber.ToString("D5")}\n    Balance: {Balance:C2}\n    Credit Due: {Credit:C2}\n********************************");
        }
    }
}