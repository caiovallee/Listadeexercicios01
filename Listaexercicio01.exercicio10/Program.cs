using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listaexercicio01.exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira as notas do aluno");
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            double n4 = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite os pesos das três notas:");
            double peso1 = double.Parse(Console.ReadLine());
            double peso2 = double.Parse(Console.ReadLine());
            double peso3 = double.Parse(Console.ReadLine());
            double peso4 = double.Parse(Console.ReadLine());

            double mediaponderada = (n1 * peso1 + n2 * peso2 + n3 * peso3 + n4 + peso4) / (peso1 + peso2 + peso3 + peso4);
            Console.WriteLine("a media ponderada é: " + mediaponderada);
            Console.ReadLine();


        }
    }
}
