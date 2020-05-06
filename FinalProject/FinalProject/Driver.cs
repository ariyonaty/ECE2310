using System;
using System.Collections.Generic;

namespace FinalProject
{
    class Driver
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Location startLocation = new Location(0, 0);
            /* 
                        Pool[] pools = new Pool[7];
                        pools[0] = new Pool(new Location(4, 8), 'A');
                        pools[1] = new Pool(new Location(1, 3), 'B');
                        pools[2] = new Pool(new Location(4, 2), 'C');
                        pools[3] = new Pool(new Location(13, 1), 'D');
                        pools[4] = new Pool(new Location(12, 9), 'E');
                        pools[5] = new Pool(new Location(10, 5), 'F');
                        pools[6] = new Pool(new Location(6, 6), 'G');

                        Pool[] unvisitied = new Pool[7];
                        Pool[] visitied = new Pool[7];

                        for (int i = 0; i < unvisitied.Length; i++)
                        {
                            unvisitied[i] = pools[i];
                        }
             */

            List<Pool> myPools = new List<Pool>();
            myPools.Add(new Pool(new Location(4, 8), 'A'));
            myPools.Add(new Pool(new Location(1, 3), 'B'));
            myPools.Add(new Pool(new Location(4, 2), 'C'));
            myPools.Add(new Pool(new Location(13, 1), 'D'));
            myPools.Add(new Pool(new Location(12, 9), 'E'));
            myPools.Add(new Pool(new Location(10, 5), 'F'));
            myPools.Add(new Pool(new Location(6, 6), 'G'));
            foreach (Pool pool in myPools)
            {
                Console.WriteLine(pool);
            }

            List<Pool> unvisitedPools = new List<Pool>(myPools);
            List<Pool> visitedPools = new List<Pool>();

            Console.WriteLine("********************");
            double min = Pool.GetDistance(startLocation, unvisitedPools[0].Location);
            Pool minPool = new Pool();
            Console.WriteLine(min);
            Console.WriteLine(unvisitedPools.Count);
            Console.WriteLine(visitedPools.Count);

            foreach (Pool pool in unvisitedPools)
            {
                double dist = Pool.GetDistance(startLocation, pool.Location);
                Console.WriteLine($"Distance from {startLocation} to {pool.Location} is {dist}");
                if (dist < min)
                {
                    min = dist;
                    minPool = pool;
                }
            }

            Console.WriteLine("----------------------");
            foreach (Pool pool in unvisitedPools)
            {
                Console.WriteLine(pool);
            }
            unvisitedPools.Remove(minPool);
            visitedPools.Add(minPool);
            Console.WriteLine("----------------------");
            foreach (Pool pool in unvisitedPools)
            {
                Console.WriteLine(pool);
            }
            Console.WriteLine("----------------------");

            Console.WriteLine(min);
            Console.WriteLine("********************");
            Console.WriteLine("Pools to visit.");
            Console.Write(startLocation);
            foreach (Pool pool in visitedPools)
            {
                Console.Write(" --> ");
                Console.Write(pool.Identifier);
            }
            Console.WriteLine();


        }
    }
}
