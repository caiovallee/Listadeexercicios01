using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaexercicios01.exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Digite um número para ser fatorado : ");
            int numero = int.Parse(Console.ReadLine());

            int fatorial = 1;
            int i = 1;

            while (i <= numero)
            {
                fatorial = fatorial * i;
                i+=1;
            }

            Console.WriteLine("O fatorial de " + numero + " é " + fatorial + ".");
            Console.ReadLine();

        }
    }
}
