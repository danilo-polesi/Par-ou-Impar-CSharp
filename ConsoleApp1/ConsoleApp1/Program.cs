using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Clear();
            Console.Write("\n\tDigite um número inteiro:");
            x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("\nO número " + x + " é par");
            }
            else
            {
                Console.WriteLine("\nO número " + x + " é ímpar");
            }
            Console.ReadKey();
        }
    }
}
