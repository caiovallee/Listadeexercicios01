using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listadeexercicios01.exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
            //pãozinho custa R$ 0,12 e a broa custa R$ 1,50.Ao final do dia, o dono quer saber quanto arrecadou com a venda
            //dos pães e broas(juntos), e quanto deve guardar numa conta de poupança(10 % do total arrecadado). Você foi
            //contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as quantidades
            //de pães e de broas, e depois calcular os dados solicitados.


            Console.WriteLine("Insira a quantidade de pães vendidos no dia");
            int quantidadepaes = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de broas vendidas no dia");
            int quantidadebroas = int.Parse(Console.ReadLine());

            double totalarecadado = (quantidadebroas * 1.50) + (quantidadepaes * 0.12);
            double poupança = (totalarecadado / 100) * 10;

            Console.WriteLine("O total arrecadado foi: " + totalarecadado + "é o valor a ser depositado é: " +poupança);
            Console.ReadLine();
        }
    }
}
