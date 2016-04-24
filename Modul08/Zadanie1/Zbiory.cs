using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Zbiory
    {
        public virtual void Dodaj()
        {

            Console.WriteLine("DODAWANIE DO BAZY");
        }

        public virtual void Zapisz()
        {
            Console.WriteLine("ZAPISYWANIE DO BAZY");
        }
        public virtual void OdczytMaterialow()
        {
            Console.WriteLine("ODCZYT");
        }
        public virtual void InfoMaterialy()
        {
            Console.WriteLine("INFO");
        }
    }
}
