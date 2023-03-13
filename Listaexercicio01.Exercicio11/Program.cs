using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listaexercicio01.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o numero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 1 || numero == 2)
            {
                Console.WriteLine("o numero é primo: ");
            }
            else
            {
                Console.WriteLine("o numero não é primo");
            }
            Console.ReadLine();
        }
    }
}
