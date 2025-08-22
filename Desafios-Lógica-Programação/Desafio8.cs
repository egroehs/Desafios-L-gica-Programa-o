using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Lógica_Programação
{
    class Desafio8
    {
        public void PrintNumbersFrom1To25()
        {
            int number = 1;
            do
            {
                Console.WriteLine(number);
                number++;
            } while (number < 26);
        }

        public void PrintNumberFrom10To200()
        {
            for (int i = 10; i <= 200; i += 10) {
                Console.WriteLine(i);
            }
   
        }
    }
}
