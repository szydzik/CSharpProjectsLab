using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class PracownikFizyczny : Osoba
    {

        public Kierownik Kierownik { get; set; }
        public string Umiejetnosci { get; set; }
        public int StawkaGodzinowa { get; set; }
        public int LiczbaPrzepracowanychGodzin { get; set;}
        public int LiczbaNadgodzin { get; set;}


        public double ZwrocPoborMiesieczny()
        {
            return ((StawkaGodzinowa * LiczbaPrzepracowanychGodzin) + (1.5 * StawkaGodzinowa * LiczbaNadgodzin));
        }

        public PracownikFizyczny(string imie, string nazwisko, int rokUrodzenia,int stawkaGodzinowa, int liczbaPrzepracowanychGodz, int liczbaNadgodzin, Kierownik kierownik, string umiejetnosci)
            : base(imie, nazwisko, rokUrodzenia)
        {
            this.StawkaGodzinowa = stawkaGodzinowa;
            this.LiczbaPrzepracowanychGodzin = liczbaPrzepracowanychGodz;
            this.LiczbaNadgodzin = liczbaNadgodzin;
            this.Kierownik = kierownik;
            this.Umiejetnosci = umiejetnosci;
        }

        public PracownikFizyczny(PracownikFizyczny pracownikFizyczny)
            : base(pracownikFizyczny.Imie, pracownikFizyczny.Nazwisko, pracownikFizyczny.RokUrodzenia)
        {
            this.StawkaGodzinowa = pracownikFizyczny.StawkaGodzinowa;
            this.LiczbaPrzepracowanychGodzin = pracownikFizyczny.LiczbaPrzepracowanychGodzin;
            this.LiczbaNadgodzin = pracownikFizyczny.LiczbaNadgodzin;
            this.Kierownik = pracownikFizyczny.Kierownik;
            this.Umiejetnosci = pracownikFizyczny.Umiejetnosci;
        }


        public PracownikFizyczny(Osoba osoba, int stawkaGodzinowa, int liczbaPrzepracowanychGodz, int liczbaNadgodzin, Kierownik kierownik, string umiejetnosci)
            : base(osoba)
        {
            this.StawkaGodzinowa = stawkaGodzinowa;
            this.LiczbaPrzepracowanychGodzin = liczbaPrzepracowanychGodz;
            this.LiczbaNadgodzin = liczbaNadgodzin;
            this.Kierownik = kierownik;
            this.Umiejetnosci = umiejetnosci;
        }

        public new string ZwrocInformacje()
        {      
            //info o kierowniku zmieni się na zwrot info z klasy kierownik 
            return string.Format("Pracownik fizyczny: {0}, Stawka godzinowa: {1}zł, Przepracowane godziny: {2}, Nadgodziny {3}\n Umiejętności: {4}\n Kierownik: {5} ", base.ZwrocInformacje(), StawkaGodzinowa, LiczbaPrzepracowanychGodzin,LiczbaNadgodzin,Umiejetnosci,Kierownik.ZwrocInformacje());
        }
    }
}
