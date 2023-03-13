using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaexercicio01.exercicio21Yexercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do { 
            Console.Clear();
            Console.WriteLine("insira o valor dois numeros inteiros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c;
            if (a == b)
            {
                c = a + b;
            }
            else
            {
                 c = a * b;
            }
            Console.WriteLine("O valor da operação ficou " + c );
            Console.ReadLine();
        }while(true);
        }
    }
}
