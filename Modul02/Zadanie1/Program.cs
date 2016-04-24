using Drzewa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba.Osoba[] osoby = new Osoba.Osoba[4];

            for (int i=0; i<=3; i++)
            {
                osoby[i] = new Osoba.Osoba();
                osoby[i].WprowadzOsobe();
            }

            Console.WriteLine("Drzewo 1 - Baza");
            Drzewo drzewo1 = new Drzewo(osoby);
            drzewo1.PrintAll();

            Console.WriteLine("Drzewo 2 - kopiowanie glebokie");
            Drzewo drzewo2 = drzewo1.KopiujDrzewoGleboko();
            drzewo2.PrintAll();

            Console.WriteLine("Drzewo 3 - kopiowanie - osoby są powiązane");
            Drzewo drzewo3 = drzewo1.KopiujDrzewo();
            drzewo3.PrintAll();

            Console.WriteLine("Drzewo 4 - kopiowanie glebokie");
            Drzewo drzewo4 = (Drzewo) drzewo1.Clone();
            drzewo4.PrintAll();

            if(drzewo1.ZwrocOsobe() == drzewo2.ZwrocOsobe())
            {
                Console.WriteLine("drzewo1.ZwrocOsobe() == drzewo2.ZwrocOsobe() ===> true");
            }
            else
            {
                Console.WriteLine("drzewo1.ZwrocOsobe() == drzewo2.ZwrocOsobe() ===> false");
            }

            if (drzewo1.ZwrocOsobe() == drzewo3.ZwrocOsobe())
            {
                Console.WriteLine("drzewo1.ZwrocOsobe() == drzewo3.ZwrocOsobe() ===> true");
            }
            else
            {
                Console.WriteLine("drzewo1.ZwrocOsobe() == drzewo3.ZwrocOsobe() ===> false");
            }

            if (drzewo1.ZwrocOsobe() == drzewo4.ZwrocOsobe())
            {
                Console.WriteLine("drzewo1.ZwrocOsobe() == drzewo4.ZwrocOsobe() ===> true");
            }
            else
            {
                Console.WriteLine("drzewo1.ZwrocOsobe() == drzewo4.ZwrocOsobe() ===> false");
            }
     


            Console.ReadKey();


        }
    }
}
