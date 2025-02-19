﻿using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string welcome_text = "Hello and welcome to this world!";
            string player_name = "John Johnson";
            char c = '\u2622';

            string formatted_text = $"{welcome_text}\n\n> Player Name: {player_name} (NEW)\t{c}";
        
            Console.WriteLine(formatted_text);

            int xp = 500;
            int xp_needed = 1000;
            Console.WriteLine($"O XP necessário é {xp_needed-xp} ({xp_needed} - {xp})");
        }
    }
}
