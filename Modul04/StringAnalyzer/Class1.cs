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

        public static int CountPhraseAppears(this string s, string phrase)
        {
            return s.Split(new string[] { phrase }, StringSplitOptions.None).Length - 1;
        }

        public static int CountPhraseIgnoreCaseAppears(this string s, string phrase)
        {
            return s.ToUpper().Split(new string[] { phrase.ToUpper() }, StringSplitOptions.None).Length - 1;
        }

        public static int CountLetters(this string s)
        {
            int i = 0;
            foreach (char c in s)
            {
                if (Char.IsLetter(c)) i++;
            }
            return i;
        }

        private static bool IsVovel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y'
                || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' || c == 'Y';
        }
        private static bool IsConsonant(char c)
        {
            return c == 'b' || c == 'c' || c == 'd' || c == 'f' || c == 'g' || c == 'h' || c == 'j' || c == 'k' || c == 'l' || c == 'm' ||
                   c == 'n' || c == 'p' || c == 'q' || c == 'r' || c == 's' || c == 't' || c == 'v' || c == 'w' || c == 'x' || c == 'z' ||
                   c == 'B' || c == 'C' || c == 'D' || c == 'F' || c == 'G' || c == 'H' || c == 'J' || c == 'K' || c == 'L' || c == 'M' ||
                   c == 'N' || c == 'P' || c == 'Q' || c == 'R' || c == 'S' || c == 'T' || c == 'V' || c == 'W' || c == 'X' || c == 'Z';
        }

        public static int CountVovelAppears(this string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                if (IsVovel(s[i]))
                {
                    sum++;
                }
            }
            return sum;
        }

        public static int CountConsonatAppears(this string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                if (IsConsonant(s[i]))
                {
                    sum++;
                }
            }
            return sum;
        }

        public static int CountDigits(this string s)
        {
            int i = 0;
            foreach (char c in s)
            {
                if (Char.IsDigit(c)) i++;
            }
            return i;
        }

        public static int CountAlphanumericCharacters(this string s)
        {
            int i = 0;
            foreach (char c in s)
            {
                if (Char.IsLetterOrDigit(c)) i++;
            }
            return i;
        }

        public static int CountWhiteSpaces(this string s)
        {
            int i = 0;
            foreach (char c in s)
            {
                if (Char.IsWhiteSpace(c)) i++;
            }
            return i;
        }

        public static int CountLowerCaseLetters(this string s)
        {
            int i = 0;
            foreach (char c in s)
            {
                if (char.IsLower(c)) i++;
            }
            return i;
        }

        public static int CountUpperCaseLetters(this string s)
        {
            int i = 0;
            foreach (char c in s)
            {
                if (char.IsUpper(c)) i++;
            }
            return i;
        }

    }
}
