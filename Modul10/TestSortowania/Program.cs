using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sortowanie;

namespace TestSortowania
{
    class Program
    {

        static void Main(string[] args)
        {

            double[] tabl = { 22.3, 3.5, 1, 7.8, 6.5 };
            string[] imiona = { "Paweł", "Ania", "Karol", "Piotr" };
            SortowanieStogowe.Sortuj(tabl);
            SortowanieStogowe.Sortuj(imiona);
            Console.Write("Imiona: ");
            foreach (string s in imiona)
            {
                Console.Write("{0}, ", s);
            }
            Console.Write("\nLiczby: ");
            foreach (double x in tabl)
            {
                Console.Write("{0}; ", x);
            }
            Console.ReadKey();


            //Osoba[] osoby = {
            //new Osoba{Imie="Dan", Nazwisko="Kowalski"},
            //new Osoba{Imie="TomaszM", Nazwisko="Nowak"},
            //new Osoba{Imie="Marek", Nazwisko="Markowski"}
            //};

            //SortowanieStogowe.Sortuj<Osoba>(osoby);


        }


    }

    //class Osoba
    //{
    //    public string Imie { get; set; }
    //    public string Nazwisko { set; get; }


    //}

}
