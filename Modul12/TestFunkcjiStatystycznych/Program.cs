using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Statystyka;

namespace TestFunkcjiStatystycznych
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] tab = { 2, 3, 6, 9 };
            Console.WriteLine("Liczba elementów tablicy większych od pięciu:" + FunkcjeStatystyczne.Ilosc(tab, p => p > 5));
            Console.WriteLine("Suma elementów tablicy większych od pięciu:" + FunkcjeStatystyczne.Suma(tab, p => p > 5));
            Console.WriteLine("Średnia elementów tablicy większych od pięciu:" + FunkcjeStatystyczne.SredniaArytmetyczna(tab, p => p > 5));
            Console.WriteLine("Największy z elementów tablicy większych od pięciu:" + FunkcjeStatystyczne.Maksimum(tab, p => p > 5));
            Console.WriteLine("Najmniejszy z elementów tablicy większych od pięciu:" + FunkcjeStatystyczne.Minimum(tab, p => p > 5));
            Console.ReadKey();

        }
    }
}
