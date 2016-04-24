using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoby
{
    public enum Plec { Kobieta, Mezczyzna }
    public class Osoba
    {
        public string Imie { set; get; }
        public string Nazwisko { set; get; }
        protected Plec Plec { set; get; }

        private readonly int rokUrodzenia;
        public int RokUrodzenia
        {
            get { return rokUrodzenia; }
        }

        public Osoba(string imie, string nazwisko, int rokUrodzenia, Plec plec)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.Plec = plec;
        }

        public string ZwrocInformacje()
        {
            if (Plec == Plec.Kobieta)
            {
                return string.Format("Pani {0} {1} urodzona w {2}", Imie, Nazwisko, RokUrodzenia);
            } else {
                return string.Format("Pan {0} {1} urodzony w {2}", Imie, Nazwisko, RokUrodzenia);
            }
        }
    }
}
