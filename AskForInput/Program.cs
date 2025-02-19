using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro:");
            string input = Console.ReadLine();
            int number = 0;
            try {
                number = int.Parse(input);
            } catch (Exception e) {
                Console.WriteLine("Inseriu um número que não era inteiro, o valor 0 foi atribuido.");
            }
            Console.WriteLine("Insira um número real:");
            input = Console.ReadLine();
            float number2 = float.Parse(input);

            Console.WriteLine($"A soma de {number} e {number2} é: {number+number2}");
        }
    }
}
