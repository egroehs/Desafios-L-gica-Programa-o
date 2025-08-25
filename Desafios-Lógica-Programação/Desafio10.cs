using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Lógica_Programação
{
    using System;

    static class Desafio10
    {
        public static int WithdrawalAmount { get; private set; }

        public static void SetWithdrawalAmount(int amount)
        {
            WithdrawalAmount = amount;
        }

        public static void Withdrawal()
        {
            if (WithdrawalAmount <= 0 || WithdrawalAmount % 1 != 0)
            {
                Console.WriteLine("Valor inválido. O valor deve ser um número inteiro positivo.");
                return;
            }

            int[] notas = { 200, 100, 50, 20, 10, 5, 2 };
            int valor = WithdrawalAmount;
            Console.WriteLine($"Saque de R${valor} realizado com as seguintes cédulas:");

            foreach (int nota in notas)
            {
                int quantidade = valor / nota;
                if (quantidade > 0)
                {
                    Console.WriteLine($"{quantidade} nota(s) de R${nota}");
                    valor %= nota;
                }
            }

            if (valor > 0)
            {
                Console.WriteLine($"Valor restante de R$ {valor} não pode ser sacado (sem cédula de R$1).");
            }
        }
    }

}
