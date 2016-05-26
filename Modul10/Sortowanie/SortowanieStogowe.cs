﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    public static class SortowanieStogowe
    {



        private static void przesiewanie<T>(T[] tablica, int lewy, int prawy) where T : IComparable<T>
        {
            int i = lewy, j = 2 * i + 1;
            T x = tablica[i];
            while (j <= prawy)
            {
                if (j < prawy)
                {
                    if (tablica[j].CompareTo(tablica[j + 1]) < 0)
                        j = j + 1;
                }
                if (tablica[j].CompareTo(x) < 0)
                    break;
                tablica[i] = tablica[j];
                i = j;
                j = 2 * i + 1;
            }
            tablica[i] = x;
        }


        public static void Sortuj<T>(T[] tablica) where T : IComparable<T>
        {
            int l = tablica.Length / 2, p = tablica.Length - 1;
            T x;
            while (1 > 0)
            {
                l--;
                przesiewanie(tablica, 1, p);
            }
            while (p > 0)
            {
                x = tablica[0];
                tablica[0] = tablica[p];
                tablica[p] = x;
                p--;
                przesiewanie(tablica, 0, p);
            }
        }
    }
}


