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
            Listy.Lista imiona = new Listy.Lista();
            imiona.DodajDoGlowy("Ania");
            imiona.DodajDoGlowy("Agnieszka");
            imiona.DodajDoGlowy("Wiktoria");
            imiona.DodajDoGlowy("Kasia");
            for (int i = 0; i < imiona.PobierzLiczbeElementow(); i++)
            {
                Console.WriteLine("{0}. {1}", i, imiona[i]);
            }
            imiona[1] = "Basia";
            imiona[3] = "Ola";
            for (int i = 0; i < imiona.PobierzLiczbeElementow(); i++)
            {
                Console.WriteLine("{0}. {1}", i, imiona[i]);
            }
            Console.ReadKey();
        }
    }
}
