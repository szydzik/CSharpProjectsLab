using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2test
{
    class Ilosc
    {
        private double sztuki;

        public Ilosc(double i,string s)
        {
            SetIlosc(i, s);  
        }

        /// <summary>
        /// Ustawianie ilości w podanej jednostce
        /// </summary>
        /// <param name="i">Wielkość</param>
        /// <param name="s">Jednostka</param>
        public void SetIlosc(double i, string s)
        {
            switch (s)
            {
                case "sztuk":
                    sztuki = i;
                    break;
                case "kopa":
                    sztuki = i * 60;
                    break;
                case "tuzin":
                    sztuki = i * 12;
                    break;
                case "mendel":
                    sztuki = i * 15;
                    break;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }

        /// <summary>
        /// Oblicza oraz zwraca wielkość w podanej jednostce jako parametr
        /// </summary>
        /// <param name="s">Jednostka</param>
        /// <returns>Zwraca wielkość w podanej jednostce</returns>
        public double GetIlosc(string s)
        {
            switch (s)
            {
                case "sztuk":
                    return sztuki;
                case "kopa":
                    return sztuki / 60;
                case "tuzin":
                    return sztuki / 12;
                case "mendel":
                    return sztuki / 15;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }
    }
}
