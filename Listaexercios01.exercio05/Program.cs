using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listaexercios01.exercio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor do raio da esfera: ");
            double raio = double.Parse(Console.ReadLine());
            double volume = (raio * raio * raio) * 4.0 / 3.0 * Math.PI ;
            Console.WriteLine("O volume da esfera é: " + volume);
            Console.ReadLine();

        }
    }
}
