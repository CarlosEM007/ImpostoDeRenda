using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRcalculator.View
{
    public static class Menu
    {
        public static void Use()
        {
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║          Imposto de Renda          ║");
            Console.WriteLine("╠════════════════════════════════════╣");
            Console.WriteLine("║                                    ║");
            Console.WriteLine("║  1. Cadastrar Usuario              ║");
            Console.WriteLine("║  2. Ver Imposto de Renda           ║");
            Console.WriteLine("║  3. Sair                           ║");
            Console.WriteLine("║                                    ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.Write("Operação:  ");
        }
    }
}
