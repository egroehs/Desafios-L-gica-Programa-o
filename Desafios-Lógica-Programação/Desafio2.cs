using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Lógica_Programação
{
    class Desafio2
    {
        private int ValueOne { get;  }
        private int ValueTwo { get; }

        public Desafio2(int valueOne, int valueTwo)
        {
            ValueOne = valueOne;
            ValueTwo = valueTwo;
        }

        public void AddValues()
        {
            int addition = ValueOne + ValueTwo;
            Console.WriteLine($"Addition: {addition} \n");
        }

        public void SubtractValues()
        {
            int subtraction = ValueOne - ValueTwo;
            Console.WriteLine($"Subtraction: {subtraction} \n");
        }

        public void MultiplyValues()
        {
            int multiplication = ValueOne * ValueTwo;
            Console.WriteLine($"Multiplication: {multiplication} \n");
        }

        public void DivideValues()
        {
            try
            {
                double division = (double) ValueOne / ValueTwo;
                Console.WriteLine($"Division: {division:F2} \n");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: attempt to divide by zero.\n");
            }

        }
    }
}
