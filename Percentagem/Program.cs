using System;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Insira 4 números reais entre 0 e 1:");
                try
                {
                    float number1 = float.Parse(Console.ReadLine());
                    float number2 = float.Parse(Console.ReadLine());
                    float number3 = float.Parse(Console.ReadLine());
                    float number4 = float.Parse(Console.ReadLine());
                    if (number1 < 0 || number1 > 1 
                                    || number2 < 0 || number2 > 1
                                    || number3 < 0 || number3 > 1 
                                    || number4 < 0 || number4 > 1)
                    {
                        Console.WriteLine("Inseriu algum número real que não são entre 0 e 1.");
                    }
                    else
                    {
                        Console.WriteLine($"{number1,7:p2}");
                        Console.WriteLine($"{number2,7:p2}");
                        Console.WriteLine($"{number3,7:p2}");
                        Console.WriteLine($"{number4,7:p2}");
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Inseriu conteúdo que não é um número real.");
                }
            }
            
            
        }
    }
}
