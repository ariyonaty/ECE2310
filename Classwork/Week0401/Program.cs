using System;

namespace Week0401
{
    class Program
    {
        static void Main(string[] args)
        {
            Random n_obj = new Random();
            int x = n_obj.Next(1,101);
            Console.WriteLine(x);
        }
    }
}
