using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Lógica_Programação
{
    class Desafio1
    {
        private List<int> values;

        public Desafio1(int valueOne, int valueTwo, int valueThree)
        {
            values = new List<int> { valueOne, valueTwo, valueThree };

        }

        public void ShowValuesInOrder()
        {
            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine($"Value {i + 1}: {values[i]} \n");
            }
        }

        public void ShowValuesInDiferentOrder()
        {
            int newValueOne = values[1];
            int newValueTwo = values[2];
            int newValueThree = values[0];

            values[0] = newValueOne;
            values[1] = newValueTwo;
            values[2] = newValueThree;

            ShowValuesInOrder();
        }
    }
}
