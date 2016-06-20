using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Konta
{
    public delegate void PrzedZmianaHaslaHandler(object sender, PrzedZmianaHaslaArgs e);
    public class PrzedZmianaHaslaArgs : CancelEventArgs
    {
        private string noweHaslo;
        public string NoweHaslo
        {
            get { return noweHaslo; }
        }

        private string stareHaslo;
        public string StareHaslo
        {
            get { return stareHaslo; }
        }

        public PrzedZmianaHaslaArgs(string noweHaslo,string stareHaslo)
        {
            this.noweHaslo = noweHaslo;
            this.stareHaslo = stareHaslo;
        }

    }
    public class Konto
    {
        public string NazwaUzytkownika { get; set; }
        private string haslo;
        public static event PrzedZmianaHaslaHandler PrzedZmianaHasla;
        public static event EventHandler PoZmianieHasla;
        public bool SprawdzHaslo(string haslo)
        {
            if (this.haslo == haslo) return true;
            return false;
        }
        public Konto(string nazwaUzytkownika, string haslo)
        {
            this.NazwaUzytkownika = nazwaUzytkownika;
            this.haslo = haslo;
        }

        public bool ZmienHaslo(string stareHaslo,string noweHaslo)
        {
            if (!SprawdzHaslo(stareHaslo)) return false;

            if (PrzedZmianaHasla != null)
            {
                PrzedZmianaHaslaArgs e = new PrzedZmianaHaslaArgs(noweHaslo, stareHaslo);
                PrzedZmianaHasla(this, e);
                if (e.Cancel)
                {
                    return false;
                }
            }
            haslo = noweHaslo;
            if (PoZmianieHasla != null)
            {
                PoZmianieHasla(this, EventArgs.Empty);
            }
            return true;
        }
    }
}
