using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class CzlonekZarzadu : Osoba
    {
        public double PensjaMiesieczna { get; set; }
        public int IloscSpotkan { get; set; }
        public Osoba asystent;



        public CzlonekZarzadu(string imie, string nazwisko, int rokUrodzenia,int pensjaMiesieczna,int iloscSpotkan, Osoba asystent)
            : base(imie,nazwisko,rokUrodzenia)
        {
            this.PensjaMiesieczna = pensjaMiesieczna;
            this.IloscSpotkan = iloscSpotkan;
            this.asystent = asystent;
        }

        public CzlonekZarzadu(Osoba osoba, int pensjaMiesieczna, int iloscSpotkan, Osoba asystent)
            : base(osoba)
        {
            this.PensjaMiesieczna = pensjaMiesieczna;
            this.IloscSpotkan = iloscSpotkan;
            this.asystent = asystent;
        }

        public CzlonekZarzadu(CzlonekZarzadu czlonek)
           : base(czlonek.Imie,czlonek.Nazwisko,czlonek.RokUrodzenia)
        {
            this.PensjaMiesieczna = czlonek.PensjaMiesieczna;
            this.IloscSpotkan = czlonek.IloscSpotkan;
            this.asystent = czlonek.asystent;
        }

        public Osoba Asystent
        {
            get { return asystent; }
            set { asystent = value; }
        }

        public double ZwrocPoborMiesieczny(double kwotazaobecnosc)
        {
            return PensjaMiesieczna + (IloscSpotkan*kwotazaobecnosc);
        }

        public void DodajSpotkanie()
        {
            IloscSpotkan += 1;
        }

        public new string ZwrocInformacje()
        {
            return String.Format("Członek zarządu: {0}, pensja miesięczna: {1}, obecności na spotkaniach rady nadzorczej: {2}, Asystent: {3} ", base.ZwrocInformacje(),PensjaMiesieczna,IloscSpotkan, asystent.ZwrocInformacje());
        }
    }
}
