using System;

namespace Exercicio_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // usar  class PrintService<T> na classe permite que o susuário declare no program qual tipo de dado que usar

            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            int a = printService.First();
            int b = a + 2;
            Console.WriteLine(b);

            printService.Print();
            Console.WriteLine("First: "+ printService.First());
        }
    }
}
