using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbiory
{
    public class ZbiorNapisow
    {
        private List<string> napisy = new List<string>();
        public void DodajElement(string s)
        {
            if (!napisy.Contains(s)) napisy.Add(s);
        }

        public bool CzyElementNalezy(string element)
        {
            return napisy.Contains(element);
        }

        public string this[int indeks]
        {
            get { return napisy[indeks]; }
        }

        public int MocZbioru
        {
            get { return napisy.Count; }
        }

        public static ZbiorNapisow operator +(ZbiorNapisow a, ZbiorNapisow b)
        {
            ZbiorNapisow c = new ZbiorNapisow();
            foreach (string s in a.napisy)
            {
                c.DodajElement(s);
            }
            foreach (string s in b.napisy)
            {
                c.DodajElement(s);
            }
            return c;
        }

        public static ZbiorNapisow operator -(ZbiorNapisow a, ZbiorNapisow b)
        {
            ZbiorNapisow c = new ZbiorNapisow();
            foreach (string s in a.napisy)
            {
                if (!b.CzyElementNalezy(s))
                {
                    c.DodajElement(s);
                }
            }
            return c;
        }

        public static ZbiorNapisow operator *(ZbiorNapisow a, ZbiorNapisow b)
        {
            ZbiorNapisow c = new ZbiorNapisow();
            foreach (string s in a.napisy)
            {
                if (b.CzyElementNalezy(s))
                {
                    c.DodajElement(s);
                }
            }
            return c;
        }


    }
}
