using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Lógica_Programação
{
    class Desafio5
    {
        private int StartHour;
        private int EndHour;

        public Desafio5(int startHour, int endHour)
        {
            if (startHour < 0 || startHour > 23)
            {
                throw new ArgumentOutOfRangeException(nameof(startHour), "Start hour must be between 0 and 24.");
            }

            if (endHour < 0 || endHour > 23)
            {
                throw new ArgumentOutOfRangeException(nameof(endHour), "End hour must be between 0 and 24.");
            }

            StartHour = startHour;
            EndHour = endHour;
        }

        public void CalculateTotalTime()
        {
            if(StartHour < EndHour)
            {
                int totalTime = EndHour - StartHour;
                Console.WriteLine($"Total hours: {totalTime}h \n\n");

            } else
            {
                int totalTime = (24 - StartHour) + EndHour;
                Console.WriteLine($"Total hours: {totalTime}h \n\n");
                
            }
            
            
        }

    }
}
