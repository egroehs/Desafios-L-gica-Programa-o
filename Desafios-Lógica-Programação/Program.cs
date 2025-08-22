using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Lógica_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            Desafio1 desafio1 = new Desafio1(10, 20, 30);
            Console.WriteLine("DESAFIO 1 \n");
            desafio1.ShowValuesInOrder();
            desafio1.ShowValuesInDiferentOrder();

            Desafio2 desafio2 = new Desafio2(10, 52);
            Console.WriteLine("DESAFIO 2 \n");
            desafio2.AddValues();
            desafio2.SubtractValues();
            desafio2.MultiplyValues();
            desafio2.DivideValues();

            Console.ReadLine();
        }
    }
}
