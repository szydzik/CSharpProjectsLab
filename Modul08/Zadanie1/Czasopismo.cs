using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public enum RODZAJ { DZIENNIK, TYGODNIK, DWUTYGODNIK, MIESIECZNIK, KWARTALNIK}
    public class Czasopismo
    {

        public int? ID { get; set; }
        public string Tytul { get; set; }
        public string Numer { get; set; } //np 13/2015
        public int RokWydania { get; set; }
        public RODZAJ Rodzaj {get; set;}


        public Czasopismo(int id, string tytul, string numer, int rokWydania, RODZAJ rodzaj)
        {
            this.ID = id;
            this.Tytul = tytul;
            this.Numer = numer;
            this.RokWydania = rokWydania;
            this.Rodzaj = rodzaj;
        }

        public Czasopismo(string tytul, string numer, int rokWydania, RODZAJ rodzaj)
        {
            this.ID = null;
            this.Tytul = tytul;
            this.Numer = numer;
            this.RokWydania = rokWydania;
            this.Rodzaj = rodzaj;
        }

        public Czasopismo()
        {
            this.ID = null;
            Console.Write("Podaj tytuł: ");
            this.Tytul = Console.ReadLine();

            Console.Write("Podaj numer: ");
            this.Numer = Console.ReadLine();

            Console.Write("Podaj rok wydania: ");
            this.RokWydania = int.Parse(Console.ReadLine());

            Console.Write("Podaj rodzaj: ");
            this.Rodzaj = (RODZAJ)int.Parse(Console.ReadLine());
           
                

            
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4}", ID, Tytul, Numer, RokWydania, Rodzaj.ToString());
        }

    }
}
