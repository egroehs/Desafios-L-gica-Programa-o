using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Lógica_Programação
{
    class Desafio9
    {
        public void PrintMultiplicationTable(int number)
        {
            Console.WriteLine($"\nMultiplication table for {number}:\n");

            for(int i = 1; i <= 10; i++ )
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }
    }
}
