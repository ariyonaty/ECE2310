using System;

namespace ECE2310_HW10_02
{
    class Driver
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            CheckingAccount defaultCA = new CheckingAccount();
            SavingsAccount defaultSA = new SavingsAccount();

            // Showing the defaults.
            Console.WriteLine(defaultCA);
            Console.WriteLine(defaultSA);

            // Showing the 
            CheckingAccount ca = new CheckingAccount();
            ca.FirstName = "Anthony";
            ca.LastName = "Jeselnik";
            ca.AccountNumber = (uint)rand.Next(10000, 100000);
            ca.Balance = 50000;
            ca.Withdraw(75000);         // yields error
            ca.Withdraw(10000);
            ca.Deposit(1500);
            ca.ChargeCredit(2500);      // yields error
            ca.ChargeCredit(1000);
            ca.PayCredit(500);
            ca.PayCredit();
            ca.Withdraw(1500);
            Console.WriteLine(ca);

            SavingsAccount sa = new SavingsAccount();
            sa.FirstName = "Ned";
            sa.LastName = "Fitzgerald";
            sa.AccountNumber = (uint)rand.Next(10000, 100000);
            sa.Balance = (double)rand.Next(25000, 50000);
            sa.Withdraw(100);
            sa.Withdraw(200);
            sa.Withdraw(300);
            sa.Withdraw(400);
            sa.applyInterest(); // actual case would have boolean true annualy
            Console.WriteLine(sa);
        }
    }
}

