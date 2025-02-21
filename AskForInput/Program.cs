using System;
using System.Globalization;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro:");
            int number;
            while (true) {
                try {
                    number = int.Parse(Console.ReadLine());
                    break;
                } catch (Exception) {
                    Console.WriteLine("Inseriu algo que não era um número inteiro, insira algo correto!");
                }
            }
            Console.WriteLine("Insira um número real:");
            float number2;
            while (true) {
                try {
                    number2 = float.Parse(Console.ReadLine().Replace(",", "."));
                    break;
                } catch (Exception) {
                    Console.WriteLine("Inseriu algo que não era um número real, insira algo correto!");
                }
            }

            Console.WriteLine($"A soma de {number} e {number2} é: {number+number2}");
        }
    }

}
