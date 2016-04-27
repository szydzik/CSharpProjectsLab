using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Macierze;

namespace TestMacierzy
{
    static class MacierzDlaKonsoli
    {
        public static void WypiszMacierz(this Macierz a)
        {
            Console.Write("[ ");
            for (int i = 1; i <= a.LiczbaWierszy; i++)
            {
                Console.Write("<");
                for ( int j = 1; j<= a.LiczbaKolumn; j++)
                {
                    Console.Write(a[i,j]);
                    if ( j!= a.LiczbaKolumn)
                    {
                        Console.Write("; ");
                    }
                }
                Console.Write("> ");
            }
            Console.Write("]");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
