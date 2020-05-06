using System;

namespace FinalProject
{
    public class Pool
    {
        public Temperature Temperature { get; set; }
        public Location Location { get; set; }
        public static int Count { get; set; }
        public char Identifier { get; set; }

        public Pool()
        {
            this.Temperature = new Temperature();
            this.Location = new Location();
            Count++;
        }
        public Pool(Location location, char id)
        {
            this.Temperature = new Temperature();
            this.Location = location;
            this.Identifier = id;
            Count++;
        }
        public Pool(Temperature temperature, Location location, char id)
        {
            this.Temperature = temperature;
            this.Location = location;
            this.Identifier = id;
            Count++;
        }

        public static double GetDistance(Location l1, Location l2)
        {
            var (x1, y1) = l1.Position();
            var (x2, y2) = l2.Position();
            double distance = (Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            return Math.Round(distance, 2);
        }

        public override string ToString()
        {
            return ($"Pool {Identifier}: \t{Temperature}\t{Location}");
        }
    }
}