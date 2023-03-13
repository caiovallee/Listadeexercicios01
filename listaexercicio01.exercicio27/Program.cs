using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaexercicio01.exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 1, c;

            Console.Write("Digite um número inteiro positivo: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Sequência de Fibonacci até " + n + ": ");

            while (a <= n)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
