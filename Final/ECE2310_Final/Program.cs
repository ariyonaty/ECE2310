using System;

namespace ECE2310_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphObject[] objects = new GraphObject[4];
            objects[0] = new RightTriangle(6, 8);
            objects[1] = new Square(8);
            objects[2] = new RightTriangle(5, 15);
            objects[3] = new Square(7);

            double[] areas = new double[4];
            double[] perimeters = new double[4];

            Console.WriteLine("[+] Displaying shape information.");
            for (int i = 0; i < objects.Length; ++i)
            {
                objects[i].CalArea();
                objects[i].CalPerimeter();
                areas[i] = objects[i].CalArea();
                perimeters[i] = objects[i].CalPerimeter();
                Console.WriteLine($"Object #{i + 1}: {objects[i]}");
            }
            Console.WriteLine("--------------");
            Console.Write($"Largest Area: Object #");
            Utilities.FindLargest(areas);
            Console.Write($"Largest Perimeter: Object #");
            Utilities.FindLargest(perimeters);
            Console.WriteLine("--------------");
        }
    }
}
