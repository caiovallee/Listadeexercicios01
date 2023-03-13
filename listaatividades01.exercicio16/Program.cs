using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaatividades01.exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira o salario do funcionario: ");
            double salariofunc = double.Parse(Console.ReadLine());

            double salarioaumentado = (salariofunc * 15 / 100) + salariofunc;
            double descontoimposto = salarioaumentado - (salarioaumentado * 8 / 100);
            Console.WriteLine("O salario inicial era de: " +salariofunc +" Após o aumento ficou em: " +salarioaumentado + " e após o desconto de impostos ficou em: " +descontoimposto);
            Console.ReadLine();
        }
    }
}
