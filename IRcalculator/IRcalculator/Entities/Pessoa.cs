using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRcalculator.Entities
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public double RendaAnual {  get; set; }

        public Pessoa(string nome, double renda) { }

        public virtual double IR()
        {
            double ir;

            if(RendaAnual < 20000)
            {
                ir = RendaAnual * 0.15;
            } 
            else
            {
                ir = RendaAnual * 0.25;
            }

            return ir;
        }

    }
}
