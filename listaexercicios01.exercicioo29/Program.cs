using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaexercicios01.exercicioo29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int n = 1; n <= 10; n++)
                {
                    
                    int resultado = i * n;
                    
                    Console.WriteLine( i  + " X " + n  +" = " + resultado);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
