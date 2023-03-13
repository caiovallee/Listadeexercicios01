using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaexercicios01.exercicios07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salario base do vendedor: ");
            double salariobase = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o total de vendas realizadas : ");
            int totalvendas = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual da comissão por venda em (%): ");
            int valorcomissao = int.Parse(Console.ReadLine());

            double salariototal = salariobase + (totalvendas * valorcomissao / 100);
            Console.WriteLine("O salario total do vendedor é : " + salariototal);
            Console.ReadLine();
        }
    }
}
