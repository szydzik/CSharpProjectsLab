using System;
using System.Collections.Generic;
using System.Text;

namespace Listy
{
    public class Lista
    {
        class Wezel
        {
            public string Dane;
            public Wezel Nastepny;

        }

        private Wezel glowa=null;

        private Wezel ZnajdzWezel(int indeks)
        {
            int i = 0;
            Wezel tmp = glowa;
            while(tmp!=null && i < indeks)
            {
                tmp = tmp.Nastepny;
                i++;
            }
            if (tmp == null)
            {
                throw new IndexOutOfRangeException("Nie ma elementu o podanym indeksie");
            }
            return tmp;
        }

        public string this[int indeks]
        {
            get { return ZnajdzWezel(indeks).Dane; }
            set { ZnajdzWezel(indeks).Dane = value; }
        }

        public bool CzyPusta()
        {
            return glowa == null;
        }

        public void DodajDoGlowy(string s)
        {
            Wezel tmp = new Wezel();
            tmp.Dane = s;
            tmp.Nastepny = glowa;
            glowa = tmp;
        }

        public string UsunZGlowy()
        {
            if (glowa == null)           //lista pusta
                throw new InvalidOperationException("Lista jest pusta");
            string x = glowa.Dane;
            glowa = glowa.Nastepny;
            return x; 
        }       

        public void WypiszWszystko()
        {
            for (Wezel tmp = glowa; tmp != null; tmp = tmp.Nastepny)
            {
                Console.WriteLine(tmp.Dane);
            }
        }       

        public int PobierzLiczbeElementow()
        {
            int i;
            Wezel tmp;
            for (i = 0, tmp = glowa; tmp != null; i++, tmp = tmp.Nastepny) ;
            return i;
        }

    }
}
