using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont;
            Console.WriteLine("Programa para realizar a contagem de 1 a 50.\n Aperte qualquer tecla para continuar...");
            Console.ReadKey();

            for (cont = 1; cont <= 50; cont++)
            {
                Console.WriteLine($"Número {cont}");
            }

            Console.ReadKey();
        }
    }
}
