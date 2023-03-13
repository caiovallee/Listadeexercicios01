using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaexercicios01.exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor do numero para mostrar a tabuada: ");
            int n = int.Parse(Console.ReadLine());
            int contador = 0;

            do
            {
                contador += 1;
                int resultado = n * contador;
                Console.WriteLine(n + " X " + contador + " =" + resultado);
            } while (contador < 10);
            Console.ReadLine();

        }
    }
}
