using Osoby;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOsob
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba("Jan", "Kowalski", 1998, Plec.Mezczyzna);
            Console.WriteLine("Utworzyłeś osobę: {0}", o1.ZwrocInformacje());

            Student s1 = new Student("Tomasz", "Nowak", 1989, Plec.Mezczyzna, 1234);
            Console.WriteLine("Utworzyłeś studenta: {0}", s1.ZwrocInformacje());

            Stypendysta st1 = new Stypendysta("Joanna", "Zielińska", 1987, Plec.Kobieta, 1234, 500);
            Console.WriteLine("Utworzyłeś stypendystę: {0}", st1.ZwrocInformacje());

            Wykladowca w1 = new Wykladowca("Maria","Skłodowska-Curie", 1867, Plec.Kobieta, Wykladowca.Tytuly.prof);
            Console.WriteLine("Utworzyłeś wykładowcę: {0}", w1.ZwrocInformacje());

            Console.ReadKey();

            Osoba o2 = s1, o3 = st1, o4 = w1;
            Console.WriteLine("Utworzyłeś osobę: {0}", o2.ZwrocInformacje());
            Console.WriteLine("Utworzyłeś osobę: {0}", o3.ZwrocInformacje());
            Console.WriteLine("Utworzyłeś osobę: {0}", o4.ZwrocInformacje());

            Console.ReadKey();

        }
    }
}
