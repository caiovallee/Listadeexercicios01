using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaexercicios01.exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira a base e depois a altura do terreno em metros: ");
            double baseterreno =double.Parse(Console.ReadLine());
            double alturaterreno =double.Parse(Console.ReadLine());

            double area = baseterreno * alturaterreno;
            Console.WriteLine("a area do terreno é de :" + area +"(m²)");
            Console.ReadLine();


        }
    }
}
