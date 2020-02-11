﻿using System;

namespace ECE2310_HW03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();

            int selection;

            while (!Int32.TryParse(Console.ReadLine(), out selection) || selection <= 0 || selection > 3)
            {
                Console.Write("Input must be number. Try again > ");
            }

            switch (selection)
            {
                case 1:
                    areaCircle();
                    break;
                
                case 2:
                    areaRectangle();
                    break;

                case 3:
                    areaCylinder();
                    break;
            }

        }

        private static void menu()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("\tArea Calculator");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Calculate area of?");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Cylinder");
            Console.Write("Enter shape (1, 2, 3) > ");
        }

        private static void areaCircle()
        {
            Console.Write("Enter circle radius > ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.Round(Math.PI * radius * radius, 3);

            Console.WriteLine($"Area of circle is {area} units squared.");
        }

        private static void areaRectangle()
        {
            Console.Write("Enter length > ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width > ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = Math.Round(length * width, 3);

            Console.WriteLine($"Area of rectangle is {area} units squared.");
        }

        private static void areaCylinder()
        {
            Console.Write("Enter radius > ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height > ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = Math.Round((2 * Math.PI * radius * height) + (2 * Math.PI * radius * radius), 3);

            Console.WriteLine($"Area of cylinder is {area} units squared.");
        }
    }
}