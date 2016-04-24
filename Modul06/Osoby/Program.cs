using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoby
{
    class Program
    {
        static void Main(string[] args)
        {
            Stypendysta s = new Stypendysta("Bartosz", "Sosnowski", 1994, Plec.Mezczyzna, 104863, 123);
            Console.WriteLine(s.ZwrocInformacje());
            Console.ReadKey();
        }
    }
}
