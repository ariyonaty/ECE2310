using System;

namespace ECE2310_HW10_02
{
    public abstract class BankAccount
    {
        private string _firstName = "First";
        private string _lastName = "Last";
        private uint _accountNumber = 0;
        private double _balance = 0.00;

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
        public uint AccountNumber
        {
            get => _accountNumber;
            set => _accountNumber = value;
        }
        public double Balance
        {
            get => _balance;
            set => _balance = value;
        }

        public BankAccount() { }

        public void Deposit(double amount)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[+] Attempting to deposit {amount:C2}.");
            Console.ResetColor();
            Balance += amount;
        }
        public virtual void Withdraw(double amount)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[+] Attempting to withdraw {amount:C2}.");
            Console.ResetColor();
            if (Balance < amount)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[-] Not enough balance to withdraw {amount:C2}.");
                Console.ResetColor();
            }
            else
            {
                Balance -= amount;
            }
        }

        public override string ToString()
        {
            return ($"[+] Account Information:\n    Name: {LastName}, {FirstName}\n    Account Number: {AccountNumber.ToString("D5")}\n    Balance: {Balance:C2}");
        }
    }
}