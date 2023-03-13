using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaexercicio01.exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva os 3 numeros");
            int v1 = int.Parse(Console.ReadLine());
            int v2 = int.Parse(Console.ReadLine());
            int v3 = int.Parse(Console.ReadLine());


            if (v1 > v2 && v2 > v3)
            {
                Console.WriteLine(v1 + " " + v2 + " " + v3);
            } 
            else if (v2 > v1 && v1 > v3)
            {
                Console.WriteLine(v2 + " " + v1 + " " + v3);
            }


            Console.ReadKey();
           
        }
    }
}
