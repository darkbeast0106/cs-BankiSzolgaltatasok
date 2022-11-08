using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class Bank
    {
        private List<Szamla> szamlaLista;

        public Bank()
        {
            szamlaLista = new List<Szamla>();
        }

        public Szamla SzamlaNyitas(Tulajdonos tulajdonos, int hitelKeret)
        {
            Szamla szamla = null;
            if (hitelKeret < 0)
            {
                throw new ArgumentException("A hitelkeret nem lehet negatív",
                    nameof(hitelKeret));
            }

            if (hitelKeret == 0)
            {
                szamla = new MegtakaritasiSzamla(tulajdonos);
            } 
            else
            {
                szamla = new Hitelszamla(tulajdonos, hitelKeret);
            }
            szamlaLista.Add(szamla);
            return szamla;
        }

        public long GetOsszEgyenleg(Tulajdonos tulajdonos)
        {
            long osszEgyenleg = 0;
            foreach (Szamla szamla in szamlaLista)
            {
                if (szamla.Tulajdonos == tulajdonos)
                {
                    osszEgyenleg += szamla.AktualisEgyenleg;
                }
            }
            return osszEgyenleg;
        }

        public Szamla GetLegnagyobbEgyenleguSzamla(Tulajdonos tulajdonos)
        {
            Szamla legnagyobbEgyenleguSzamla = null;
            foreach (Szamla szamla in szamlaLista)
            {
                if (szamla.Tulajdonos == tulajdonos)
                {
                    if (legnagyobbEgyenleguSzamla == null || 
                        legnagyobbEgyenleguSzamla.AktualisEgyenleg < szamla.AktualisEgyenleg)
                    {
                        legnagyobbEgyenleguSzamla = szamla;
                    }
                }
            }
            return legnagyobbEgyenleguSzamla;
        }

        public long OsszHitelkeret
        {
            get
            {
                long osszHitelkeret = 0;
                foreach (Szamla szamla in szamlaLista)
                {
                    if (szamla is Hitelszamla hitelszamla)
                    {
                        osszHitelkeret += hitelszamla.HitelKeret;
                    }
                }
                return osszHitelkeret;
            }
        }
    }
}
