using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Praktykant:Osoba
    {
        private static double stypendium = 700;
        public Osoba Opiekun { get; set; }
        public bool CzyMaStypendium { get; set; }

        public Praktykant(string imie, string nazwisko, int rokUrodzenia, Osoba opiekun,bool czyMaStypendium)
            : base(imie,nazwisko,rokUrodzenia)
        {
            this.Opiekun = opiekun;
            this.CzyMaStypendium = czyMaStypendium;
        }

        public Praktykant(Osoba osoba, Osoba opiekun, bool czyMaStypendium)
            : base(osoba)
        {
            this.Opiekun = opiekun;
            this.CzyMaStypendium = czyMaStypendium;
        }

        public Praktykant(Praktykant praktykant)
            : base(praktykant.Imie,praktykant.Nazwisko,praktykant.RokUrodzenia)
        {
            this.Opiekun = praktykant.Opiekun;
            this.CzyMaStypendium = praktykant.CzyMaStypendium;
        }

        public double ZwrocPoborMiesieczny()
        {
            if (CzyMaStypendium)
            {
                return stypendium;
            }
            else
            {
                return 0;
            }
        }

        public new string ZwrocInformacje()
        {
            if (this.CzyMaStypendium)
            {
                return String.Format("Praktykant: {0}, posiada stypendium w wysokości: {1}, Opiekun: {2} ", base.ZwrocInformacje(), stypendium, this.Opiekun.ZwrocInformacje());
            }
            else
            {
                return String.Format("Praktykant: {0}, brak stypendium, Opiekun: {1} ", base.ZwrocInformacje(), this.Opiekun.ZwrocInformacje());
            }
            
        }
    }
}
