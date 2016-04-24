using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class Towar
    {
        private string nazwa;
        private string jednostka;
        private double cenaJednBrutto;
        private double cenaJednNetto;
        private double ilosc;
        private double cenaCalkNetto;
        private double cenaCalkBrutto;
        private double procentPodatku;

        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        public string Jednostka
        {
            get { return jednostka; }
            set { jednostka = value; }
        }
        //cena jednostkowa brutto oraz ceny calkowite nie potrzebują być ustawiane,
        //ponieważ będą obliczane automatycznie przy zmianach
        public double CenaJednBrutto
        {
            get { return cenaJednBrutto; }
        }

        public double CenaJednNetto
        {
            get { return cenaJednNetto; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Cena nie może być mniejsza od zera");
                }
                else
                {
                    cenaJednNetto = value;
                    cenaJednBrutto = cenaJednNetto + (cenaJednNetto * (procentPodatku / 100));
                    cenaCalkNetto = cenaJednNetto * ilosc;
                    cenaCalkBrutto = cenaJednBrutto * ilosc;
                }
            }
        }

        public double Ilosc
        {
            get { return ilosc; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Ilosc musi byc wieksza od zera");
                }
                else
                {
                    ilosc = value;
                }
            }
        }

        public double CenaCalkNetto
        {
            get { return cenaCalkNetto; }
        }

        public double CenaCalkBrutto
        {
            get { return cenaCalkBrutto; }
        }

        public double ProcentPodatku
        {
            get { return procentPodatku; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Procent podatku nie może być mniejszy od zera");
                }
                else
                {
                    procentPodatku = value;
                }
            }
        }

        public Towar(string nazwa, string jednostka, double cenaJednNetto,
            double ilosc, double procentPodatku)
        {
            this.nazwa = nazwa;
            this.jednostka = jednostka;
            this.cenaJednNetto = cenaJednNetto;
            this.cenaJednBrutto = Math.Round(cenaJednNetto + (cenaJednNetto * (procentPodatku / 100)), 2);
            this.cenaCalkNetto = cenaJednNetto * ilosc;
            this.cenaCalkBrutto = cenaJednBrutto * ilosc;
            this.ilosc = ilosc;
            this.procentPodatku = procentPodatku;
        }

        public Towar(Towar towar)
           : this(towar.Nazwa, towar.Jednostka, towar.CenaJednNetto,
                towar.Ilosc, towar.ProcentPodatku)
        { }

        public Towar()
            : this("Cukier", "kg", 2.30, 12, 23)
        { }

        /// <summary>
        /// Nadpisanie metody ToString(), głównie do przydatne do testów
        /// </summary>
        /// <returns>Ciąg znaków reprezentujących dany towar</returns>
        public override string ToString()
        {
            return "Towar:" + this.nazwa + ", " + this.ilosc + " " + this.jednostka + ", cena jednostkowa netto: " + this.cenaJednNetto + "zł , procent podatku: " + this.procentPodatku + "%";
        }
}
}
