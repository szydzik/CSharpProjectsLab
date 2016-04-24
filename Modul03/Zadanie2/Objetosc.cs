using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Objetosc
    {
        private double litr;

        public Objetosc(double i, string s)
        {
            this.SetObjetosc(i, s);
        }

        /// <summary>
        /// Metoda ustawia pole litr w zaleznosci od uzytej jednostki
        /// </summary>
        /// <param name="i">value</param>
        /// <param name="s">litr, metr, kwaterka, galon</param>
        public void SetObjetosc(double i, string s)
        {
            switch (s)
            {
                case "litr":
                    litr = i;
                    break;
                case "metr":
                    litr = i * 1000;
                    break;
                case "kwaterka":
                    litr = i * 0.25;
                    break;
                case "galon":
                    litr = i * 4.5456;
                    break;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }

        /// <summary>
        /// Metoda zwraca objetosc w zadanych jednostkach
        /// </summary>
        /// <param name="s">litr, metr, kwaterka, galon</param>
        /// <returns></returns>
        public double GetObjetosc(string s)
        {
            switch (s)
            {
                case "litr":
                    return litr;
                case "metr":
                    return litr / 1000;
                case "kwaterka":
                    return litr / 0.25;
                case "galon":
                    return litr / 4.5456;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }


    }
}
