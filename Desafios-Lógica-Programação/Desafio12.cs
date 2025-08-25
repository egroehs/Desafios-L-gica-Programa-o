using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Lógica_Programação
{
    static class Desafio12
    {
        static public bool nameSearch(string name)
        {
            string[] names = {
                "Ana",
                "Bruno",
                "Carla",
                "Daniel",
                "Eduarda",
                "Felipe",
                "Gabriela",
                "Henrique",
                "Isabela",
                "João"
            };

            
                if(names.Contains(name))
                {
                    Console.WriteLine($"The name {name} is present");
                    return true;
                }
                Console.WriteLine($"The name {name} is not present");
                return false;
            

        }
    }
}
