using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Dlugosc
    {
        private double metr;

        public Dlugosc(double i,string s)
        {
            SetDlugosc(i, s);
        }

        /// <summary>
        /// Metoda ustawia dlugosc
        /// </summary>
        /// <param name="i">Wielkość</param>
        /// <param name="s">Jednostka</param>
        public void SetDlugosc(double i,string s)
        {
            switch (s)
            {
                case "metr":
                    metr = i;
                    break;
                case "milimetr":
                    metr = i / 1000;
                    break;
                case "cal":
                    metr = i * 0.0254;
                    break;
                case "yard":
                    metr = i * 0.9144;
                    break;
                case "milamorska":
                    metr = i * 1852;
                    break;
                case "milaangielska":
                    metr = i * 1609.344;
                    break;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }

        /// <summary>
        /// Metoda oblicza i zwraca dlugiość
        /// </summary>
        /// <param name="s">Określa jednostkę</param>
        /// <returns>Metoda zwraca długość w podanej jednostce</returns>
        public double GetDlugosc(string s)
        {
            switch (s)
            {
                case "metr":
                    return metr;
                case "milimetr":
                    return metr * 1000;
                case "cal":
                    return metr / 0.0254;
                case "yard":
                    return metr / 0.9144;
                case "milamorska":
                    return metr / 1852;
                case "milaangielska":
                    return metr / 1609.344;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }
    }
}
