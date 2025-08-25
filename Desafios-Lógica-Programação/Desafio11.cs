using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Lógica_Programação
{
    static class Desafio11
    {
        static public string SecondsToHours(int seconds)
        {
            int hours = seconds / 3600;
            seconds %= 3600;

            int minutes = seconds / 60;
            seconds %= 60;

            int secs = seconds;

            Console.WriteLine($"{hours:D2}:{minutes:D2}:{secs:D2}");
            return $"{hours:D2}:{minutes:D2}:{secs:D2}";
        }

    }
}
