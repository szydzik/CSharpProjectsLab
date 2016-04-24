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
            //testowanie
            Lista lista = new Lista();
            lista.DodajDoGlowy(new Towar());
            lista.DodajDoGlowy(new Towar("Mąka", "kg", 3, 10, 23));
            Faktura faktura = new Faktura(new DateTime(2016,4,2),new DateTime(2016,4,20),"ASD-123ds", lista);
            Console.WriteLine("Cena netto:{0}, cena brutto: {1}", faktura.CenaNetto, faktura.CenaBrutto);
            Console.ReadKey();
        }
    }
}
