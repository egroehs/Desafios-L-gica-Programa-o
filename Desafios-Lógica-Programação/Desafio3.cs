using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Lógica_Programação
{
    class Desafio3
    {
        public Desafio3(int salary, int totalSales, int commissionRate)
        {
            Salary = salary;
            TotalSales = totalSales;
            CommissionRate = commissionRate;
        }

        private int Salary { get; }
        private int TotalSales { get; }
        private int CommissionRate { get; }

        public void CalculateTotalAmount()
        {
            double commissionValue = TotalSales * ((double)CommissionRate / 100);

            double totalSalary = commissionValue + Salary;

            Console.WriteLine($"Total salary with commission: ${totalSalary}.");
        }
    }
}
