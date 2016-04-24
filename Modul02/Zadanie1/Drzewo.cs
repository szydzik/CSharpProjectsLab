using System;
using System.Collections.Generic;
using System.Text;

using Osoba;

namespace Drzewa
{
    public class Drzewo : ICloneable
    {
        class Wezel
        {
            public Osoba.Osoba Dane;
            public Wezel Lewy=null, Prawy=null;

            public Wezel()
            {
                this.Dane = new Osoba.Osoba();
                this.Lewy = null;
                this.Prawy = null;
            }

            public Wezel(Osoba.Osoba osoba)
            {
                this.Dane = osoba;
                this.Lewy = null;
                this.Prawy = null;
            }

            public Wezel(string imie, string nazwisko, int rok, byte miesiac, byte dzien)
            {
                this.Dane = new Osoba.Osoba(imie, nazwisko, rok, miesiac, dzien);
                this.Lewy = null;
                this.Prawy = null;
            }

            public void WypiszWezel()
            {
                if (Lewy != null)
                    Lewy.WypiszWezel();
                Dane.WypiszOsobe();
                Console.WriteLine();
                if (Prawy != null)
                    Prawy.WypiszWezel();
            }


            //ogolnie to nie wiem czy dobrze to jest. Robi³em na oko i sprawdze potem :D
            public void KlonujRekurencyjnieGleboko(Wezel wezel)
            {
                wezel.Dane = new Osoba.Osoba(Dane);  // osoby s¹ kopiowane i s¹ niezale¿ne
                if (Lewy != null)
                {
                    wezel.Lewy = new Wezel();
                    Lewy.KlonujRekurencyjnieGleboko(wezel.Lewy);
                }
                if (Prawy != null)
                {
                    wezel.Prawy = new Wezel();
                    Prawy.KlonujRekurencyjnieGleboko(wezel.Prawy);
                }
            }

            public void KlonujRekurencyjnie(Wezel wezel)
            {
                wezel.Dane = Dane;  // osoby nie s¹ kopiowane
                if (Lewy != null)
                {
                    wezel.Lewy = new Wezel();
                    Lewy.KlonujRekurencyjnieGleboko(wezel.Lewy);
                }
                if (Prawy != null)
                {
                    wezel.Prawy = new Wezel();
                    Prawy.KlonujRekurencyjnieGleboko(wezel.Prawy);
                }
            }

        }
        private Wezel korzen = null;

        public Drzewo()
        {
            this.korzen = null;
        }

        public Drzewo(string imie, string nazwisko, int rok, byte miesiac, byte dzien)
        {
            DodajElement(new Osoba.Osoba(imie, nazwisko, rok, miesiac, dzien));
        }

        public Osoba.Osoba ZwrocOsobe()
        {
            if (korzen != null)
            {
                return korzen.Dane;
            }
            else
            {
                return null;
            }

        }



        public Drzewo(Osoba.Osoba[] osoby)
        {
            foreach (Osoba.Osoba osoba in osoby)
            {
                DodajElement(osoba);
            }
        }

        public bool CzyPuste()
        {
            return korzen == null;
        }

        public void DodajElement(Osoba.Osoba osoba)
        {
            if(korzen == null)
            {
                korzen = new Wezel();
                korzen.Dane = osoba;
                return ;
            }
            Wezel p = korzen, poprzedni;
            do{
                poprzedni = p;
                if(osoba.CompareTo(p.Dane )<0)
                    p = p.Lewy;
                else
                    p = p.Prawy;
            }
            while(p != null);
            if (osoba.CompareTo(poprzedni.Dane) < 0)
            {
                poprzedni.Lewy = new Wezel();
                poprzedni.Lewy.Dane = osoba;
            }
            else
            {
                poprzedni.Prawy = new Wezel();
                poprzedni.Prawy.Dane = osoba;
            }
        }   

        

        public void PrintAll()
        {
            if (korzen != null)
                korzen.WypiszWezel();
        }

        public Drzewo KopiujDrzewoGleboko()
        {
            Drzewo nowe = new Drzewo();
            if (korzen != null)
            {
                nowe.korzen = new Wezel();
                korzen.KlonujRekurencyjnieGleboko(nowe.korzen);
            }
            return nowe;
        }

        public Drzewo KopiujDrzewo()
        {
            Drzewo nowe = new Drzewo();
            if (korzen != null)
            {
                nowe.korzen = new Wezel();
                korzen.KlonujRekurencyjnie(nowe.korzen);
            }
            return nowe;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    }
