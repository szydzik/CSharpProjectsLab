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
                string s = "Przyciakladowy ciag znakowcia";
                Console.WriteLine(s.Countcharappear('a'));
                Console.WriteLine(s.Countstringappear("cia"));
                Console.ReadKey();
        }
    }
}
