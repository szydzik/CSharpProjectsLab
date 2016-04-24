using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class PracownikUmyslowy : Osoba
    {
        public double PensjaMiesieczna { get; set; }
        public double ProcentPremii { get; set; }
        public Kierownik Kierownik { get; set; }
        private string numerTelefonu;
        private int numerPokoju;

        public string NumerTelefonu
        {
            get { return numerTelefonu; }
            set { this.numerTelefonu = value; }
        }

        public int NumerPokoju
        {
            get { return NumerPokoju;}
            set { this.numerPokoju = value; }
        }

        public PracownikUmyslowy(string imie, string nazwisko, int rokUrodzenia,double pensjaMiesieczna,double procentPremii, Kierownik kierownik,
            string numerTelefonu,int numerPokoju)
            : base(imie,nazwisko,rokUrodzenia)
        {
            this.PensjaMiesieczna = pensjaMiesieczna;
            this.ProcentPremii = procentPremii;
            this.Kierownik = kierownik;
            this.numerTelefonu = numerTelefonu;
            this.numerPokoju = numerPokoju;
        }

        public PracownikUmyslowy(PracownikUmyslowy pracownik)
            :base(pracownik.Imie,pracownik.Nazwisko,pracownik.RokUrodzenia)
        {
            this.PensjaMiesieczna = pracownik.PensjaMiesieczna;
            this.ProcentPremii = pracownik.ProcentPremii;
            this.Kierownik = pracownik.Kierownik;
            this.numerTelefonu = pracownik.NumerTelefonu;
            this.numerPokoju = pracownik.NumerPokoju;
        }

        public PracownikUmyslowy(Osoba osoba, double pensjaMiesieczna, double procentPremii, Kierownik kierownik,
            string numerTelefonu, int numerPokoju)
            : base(osoba)
        {
            this.PensjaMiesieczna = pensjaMiesieczna;
            this.ProcentPremii = procentPremii;
            this.Kierownik = kierownik;
            this.numerTelefonu = numerTelefonu;
            this.numerPokoju = numerPokoju;
        }

        public double ZwrocPoborMiesieczny()
        {
            return (PensjaMiesieczna + (ProcentPremii * PensjaMiesieczna));
        }

        public new string ZwrocInformacje()
        {
            return String.Format("Pracownik umysłowy: {0}, Pensja miesięczna: {1}, Premia: {2}, Numer telefonu: {3}, Numer pokoju: {4}, Kierownik: {5} ", base.ZwrocInformacje(), this.PensjaMiesieczna, this.ProcentPremii, this.numerTelefonu,this.numerPokoju,this.Kierownik.ZwrocInformacje());
        }
    }
}
