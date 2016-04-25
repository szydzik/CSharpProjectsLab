using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    class Osoba
    {
        public string Imie { set; get; }
        public string Nazwisko { set; get; }
        public Osoba(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }
    }

    class Konto
    {
        public Osoba Wlasciciel { set; get; }
        private decimal saldo;
        private int pin;

        public Konto(Osoba wlasciciel):this(wlasciciel,0,0)
        {            
        }

        public Konto(Osoba wlasciciel,decimal saldoPoczatkowe,int pin)
        {
            Wlasciciel = wlasciciel;
            this.saldo = saldoPoczatkowe;
            this.pin = pin;
        }

        private bool SprawdzPin(int pin)
        {
            if (this.pin == pin)
                return true;
            return false;
        }

        public void DokonajWplaty(decimal kwota)
        {
            if (kwota < 0)
                throw new ArgumentException("Wpłacana kwota nie może być mniejsza od zera");
            saldo += kwota;
        }

       public bool DokonajWyplaty(decimal kwota, int pin)
        {
            if (!SprawdzPin(pin) || saldo < kwota)
                return false;
            saldo -= kwota;
            return true;
        }

        public bool ZmienPin(int nowy, int stary)
        {
            if (SprawdzPin(stary))
            {
                pin = nowy;
                return true;
            }
            return false;
        }


        public string PobierzInformacje(int pin)
        {
            if (SprawdzPin(pin))
            {
                return string.Format("Pan(i) {0} {1} posiada na koncie: {2}",
                        Wlasciciel.Imie, Wlasciciel.Nazwisko, saldo);
            }
            return "Brak dostępu";
        }

    }
}
