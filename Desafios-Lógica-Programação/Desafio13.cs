using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Lógica_Programação
{
    static class Desafio13
    {
        
        static public void AnalyzeNumberArray(int[] numbers)
        {
            int even = 0;
            int odd = 0;
            int positive = 0;
            int negative = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    even++;
                else
                    odd++;

                if (num > 0)
                    positive++;
                else if (num < 0)
                    negative++;
            }

            Console.WriteLine($"Even: {even}");
            Console.WriteLine($"Odd: {odd}");
            Console.WriteLine($"Positive: {positive}");
            Console.WriteLine($"Negative: {negative}");
        }
    }
    
}
