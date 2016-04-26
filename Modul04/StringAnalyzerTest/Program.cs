using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringAnalyzer;

namespace StringAnalyzerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Przyciakladowy ciag znakowciap";
            Console.WriteLine(s.CountCharAppears('a'));
            Console.WriteLine(s.CountStringAppears("cia"));
            Console.WriteLine(s.CountLetterUpperAndLowerAppears('p'));
            Console.WriteLine(s.CountLetterAppears('p'));
            Console.ReadKey();
        }
    }
}
