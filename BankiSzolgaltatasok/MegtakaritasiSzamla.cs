using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class MegtakaritasiSzamla : Szamla
    {
        private double kamat;
        public static double alapKamat = 1.1;

        public MegtakaritasiSzamla(Tulajdonos tulajdonos) : base(tulajdonos)
        {
            this.kamat = alapKamat;
        }

        public double Kamat { get => kamat; set => kamat = value; }

        public override bool Kivesz(int osszeg)
        {
            bool sikeres = false;
            if (osszeg > this.aktualisEgyenleg)
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

        public void KamatJovairas()
        {
            this.aktualisEgyenleg = (int)(this.aktualisEgyenleg * this.kamat);
        }
    }
}
