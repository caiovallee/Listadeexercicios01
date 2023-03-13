using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaexercicios01.exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor de a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de c");
            int c = int.Parse(Console.ReadLine());

            if(a + b < c)
            {
                Console.WriteLine("A soma de a e b é menor que c");
            }
            else
            {
                Console.WriteLine("A soma de a e b não é menor que c");
            }
            Console.ReadLine();
        }
    }
}
