using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestListy
{
    class Program
    {
        static void Main(string[] args)
        {
            Listy.Lista oryginal = new Listy.Lista();
            oryginal.DodajDoGlowy("Ania");
            oryginal.DodajDoGlowy("Agnieszka");
            oryginal.DodajDoGlowy("Wiktoria");
            oryginal.DodajDoGlowy("Kasia");

            Listy.Lista kopiaR = oryginal.KlonujRekurencyjnie();
            Listy.Lista kopiaI = oryginal.KlonujIteracyjnie();

            Console.WriteLine("Wypisujemy przed modyfikacjami: ");
            Console.WriteLine("\n***Oryginal: ");
            oryginal.WypiszWszystko();
            Console.WriteLine("***Kopia R: ");
            kopiaR.WypiszWszystko();
            Console.WriteLine("***Kopia I: ");
            kopiaI.WypiszWszystko();

            Console.WriteLine("\nModyfikujemy: ");
            Console.ReadKey();

            kopiaR.DodajDoGlowy("Zosia");
            kopiaR.DodajDoGlowy("Jola");
            kopiaI.UsunZGlowy();
            kopiaI.UsunZGlowy();

            Console.WriteLine("\n***Oryginal: ");
            oryginal.WypiszWszystko();
            Console.WriteLine("***Kopia R: ");
            kopiaR.WypiszWszystko();
            Console.WriteLine("***Kopia I: ");
            kopiaI.WypiszWszystko();

            Console.ReadKey();


        }
    }
}
