using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaexercicios01.exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o nome da pessoa");
            string nomepessoa = Console.ReadLine();
            Console.WriteLine("Insira a idade da pessoa");
            int idadepessoa = int.Parse(Console.ReadLine());

            int diasdevida = idadepessoa * 365;

            Console.WriteLine(nomepessoa + " ja viveu: " + diasdevida + " dias abaixo desse céu");
            Console.ReadLine();

        }
    }
}
