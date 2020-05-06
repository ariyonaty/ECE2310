using System;
using System.Threading;
using System.Collections.Generic;

namespace FinalProject
{
    class Driver
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            List<Pool> myPools = new List<Pool>();
            myPools.Add(new Pool(new Location(4, 8), 'A'));
            myPools.Add(new Pool(new Location(1, 3), 'B'));
            myPools.Add(new Pool(new Location(4, 2), 'C'));
            myPools.Add(new Pool(new Location(13, 1), 'D'));
            myPools.Add(new Pool(new Location(12, 9), 'E'));
            myPools.Add(new Pool(new Location(10, 5), 'F'));
            myPools.Add(new Pool(new Location(6, 6), 'G'));
            Console.WriteLine("List of all Pools.");
            foreach (Pool pool in myPools)
            {
                Console.WriteLine(pool);
            }
            Console.WriteLine("********************");

            Location startLocation = new Location(0, 0);
            Location currentLocation = startLocation;

            List<Pool> unvisitedPools = new List<Pool>(myPools);
            List<Pool> visitedPools = new List<Pool>();

            double min; //= Pool.GetDistance(currentLocation, unvisitedPools[0].Location);
            Pool minPool = new Pool();

            while (unvisitedPools.Count > 0)
            {
                min = 100;
                foreach (Pool pool in unvisitedPools)
                {
                    double dist = Pool.GetDistance(currentLocation, pool.Location);
                    Console.WriteLine($"Distance from {currentLocation} to {pool.Location} is {dist}");
                    if (dist <= min)
                    {
                        min = dist;
                        minPool = pool;
                    }
                }
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^");
                currentLocation = minPool.Location;
                // min = Pool.GetDistance(currentLocation, unvisitedPools[0].Location);
                unvisitedPools.Remove(minPool);
                visitedPools.Add(minPool);
                Console.WriteLine("Counter unvisitied: " + unvisitedPools.Count);
                Thread.Sleep(1000);
            }


            Console.WriteLine("********************");
            Console.WriteLine("Pools to visit.");
            Console.Write(startLocation);
            foreach (Pool pool in visitedPools)
            {
                Console.Write(" --> ");
                Console.Write(pool.Identifier);
                Console.Write(pool.Location.Position());
            }
            Console.WriteLine();


        }
    }
}

