using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Lógica_Programação
{
    class Desafio7
    {
        private List<int> values;

        public Desafio7(int valueOne, int valueTwo, int valueThree)
        {
            values = new List<int> { valueOne, valueTwo, valueThree };

        }

        public void OrderAsc()
        {
            foreach (int value in values.OrderBy(v => v))
            {
                Console.WriteLine(value);
            }

        }
    }
}
