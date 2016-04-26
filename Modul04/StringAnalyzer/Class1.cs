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
        public static int Countcharappear(this string s,char search)
        {
            int i = 0;
            foreach(char c in s){
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
        public static int Countstringappear(this string s,string search)
        {
            int i = 0;
            i = s.Split(new string[] { search }, StringSplitOptions.None).Length-1;
            return i;
        }
    }
}
