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

            Osoba os1 = new Osoba("Tomasz", "Jurkowski", 1993);

            Kierownik k1 = new Kierownik(new Osoba("Bartosz", "Szydzik", 1994), 10000, 20, 1500, "123-456-789", 21, "Dział promocji");
            Console.WriteLine(k1.ZwrocInformacje());

            CzlonekZarzadu c1 = new CzlonekZarzadu(new Osoba("Bartosz", "Sosnowwski", 1994), 4000, 5, (Osoba) k1);
            Console.WriteLine(c1.ZwrocInformacje());

            //zmiana Imienia kierownika k1 (2 sposoby)
            Osoba os2 = (Osoba)k1;
            os2.Imie = "Radosław"; 
            Console.WriteLine(k1.ZwrocInformacje());
            k1.Imie = "Stefan";
            Console.WriteLine(k1.ZwrocInformacje());


            Console.ReadKey();
        }
    }
}
