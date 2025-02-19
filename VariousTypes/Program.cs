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

            char c1 = '\u270D', c2 = '\u27A8', c3 = '\u260E', c4 = '\u2705';
            Console.WriteLine($"\nChars Unicode: {c1} {c2} {c3} {c4}");

            double health = 15.5d;
            float health_perc = 0.50f;
            Console.WriteLine($"\n\nHealth: {health} ({health_perc:p0})");

            bool _truestStatment = true;
            bool _falsestStatment = false;
            Console.WriteLine($"bools: {_truestStatment} or {_falsestStatment}");

        }
    }
}