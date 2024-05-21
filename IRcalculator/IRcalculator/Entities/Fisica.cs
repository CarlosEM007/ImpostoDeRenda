using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRcalculator.Entities
{
    public class Fisica : Pessoa
    {
        public double GastosCSaude { get; set; }

        public Fisica(string nome, double anual, double gastos) : base(nome, anual)
        {
            Nome = nome;
            RendaAnual = anual;
            GastosCSaude = gastos;
        }

        public override double IR()
        {
            double ir;

            ir = base.IR() - (GastosCSaude * 0.50);

            return ir;
        }

    }
}
