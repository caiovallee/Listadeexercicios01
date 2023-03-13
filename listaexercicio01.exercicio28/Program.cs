using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaexercicio01.exercicio28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {

                if (i % 3 == 0 && i % 5 == 1)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0 && i % 3 == 1)
                {
                    Console.WriteLine("BUZZ");
                }
                else if(i % 3 == 0 && i % 5 == 0)
                    {
                    Console.WriteLine("FIZZ BUZZ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}
