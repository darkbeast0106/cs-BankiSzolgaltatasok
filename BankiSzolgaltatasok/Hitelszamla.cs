using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class Hitelszamla : Szamla
    {
        private int hitelKeret;

        public Hitelszamla(Tulajdonos tulajdonos, int hitelKeret) : base(tulajdonos)
        {
            this.hitelKeret = hitelKeret;
        }

        public int HitelKeret { get => hitelKeret; }

        public override bool Kivesz(int osszeg)
        {
            bool sikeres = true;
            if (osszeg > this.aktualisEgyenleg + this.hitelKeret)
            {
                sikeres = false;
            }
            else
            {
                sikeres = true;
                this.aktualisEgyenleg -= osszeg;
            }
            return sikeres;
        }
    }
}
