using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public abstract class BankiSzolgaltas
    {
        private Tulajdonos tulajdonos;

        public BankiSzolgaltas(Tulajdonos tulajdonos)
        {
            this.tulajdonos = tulajdonos;
        }

        public Tulajdonos Tulajdonos { get => tulajdonos; }
    }
}
