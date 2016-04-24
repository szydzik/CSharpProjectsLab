using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jednostka1, jednostka2;
            double wartosc;
            Console.Write("Podaj jednostke masy: [kilogram, gram, tona, kwintal, funt, uncja]: ");
            jednostka1 = Console.ReadLine();

            do
            {
                Console.Write("Podaj wartość: ");
            } while (!double.TryParse(Console.ReadLine(), out wartosc));
            Masa masa = new Masa(wartosc, jednostka1);


            Console.Write("Podaj jednostke wyjściową masy: [kilogram, gram, tona, kwintal, funt, uncja]: ");
            jednostka2 = Console.ReadLine();

            Console.WriteLine("{0} {1}, to {2} {3}", wartosc, jednostka1, masa.GetMasa(jednostka2), jednostka2);


            Console.ReadKey();


        }
    }
}
