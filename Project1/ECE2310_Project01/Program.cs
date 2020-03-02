using System;

namespace ECE2310_Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int guess;
            bool play = true;

            menu();

            while (play == true)
            {
                int number = rand.Next(1, 101);

                guess = getInput();

                while (guess != number)
                {
                    if (guess > number)
                    {
                        Console.WriteLine("Number too big!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("Number too small!");
                    }
                    guess = getInput();
                }
                Console.WriteLine($"Congrats! {guess} was the right guess!");

                play = false;
                Console.Write("Do you want to play again? (y/n): ");
                string choice = Convert.ToString(Console.ReadLine()).ToLower();
                if (choice == "y")
                {
                    play = true;
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Generating new random number.....");
                }
                else
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Thank you for playing! Goodbye!");
                }
            }
        }

        private static void menu()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("         Guess the Number!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Instructions: Guess for the number\nbetween 1 and 100.\nMost importantly, have fun!\nReady, set, go!");
            Console.WriteLine("---------------------------------");
        }

        private static int getInput()
        {
            int guess;
            Console.Write("Guess a number > ");
            while (!Int32.TryParse(Console.ReadLine(), out guess) || guess > 100 || guess < 1)
            {
                Console.WriteLine("Input must be number between 1 and 100.");
                Console.Write("Try again > ");
            }
            return guess;
        }
    }
}
