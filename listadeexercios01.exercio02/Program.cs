using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listadeexercios01.exercio02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira o valor em graus farenhart: ");
            double farenhart = double.Parse(Console.ReadLine());

            double celsius = (farenhart -32)/1.8;
            celsius = Math.Round(celsius, 2);

            Console.WriteLine(farenhart + "graus em farenhart equivale a: " + celsius + " em graus celsius");
            Console.ReadLine();
        }
    }
}
