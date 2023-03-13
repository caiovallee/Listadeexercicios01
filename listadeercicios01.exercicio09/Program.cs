using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listadeercicios01.exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("primeira nota: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("terceira nota: ");
            double n3 = double.Parse(Console.ReadLine());

            double mediaHarmonica = 3 / (1 / n1 + 1 / n2 + 1 / n3);
            mediaHarmonica = Math.Round(mediaHarmonica, 2);
            Console.WriteLine("A media harmonica é: " + mediaHarmonica);
           
            Console.ReadLine();
        }
    }
}
