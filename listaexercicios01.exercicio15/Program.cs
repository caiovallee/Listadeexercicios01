using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaexercicios01.exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double farenhart = (celsius * 1.8) + 32;
            Console.WriteLine(celsius +"graus celsius" + "são " + farenhart +" graus farenhart");
            Console.ReadLine();
        }
    }
}
