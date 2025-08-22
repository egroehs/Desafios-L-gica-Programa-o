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

            Desafio3 desafio3 = new Desafio3(2000, 10000, 5);
            Console.WriteLine("DESAFIO 3 \n");
            desafio3.CalculateTotalAmount();

            Desafio4 desafio4 = new Desafio4(0);
            Console.WriteLine("DESAFIO 4 \n");
            desafio4.CheckNumberSign();

            Console.ReadLine();
        }
    }
}
