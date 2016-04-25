using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Converter;

namespace ConverterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = Converter.Lenght.Convert(Lenght.UNIT.KILOMETER, 50, Lenght.UNIT.METER);
            Console.WriteLine("Wynik = {0}", value);
            Console.ReadKey();
        }
    }
}
