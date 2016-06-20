using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konta;
using System.IO;

namespace TestKonta
{
    static class PolitykaBezpieczenstwa
    {
        public static int MinimalnaLiczbaZnakow { get; set; }
        public static string NazwaPliku { get; set; }
        static PolitykaBezpieczenstwa()
        {
            MinimalnaLiczbaZnakow = 5;
            NazwaPliku = "Audyt.txt";
        }

        public static void SprawdzDlugoscHasla(object sender, PrzedZmianaHaslaArgs e)
        {
            if (e.NoweHaslo.Length < MinimalnaLiczbaZnakow) e.Cancel = true;
        }

        public static void SprawdzCzyHasloJestPowtorzone(object sender,PrzedZmianaHaslaArgs e)
        {
            if (e.NoweHaslo == e.StareHaslo) e.Cancel = true;
        }

        public static void ZapiszDoPliku(object sender,EventArgs e)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(NazwaPliku, true);
                Konto k = (Konto)sender;
                sw.WriteLine("Zmiana hasła dla użytkownika {0}", k.NazwaUzytkownika);
            }
            finally
            {
                if (sw != null) sw.Close();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Konto k1 = new Konto("JanKowalski", "password");
            Konto k2 = new Konto("AndrzejNowak", "haslo");

            Konto.PrzedZmianaHasla += new PrzedZmianaHaslaHandler(PolitykaBezpieczenstwa.SprawdzCzyHasloJestPowtorzone);
            Konto.PrzedZmianaHasla += new PrzedZmianaHaslaHandler(PolitykaBezpieczenstwa.SprawdzDlugoscHasla);
            Konto.PoZmianieHasla += new EventHandler(PolitykaBezpieczenstwa.ZapiszDoPliku);


            if (k1.ZmienHaslo("password", "123"))
                Console.WriteLine("Hasło zmienione");
            else
                Console.WriteLine("Hasło nie udało się zmienić");

            if (k2.ZmienHaslo("haslo", "haslo"))
                Console.WriteLine("Hasło zmienione");
            else
                Console.WriteLine("Hasło nie udało się zmienić");


            if (k1.ZmienHaslo("password", "12345"))
                Console.WriteLine("Hasło zmienione");
            else
                Console.WriteLine("Hasło nie udało się zmienić");

            if (k2.ZmienHaslo("haslo", "123haslo"))
                Console.WriteLine("Hasło zmienione");
            else
                Console.WriteLine("Hasło nie udało się zmienić");

            Console.ReadKey();
        }
    }
}
