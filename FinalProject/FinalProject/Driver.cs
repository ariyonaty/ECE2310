using System;
using System.Collections.Generic;

namespace FinalProject
{
    class Driver
    {
        static void Main(string[] args)
        {
            Header();

            // Setup list containing all 7 pools from handout
            Message("Instantiating pools.", ConsoleColor.Green);
            List<Pool> myPools = new List<Pool>();
            myPools.Add(new Pool(new Location(4, 8), 'A'));
            myPools.Add(new Pool(new Location(1, 3), 'B'));
            myPools.Add(new Pool(new Location(4, 2), 'C'));
            myPools.Add(new Pool(new Location(13, 1), 'D'));
            myPools.Add(new Pool(new Location(12, 9), 'E'));
            myPools.Add(new Pool(new Location(10, 5), 'F'));
            myPools.Add(new Pool(new Location(6, 6), 'G'));
            Pool closestPool = myPools[0];
            Message("Done instantiating pools.\n", ConsoleColor.Green);

            // Write out all pools in list
            Message("Listing all pools on map.", ConsoleColor.Green);
            foreach (Pool pool in myPools)
            {
                Console.WriteLine(pool);
            }

            /* 
                Choose coordinate for start location. 
                Set start location to current location (which changes)
                Create two lists, unvisited pools; visitied pools.
                Initialize all poools as unvisited.
                Find shortest path from start/current location to unvisited pool
                Remove that pool from unvisited, add to visited, and set as current location
                Repeat until there are no more pools in unvisited pools. 
            */
            Location startLocation = new Location(0, 0);
            Location currentLocation = startLocation;
            List<Pool> unvisitedPools = new List<Pool>(myPools);
            List<Pool> visitedPools = new List<Pool>();
            double minDistance;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n[+] Determining pool visit path route...");
            while (unvisitedPools.Count > 0)
            {
                minDistance = 100;
                foreach (Pool pool in unvisitedPools)
                {
                    double dist = Pool.GetDistance(currentLocation, pool.Location);
                    if (dist <= minDistance)
                    {
                        minDistance = dist;
                        closestPool = pool;
                    }
                }
                currentLocation = closestPool.Location;
                unvisitedPools.Remove(closestPool);
                visitedPools.Add(closestPool);
            }
            Console.WriteLine("[+] Determined optimal path route.");
            Console.WriteLine("[+] Maintenance on route and changing temp...");
            Console.WriteLine("[+] Maintenance will take route:");
            Console.ResetColor();
            Console.Write($"Start" + startLocation.Position());
            Random rand = new Random();
            foreach (Pool pool in visitedPools)
            {
                pool.Temperature.Degree = rand.Next(98, 104) + Math.Round(rand.NextDouble(), 1);
                Console.Write(" → " + pool.Identifier);
            }

            // Output pool in order of visits with altered temperature
            Console.WriteLine(); Console.WriteLine();
            Message("Updated pool map after maintenance visit.", ConsoleColor.Green);
            foreach (Pool pool in visitedPools)
            {
                Console.WriteLine(pool);
            }

        }

        public static void Message(string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"[+] {msg}");
            Console.ResetColor();
        }
        public static void Header()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("|           FINAL PROJECT           |");
            Console.WriteLine("-------------------------------------");
        }
    }
}

