using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro:");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            Console.WriteLine("Insira um número real:");
            input = Console.ReadLine();
            float number2 = float.Parse(input);

            Console.WriteLine($"A soma de {number} e {number2} é: {number+number2}");
        }
    }
}
