using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Samochody;

namespace TestSamochodu
{
    class Program
    {
        static void Main(string[] args)
        {

            Silnik silnik1 = new Silnik(2.2, 123);
            Silnik silnik2 = new Silnik(2.2, 123);
            Osoba osoba1 = new Osoba() { Nazwisko = "Kowalski", Imie = "Jan" };
            Osoba osoba2 = new Osoba() { Nazwisko = "Nowak", Imie = "Paweł" };

            Samochod s1 = new Samochod(osoba1, "A2", "Audi", 2001, silnik1);
            Samochod s2 = new Samochod(osoba2, "A2", "Audi", 2001, silnik1);
            Samochod s3 = new Samochod(osoba1, "A2", "Audi", 2001, silnik2);

            Console.WriteLine("Samochód s1: {0}", s1);
            Console.WriteLine("Samochód s2: {0}", s2);
            Console.WriteLine("Samochód s1: {0}\n", s3);

            Console.WriteLine("Samochód s1 kod skrótu: {0}", s1.GetHashCode());
            Console.WriteLine("Samochód s2 kod skrótu: {0}", s2.GetHashCode());
            Console.WriteLine("Samochód s3 kod skrótu: {0}", s3.GetHashCode());

            Console.WriteLine("s1 i s2 są sobie równe to: {0}", s1.Equals(s2));
            Console.WriteLine("s1 i s3 są sobie równe to: {0}", s1.Equals(s3));
            Console.WriteLine("s2 i s3 są sobie równe to: {0}", s3.Equals(s2));

            Console.ReadKey();
        }
    }
}