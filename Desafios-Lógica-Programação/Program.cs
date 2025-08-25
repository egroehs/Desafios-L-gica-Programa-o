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
            Console.WriteLine("\nDESAFIO 2 \n");
            desafio2.AddValues();
            desafio2.SubtractValues();
            desafio2.MultiplyValues();
            desafio2.DivideValues();

            Desafio3 desafio3 = new Desafio3(2000, 10000, 5);
            Console.WriteLine("\nDESAFIO 3 \n");
            desafio3.CalculateTotalAmount();

            Desafio4 desafio4 = new Desafio4(0);
            Console.WriteLine("\nDESAFIO 4 \n");
            desafio4.CheckNumberSign();

            Desafio5 desafio5 = new Desafio5(15, 0);
            Console.WriteLine("\nDESAFIO 5 \n");
            desafio5.CalculateTotalTime();

            Desafio7 desafio7 = new Desafio7(15, 24, 1);
            Console.WriteLine("\nDESAFIO 7 \n");
            desafio7.OrderAsc();

            Desafio8 desafio8 = new Desafio8();
            Console.WriteLine("\nDESAFIO 8 \n");
            desafio8.PrintNumbersFrom1To25();

            Console.WriteLine("\nDESAFIO 8 Pt.2 \n");
            desafio8.PrintNumberFrom10To200();

            Desafio9 desafio9 = new Desafio9();
            Console.WriteLine("\nDESAFIO 9 \n");
            desafio9.PrintMultiplicationTable(12);

            Desafio10.SetWithdrawalAmount(2000);
            Desafio10.Withdrawal();

            Desafio11.SecondsToHours(3600);

            Desafio12.nameSearch("Eduarda");

            int[] numbers = { -10, 5, -3, 8, -7, 2, -1, 6, -4, 9 };
            Desafio13.AnalyzeNumberArray(numbers);

            Desafio14 desafio14 = new Desafio14(numbers);
            desafio14.StartMenu();

            Console.ReadLine();
        }
    }
}
