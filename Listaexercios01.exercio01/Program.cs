using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listaexercios01.exercio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a altura da caixa: ");
            double alutra = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a largura da caixa: ");
            double largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a profundidade da caixa: ");
            double profundidade = double.Parse(Console.ReadLine());

            double volume = alutra * largura * profundidade;

            Console.WriteLine("O volume da caixa é: " +volume);





        }
    }
}
