using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listaexercios01.exercio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a altura do cilindro");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o raio do cilindro");
            double raio = double.Parse(Console.ReadLine());
            double volume = ((raio * raio) * altura * Math.PI);
            volume = Math.Round(volume,2);
            Console.WriteLine("O volume do cilindro é: " + volume);
            Console.ReadLine();


        }
    }
}
