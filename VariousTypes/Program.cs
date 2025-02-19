using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            short level = 5;
            int xp = 2500000;
            long xp_needed = 40000000000;
            Console.WriteLine($"Lvl. {level}: {xp}/{xp_needed}");
        }
    }
}