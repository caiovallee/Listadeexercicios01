using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llistaexercicios01.exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Insira o numero inteiro: ");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine(" o numero é par ");
                }
                else
                {
                    Console.WriteLine("o numero é impar");
                }
                Console.ReadLine();
            } while (true);
        }
    }
}
