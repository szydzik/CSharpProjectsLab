using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAnalyzer
{
    public static class Class1
    {
        /// <summary>
        /// Metoda liczy ilość wystąpień znaku podanego jako parametr
        /// </summary>
        /// <param name="s">Ciąg znaków który będzie przeszukiwany</param>
        /// <param name="search">Szukany znak</param>
        /// <returns>Ilość wystąpień znaku</returns>
        public static int CountCharAppears(this string s, char search)
        {
            int i = 0;
            foreach (char c in s)
            {
                if (c == search) i++;
            }
            return i;
        }

        /// <summary>
        /// Metoda liczy ilość wystąpień określonego ciągu znaków
        /// </summary>
        /// <param name="s">Ciąg znaków który będzie przeszukiwany</param>
        /// <param name="search">Szukany ciąg znaków</param>
        /// <returns>Ilość wystąpień szukanego ciągu znaków w innym</returns>
        public static int CountStringAppears(this string s, string search)
        {
            return s.Split(new string[] { search }, StringSplitOptions.None).Length - 1;
        }

        public static int CountLetterUpperAndLowerAppears(this string s, char letter)
        {
            int i = 0;
            if (Char.IsLetter(letter))
            {
                foreach (char c in s)
                {
                    if (Char.ToUpper(c) == Char.ToUpper(letter)) i++;
                }
                return i;
            }
            return -1;
        }

        public static int CountLetterAppears(this string s, char letter)
        {
            int i = 0; 
            if (Char.IsLetter(letter))
            {
                foreach (char c in s)
                {
                    if (c == letter) i++;
                }
                return i;
            }
            return -1; // value -1 nie wprowadzono poprawnego znaku 
        }

        //nie wiem czym odróżnić frazę od ciągu znaków więc jest tak samo jak wcześniej :P
        public static int CountPhraseAppears(this string s,string phrase)
        {
            return s.Split(new string[] { phrase }, StringSplitOptions.None).Length - 1;
        }

        public static int CountPhraseIgnoreCaseAppears(this string s,string phrase)
        {
            string tempstring = "";
            string tempphrase = "";
            foreach(char c in s)
            {
                tempstring += char.ToUpper(c);
            }
            foreach(char c in phrase)
            {
                tempphrase += char.ToUpper(c);
            }
            return tempstring.Split(new string[] { tempphrase }, StringSplitOptions.None).Length - 1;
        }

        public static int CountAllLetters(this string s)
        {
            int i = 0;
            foreach(char c in s)
            {
                if (char.IsLetter(c)) i++;
            }
            return i;
        }

    }
}
