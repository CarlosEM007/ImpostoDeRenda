using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRcalculator.Entities;

namespace IRcalculator.Controllers
{
    public class Operations
    {
        public static PessoaControl pessoaControl = new PessoaControl();
        public static void Options(int op)
        {
            switch(op)
            {
                case 1:
                    pessoaControl.Add();
                    break;
                case 2:
                    pessoaControl.See();
                    break;
            }

        }
    }
}
