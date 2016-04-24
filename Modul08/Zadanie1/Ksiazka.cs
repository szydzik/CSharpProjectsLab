using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class Ksiazka
    {
        public int? ID { get; set; }
        public string Autorzy { get; set; }  //trzeba dodać możliwość dodania kilku autorów
        public string Tytul { get; set; }
        public int RokWydania { get; set; }
        public string Wydawnictwo { get; set; }
        public string ISBN { get; set; }

        public Ksiazka(int id, string autorzy, string tytul, int rokWydania, string wydawnictwo, string ISBN)
        {
            this.ID = id;
            this.Autorzy = autorzy;
            this.Tytul = tytul;
            this.RokWydania = rokWydania;
            this.Wydawnictwo = wydawnictwo;
            this.ISBN = ISBN;
        }

        public Ksiazka(string autorzy, string tytul, int rokWydania, string wydawnictwo, string ISBN)
        {
            this.ID = null;
            this.Autorzy = autorzy;
            this.Tytul = tytul;
            this.RokWydania = rokWydania;
            this.Wydawnictwo = wydawnictwo;
            this.ISBN = ISBN;
        }
        public Ksiazka()
        {
            this.ID = null;

            Console.Write("Podaj tytuł: ");
            this.Tytul = Console.ReadLine();

            Console.Write("Podaj Autorów: ");
            this.Autorzy = Console.ReadLine();

            Console.Write("Podaj rok wydania: ");
            this.RokWydania = int.Parse(Console.ReadLine());

            Console.Write("Podaj wydawnictwo: ");
            this.Wydawnictwo = Console.ReadLine();

            Console.Write("Podaj ISBN: ");
            this.ISBN = Console.ReadLine();

        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5}", ID, Autorzy, Tytul, RokWydania, Wydawnictwo, ISBN);
        }


    }
}
