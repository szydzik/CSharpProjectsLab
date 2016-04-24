using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Osoba
    {
        public string Imie { set; get; }
        public string Nazwisko { set; get; }
        public int RokUrodzenia { set; get; }


        public Osoba(string imie, string nazwisko, int rokUrodzenia)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.RokUrodzenia = rokUrodzenia;
        }

        public Osoba(Osoba osoba)
        {
            this.Imie = osoba.Imie;
            this.Nazwisko = osoba.Nazwisko;
            this.RokUrodzenia = osoba.RokUrodzenia;
        }
        public string ZwrocInformacje()
        {

                return string.Format("Osoba: {0} {1} urodzony/a w {2} ", Imie, Nazwisko, RokUrodzenia);
        }
    }
}
