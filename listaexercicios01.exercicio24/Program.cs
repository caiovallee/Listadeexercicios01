using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaexercicios01.exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 3; i <= 500; i += 3)
            {
                if (i % 2 == 1)
                {
                    soma += i;
                }
            }
            Console.WriteLine("a soma é: " + soma);
            Console.Read();

        }
    }
}
