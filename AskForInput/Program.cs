﻿using System;
using System.Globalization;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro:");
            string input;
            int number = 0;
            while (true) {
                input = Console.ReadLine();
                try {
                    number = int.Parse(input);
                    break;
                } catch (Exception) {
                    Console.WriteLine("Inseriu algo que não era um número inteiro, insira algo correto!");
                }
            }
            Console.WriteLine("Insira um número real:");
            float number2 = 0f;
            while (true) {
                input = Console.ReadLine();
                try {
                    number2 = float.Parse(input.Replace(",", "."));
                    break;
                } catch (Exception) {
                    Console.WriteLine("Inseriu algo que não era um número real, insira algo correto!");
                }
            }

            Console.WriteLine($"A soma de {number} e {number2} é: {number+number2}");
        }
    }
}
