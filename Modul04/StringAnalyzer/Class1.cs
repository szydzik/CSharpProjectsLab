using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAnalyzer
{
    public static class Class1
    {
        public static char[] LettersUpperCase = new char[] { 'A', 'Ą', 'B', 'C', 'Ć', 'D', 'E', 'Ę', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'Ł', 'M', 'N', 'Ń', 'O', 'Ó', 'P', 'Q', 'R', 'S', 'Ś', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ź', 'Ż' };
        public static char[] LettersLowerCase = new char[] { 'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'q', 'r', 's', 'ś', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'ź', 'ż' };
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
            if (LettersUpperCase.Any(x => x.Equals(letter)) || LettersLowerCase.Any(x => x.Equals(letter)))
            {
                foreach (char c in s)
                {
                    if (Char.ToUpper(c) == Char.ToUpper(letter)) i++;
                    //if (c == letter) i++;
                }
                return i;
            }
            return -1;
        }

        public static int CountLetterAppears(this string s, char letter)
        {
            int i = 0;
            if (LettersUpperCase.Any(x => x.Equals(letter)))
            {
                foreach (char c in s)
                {
                    if (c == letter) i++;
                }
                return i;
            }
            else if (LettersLowerCase.Any(x => x.Equals(letter)))
            {
                foreach (char c in s)
                {
                    if (c == letter) i++;
                }
                return i;
            }
            return -1;
        }


    }
}
