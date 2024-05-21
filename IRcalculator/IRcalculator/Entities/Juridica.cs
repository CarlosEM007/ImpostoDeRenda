using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRcalculator.Entities
{
    public class Juridica : Pessoa
    {
        public double NFuncionarios;

        public Juridica(string nome, double anual, double nfunc) : base(nome, anual)
        {
            Nome = nome;
            RendaAnual = anual;
            NFuncionarios = nfunc;
        }

        public override double IR()
        {
            double ir;

            if(NFuncionarios > 10)
            {
                ir = RendaAnual * 0.14;
            }
            else
            {
                ir = RendaAnual * 0.16;
            }

            return ir;
        }
    }
}
