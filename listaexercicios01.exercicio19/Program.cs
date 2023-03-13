using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaexercicios01.exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a altura do adulto em metros: ");
            double alturadulto = double.Parse(Console.ReadLine());
            Console.WriteLine("informe o peso do adulto em kilos: ");
            double pesoadulto = double.Parse(Console.ReadLine());
            double imc = pesoadulto / (alturadulto * alturadulto);

            if (imc < 18.5)
            {
                Console.WriteLine("O adulto tem um imc de: " + imc + " e esta abaixo do peso");

            }
            else if (imc >= 18.5 && imc <= 25)
            {
                Console.WriteLine("O adulto tem um imc de: " + imc + " e tem o peso normal");
            }
            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine("O adulto tem um imc de: " + imc + " e esta acima do peso");
            }
            else if (imc > 30)
            {
                Console.WriteLine("O adulto tem um imc de: " + imc + " e esta OBESO, procure ajuda!");
            }
            Console.ReadLine();
        }
    }
}
