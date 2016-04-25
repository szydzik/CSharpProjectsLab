using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter;

namespace ConverterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double value;
            value = UnitConverter.Lenght.Convert(Lenght.UNIT.KILOMETER, 50, Lenght.UNIT.METER);
            Console.WriteLine("Wynik = {0}", value);
            value = UnitConverter.Quantity.Convert(Quantity.UNIT.PIECE, 75, Quantity.UNIT.THREESCORE);
            Console.WriteLine("Wynik = {0}", value);

            Console.ReadKey();
        }
    }
}
