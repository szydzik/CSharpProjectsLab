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
            string s = "daoPrzyciakladowy ciag znakowciap Dao dao DaO";
            string s2 = "aiou pkl";
            Console.WriteLine(s.CountCharAppears('a'));
            Console.WriteLine(s.CountStringAppears("cia"));
            Console.WriteLine(s.CountLetterUpperAndLowerAppears('p'));
            Console.WriteLine(s.CountLetterAppears('p'));
            Console.WriteLine(s.CountPhraseAppears("dao"));
            Console.WriteLine(s.CountPhraseIgnoreCaseAppears("dao"));
            Console.WriteLine(s.CountLetters());
            Console.WriteLine(s2.CountVovelAppears());
            Console.WriteLine(s2.CountConsonatAppears());
            Console.WriteLine(s.CountDigits());
            Console.WriteLine(s.CountAlphanumericCharacters());
            Console.WriteLine(s.CountWhiteSpaces());
            Console.ReadKey();
        }
    }
}
