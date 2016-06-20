using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statystyka
{
    public static class FunkcjeStatystyczne
    {
        public static int Ilosc(IEnumerable<double> tab, Func<double,bool> kryterium)
        {
            int i = 0;
            foreach(double d in tab)
            {
                if (kryterium(d))
                {
                    i++;
                }
            }
            return i;
        }

        public static double Suma(IEnumerable<double> tab,Func<double,bool> kryterium)
        {
            double suma = 0;
            foreach(double d in tab)
            {
                if (kryterium(d))
                {
                    suma += d;
                }
            }
            return suma;
        }

        public static double SredniaArytmetyczna(IEnumerable<double> tab, Func<double, bool> kryterium)
        {
            double suma = 0;
            int i = 0;
            foreach (double d in tab)
            {
                if (kryterium(d))
                {
                    suma += d;
                    i++;
                }
            }
            if (i == 0)
            {
                throw new ArgumentException("Żaden element kolekcji nie spełnia kryterium");
            }
            return suma/i;
        }

        public static double Maksimum(IEnumerable<double> tab, Func<double,bool> kryterium)
        {
            bool znaleziono = false;
            double max = double.MinValue;
            foreach (double f in tab)
            {
                if (kryterium(f) && (f>max || !znaleziono))
                {
                    max = f;
                    znaleziono = true;
                }
            }
            if (!znaleziono)
            {
                throw new InvalidOperationException("Nie znaleziono żadnego elementu, który spełnia kryterium");
            }
            return max;
        }

        public static double Minimum(IEnumerable<double> tab, Func<double, bool> kryterium)
        {
            bool znaleziono = false;
            double min = double.MinValue;
            foreach (double f in tab)
            {
                if (kryterium(f) && (f < min || !znaleziono))
                {
                    min = f;
                    znaleziono = true;
                }
            }
            if (!znaleziono)
            {
                throw new InvalidOperationException("Nie znaleziono żadnego elementu, który spełnia kryterium");
            }
            return min;
        }
    }
}
