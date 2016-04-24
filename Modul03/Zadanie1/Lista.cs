using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    /// <summary>
    /// Lista LIFO
    /// </summary>
    public class Lista
    {
        class Wezel
        {
            public Towar Dane;
            public Wezel Nastepny;
        }

        private Wezel glowa = null;

        /// <summary>
        /// Znajduje Wezel o danym indeksie
        /// </summary>
        /// <param name="indeks">indeks Wezla</param>
        /// <returns>Wezel o podanym indeksie</returns>
        private Wezel ZnajdzWezel(int indeks)
        {
            int i = 0;
            Wezel tmp = glowa;
            while (tmp != null && i < indeks)
            {
                tmp = tmp.Nastepny;
                i++;
            }
            if (tmp == null)
            {
                throw new IndexOutOfRangeException("Nie ma elementu o podanym indeksie. ");
            }
            return tmp;
        }

        /// <summary>
        /// Znajduje wezel zawierający towar o zadanej nazwie
        /// </summary>
        /// <param name="nazwa"></param>
        /// <returns>Wezel zawierający towar lub null, gdy nie znaleziono</returns>
        private Wezel ZnajdzWezel(string nazwa)
        {
            int i = 0;
            Wezel tmp = glowa;
            while (tmp != null)
            {
                //if (tmp.Dane.Nazwa.Equals(nazwa)) break;
                tmp = tmp.Nastepny;

            }
            if (tmp == null)
            {
                throw new IndexOutOfRangeException("Nie ma elementu o podanej nazwie. ");
            }
            return tmp;
        }

        /// <summary>
        /// Pozwala odwołać się do elementu po indeksie - odczyt / zapis
        /// </summary>
        /// <param name="indeks"></param>
        /// <returns>Towar z listy lub null, gdy nie ma elementu na liście o danym indeksie</returns>
        public Towar this[int indeks]
        {
            get { return ZnajdzWezel(indeks).Dane; }
            set { ZnajdzWezel(indeks).Dane = value; }
        }

        /// <summary>
        /// Pozwala odwołać się do elementu po nazwie - tylko do odczytu!
        /// </summary>
        /// <param name="nazwa">Nazwa elementu do wyszukania</param>
        /// <returns>Towar z listy lub null, gdy nie ma elementu na liście o danej nazwie</returns>
        public Towar this[string nazwa]
        {
            get { return ZnajdzWezel(nazwa).Dane; }
            //set { ZnajdzWezel(nazwa).Dane = value; }
        }

        public bool CzyPusta()
        {
            return glowa == null;
        }

        /// <summary>
        /// Dodaje element do listy
        /// </summary>
        /// <param name="s"></param>
        public void DodajDoGlowy(Towar s)
        {
            Wezel tmp = new Wezel();
            tmp.Dane = s;
            tmp.Nastepny = glowa;
            glowa = tmp;
        }


        /// <summary>
        /// Usuwa element z listy
        /// </summary>
        /// <returns>Zwraca usuniety element</returns>
        public Towar UsunZGlowy()
        {
            if (glowa == null)           //lista pusta
                throw new InvalidOperationException("Lista jest pusta. ");
            Towar x = glowa.Dane;
            glowa = glowa.Nastepny;
            return x;
        }

        /// <summary>
        /// Wyswietla dane
        /// </summary>
        public void WypiszWszystko()
        {
            for (Wezel tmp = glowa; tmp != null; tmp = tmp.Nastepny)
            {
                Console.WriteLine(tmp.Dane);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns>Zwraca liczbę elementów</returns>
        public int PobierzLiczbeElementow()
        {
            int i;
            Wezel tmp;
            for (i = 0, tmp = glowa; tmp != null; i++, tmp = tmp.Nastepny) ;
            return i;
        }

        /// <summary>
        /// Obliczanie sumy cen netto wsyztskich towarów na liście
        /// </summary>
        /// <returns>Zwraca calkowitą cenę netto towarów z faktury</returns>
        public double CenaCalkNetto()
        {
            double cena = 0;
            Wezel tmp = glowa;
            while (tmp != null)
            {
                cena += tmp.Dane.CenaCalkNetto;
                tmp = tmp.Nastepny;
            }
            return cena;
        }

        /// <summary>
        /// Obliczanie sumy cen brutto wsyztskich towarów na liście
        /// </summary>
        /// <returns>Zwraca calkowitą cenę brutto towarów z faktury</returns>
        public double CenaCalkBrutto()
        {
            double cena = 0;
            Wezel tmp = glowa;
            while (tmp != null)
            {
                cena += tmp.Dane.CenaCalkBrutto;
                tmp = tmp.Nastepny;
            }
            return cena;
        }

    }
}
