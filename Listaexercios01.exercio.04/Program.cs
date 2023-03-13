using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listaexercios01.exercio._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quilometragem inicial do percurso: ");
           double kmInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quilometragem final do percurso: ");
           double kmFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de combustível consumida (em litros): ");
            double combustivel = double.Parse(Console.ReadLine());

            double consumoMedio = combustivel / (kmFinal - kmInicial);

            Console.WriteLine("O consumo médio de combustível foi de: " + consumoMedio + " litros por km");
            Console.ReadLine();
        }
    }
}
