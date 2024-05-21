using IRcalculator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRcalculator.Controllers
{
    public class PessoaControl
    {
        public static List<Pessoa> pessoa = new List<Pessoa>();
        public void Add()
        {
            string tipo;
            while (true)
            {
                Console.WriteLine("-Pessoa Fisica ou Juridica?(c/j)-\n");
                tipo = Console.ReadLine();
                if (tipo == "c" || tipo == "j")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Tipo Inválido!");
                }
                Console.Clear();
            }

            /*Recebe Nome*/
            Console.WriteLine("-          Qual o nome?         -\n");
            string? name = Console.ReadLine();

            /*Recebe Renda Anual*/
            Console.WriteLine("-     Qual sua Renda Anual?     -\n");
            double renda;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out renda))
                {
                    break;
                }
                Console.WriteLine("Valor inválido. Por favor, digite um nível válido.\n");
            }

            /*Gasto com saúde / Numero de funcionários*/
            while (true)
            {
                if (tipo == "c")
                {
                    Console.WriteLine($"Qual foi o gasto com saúde de {name}?");
                    int gasto;

                    if (int.TryParse(Console.ReadLine(), out gasto))
                    {
                        pessoa.Add(new Fisica(name, renda, gasto));
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Quantos Funcionários {name} possui?");
                    int nfunc;

                    if (int.TryParse(Console.ReadLine(), out nfunc))
                    {
                        pessoa.Add(new Juridica(name, renda, nfunc));
                        break;
                    }
                }
            }
            Console.WriteLine("Adicionado com sucesso!");
        }

        public void See()
        {
            for(int i = 0; i < pessoa.Count; i++)
            {
                Console.WriteLine($"Nome: {pessoa[i].Nome}");
                Console.WriteLine($"Renda Anual: {pessoa[i].RendaAnual}");
                Console.WriteLine($"Total Imposto de Renda: {pessoa[i].IR()}");
                Console.WriteLine("------------------------------------------");
            }
        }
    }
}
