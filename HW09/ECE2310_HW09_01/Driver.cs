using System;

namespace ECE2310_HW09_01
{
    class Driver
    {
        static void Main(string[] args)
        {
            /* Demoing the defaults */
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> Testing Defaults");
            Console.ResetColor();
            Grocery myGroceries = new Grocery();
            Console.WriteLine(myGroceries);
            Console.WriteLine();

            /* Demoing modifying item within Grocery Class */
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> Modifying defaults from Grocery");
            Console.ResetColor();
            Grocery myGroceries2 = new Grocery();
            myGroceries2.MyEggs.UnitPrice = 2.99;
            myGroceries2.MyEggs.Quantity = 5;
            Console.WriteLine(myGroceries2);
            Console.WriteLine();

            /* Demoing creating individual obj of produce classes and passing as param to Grocery */
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> Creating indiv item obj and passing to Grocery");
            Console.ResetColor();
            Eggs kirklandEggs = new Eggs();
            kirklandEggs.Quantity = 24;
            kirklandEggs.UnitPrice = 1.50;
            Milk kirklandMilk = new Milk();
            Bread kirklandBread = new Bread();
            Grocery myGroceries3 = new Grocery(kirklandEggs, kirklandMilk, kirklandBread);
            Console.WriteLine(myGroceries3);
            Console.WriteLine();
        }
    }
}

