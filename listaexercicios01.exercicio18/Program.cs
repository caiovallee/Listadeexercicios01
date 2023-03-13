using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaexercicios01.exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 valores inteiros para a,b,c");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
      
                if (b > c)
                {
                    Console.Write(a +" , " + b + " , " + c);
                }
                else
                {
                    Console.Write(a + " , " + c + " , " + b);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.Write(b + " , " + a + " , " + c);
                }
                else
                {
                    Console.Write(b + " , " + c + " , " + a);
                }
            }
            else
            {
                if (a > b)
                {
                    Console.Write(c + " , " + a + " , " + b);
                }
                else
                {
                    Console.Write(c +" , " + b + " , " + a);

                }
            }

            Console.ReadLine();
            }
        }
    }
