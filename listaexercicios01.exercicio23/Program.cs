using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaexercicios01.exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            do
            {
                contador += 1;
                if (contador % 2 == 1)
                {
                    Console.WriteLine(contador);
                }
            } while (contador < 100);
            Console.ReadLine();
        }
    }
}
