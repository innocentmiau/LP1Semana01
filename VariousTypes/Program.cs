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

            char[] cs = {'\u270D', '\u27A8', '\u260E', '\u2705'};
            string chars = "";
            foreach (char c in cs) {
                chars += $" {c} /";
            }
            Console.WriteLine($"\nChars Unicode:{chars.Substring(0, chars.Length-1)}");
        }
    }
}