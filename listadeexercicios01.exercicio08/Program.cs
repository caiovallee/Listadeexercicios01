using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listadeexercicios01.exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double raio = 5.0;
            const double altura = 10.0;
            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            Console.WriteLine("O volume da lata de óleo é de " +volume + " cm³.");
            Console.ReadKey();
        }
    }
}
