using System;

namespace ECE2310_HW10_02
{
    public class SavingsAccount : BankAccount
    {
        private int _withdrawCount = 3;
        private double _withdrawLimit = 1000.00;
        private double _interestRate = 0.002;

        public int WithdrawCount
        {
            get => _withdrawCount;
            set => _withdrawCount = value;
        }
        public double WithdrawLimit
        {
            get => _withdrawLimit;
            set => _withdrawLimit = value;
        }
        public double InterestRate
        {
            get => _interestRate;
            set => _interestRate = value;
        }

        public SavingsAccount() { }

        public void applyInterest()
        {
            Balance += Balance * InterestRate;
        }
        public override void Withdraw(double amount)
        {
            if (WithdrawCount == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[-] Exceeded monthly withdrawal count of {WithdrawCount}.");
                Console.ResetColor();
            }
            else
            {
                base.Withdraw(amount);
                WithdrawCount--;
            }

        }

        public override string ToString()
        {
            return ($"[+] Account Information:\n    Name: {LastName}, {FirstName}\n    Account Type: Savings\n    Account Number: {AccountNumber.ToString("D5")}\n    Balance: {Balance:C2}\n    Interest Rate: {InterestRate * 100}%\n    Withdrawal Limit: {WithdrawLimit:C2}\n    Withdrawal Count: {WithdrawCount}\n********************************");
        }

    }
}