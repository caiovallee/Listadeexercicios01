using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listadeexercicios01.exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor em graus celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double farenhart = (celsius - 32) / 1.8;
            farenhart = Math.Round(farenhart, 2);
            Console.WriteLine(celsius + "graus em farenhart equivale a: " + farenhart + " em graus celsius");
            Console.ReadLine();



        }
    }
}
