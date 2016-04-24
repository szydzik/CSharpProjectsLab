using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Kierownik : Osoba
    {
        public int PensjaMiesieczna { get; set; }
        public int ProcentPremii { get; set; }
        private readonly int dodatekKierowniczy;
        private readonly string nrTel;
        private readonly int nrPokoju;
        private readonly string dzial;
        public int DodatekKierowniczy
        {
            get { return dodatekKierowniczy; }
        }
        public string NrTel
        {
            get { return nrTel; }
        }
        public int NrPokoju
        {
            get { return nrPokoju; }
        }
        public string Dzial
        {
            get { return dzial; }
        }
        public Kierownik(string imie, string nazwisko, int rokUrodzenia, int pensjaMiesieczna, int procentPremii, int dodatekKierowniczy, string nrTel, int nrPokoju, string dzial)
            : base(imie, nazwisko, rokUrodzenia)
        {
            this.PensjaMiesieczna = pensjaMiesieczna;
            this.ProcentPremii = procentPremii;
            this.dodatekKierowniczy = dodatekKierowniczy;
            this.nrTel = nrTel;
            this.nrPokoju = nrPokoju;
            this.dzial = dzial;

        }

        public Kierownik(Osoba osoba, int pensjaMiesieczna, int procentPremii, int dodatekKierowniczy, string nrTel, int nrPokoju, string dzial)
            : base(osoba)
        {
            this.PensjaMiesieczna = pensjaMiesieczna;
            this.ProcentPremii = procentPremii;
            this.dodatekKierowniczy = dodatekKierowniczy;
            this.nrTel = nrTel;
            this.nrPokoju = nrPokoju;
            this.dzial = dzial;

        }

        public Kierownik(Kierownik kierownik)
            : base(kierownik.Imie, kierownik.Nazwisko, kierownik.RokUrodzenia)
        {
            this.PensjaMiesieczna = kierownik.PensjaMiesieczna;
            this.ProcentPremii = kierownik.ProcentPremii;
            this.dodatekKierowniczy = kierownik.dodatekKierowniczy;
            this.nrTel = kierownik.nrTel;
            this.nrPokoju = kierownik.nrPokoju;
            this.dzial = kierownik.dzial;
        }

        public double ZwrocPoborMiesieczny()
        {
            return PensjaMiesieczna + (ProcentPremii * PensjaMiesieczna) + DodatekKierowniczy;
        }

        public new string ZwrocInformacje()
        {
            return string.Format("Kierownik: {0}, Pensja miesięczna: {1}zł, Premia: {2}%, Dodatek kierowniczy: {3}zł\n Numer telefonu: {4}, Numer pokoju: {5}\n Dział: {6} ", base.ZwrocInformacje() ,PensjaMiesieczna, ProcentPremii, dodatekKierowniczy, nrTel, nrPokoju, dzial);
        }

    }
}
