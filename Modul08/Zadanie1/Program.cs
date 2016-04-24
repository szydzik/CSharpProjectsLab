using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            CzasopismaDAO czasopismoDAO = new CzasopismaDAO();

            //dodawanie obiektu do bazy
            Czasopismo c1 = new Czasopismo("Świerszczyk", "13/2003", 2003, RODZAJ.MIESIECZNIK);
            czasopismoDAO.insert(c1);
            Console.WriteLine("c1: {0}", c1);
            
            //wyświetlanie danych
            Console.WriteLine("Lista czasopism w bazie: ");
            foreach (Czasopismo czasopismo in czasopismoDAO.selectAll())
            {
                Console.WriteLine("{0}", czasopismo.ToString());
            }

            //usunięcie rekordu z indeksem 2
            czasopismoDAO.delete(2);

            //wyświetlanie danych
            Console.WriteLine("Lista czasopism w bazie: ");
            foreach (Czasopismo czasopismo in czasopismoDAO.selectAll())
            {
                Console.WriteLine("{0}", czasopismo.ToString());
            }

            //wyświetlanie rekordu o indeksie 5
            Console.WriteLine("Czasopismo 5: {0}", czasopismoDAO.select(5));

            //zmiana rekordu o indeksie 5 na dane z c2
            Czasopismo c2 = new Czasopismo(5,"Nudziarz", "13/2000", 2000, RODZAJ.TYGODNIK);
            czasopismoDAO.update(c2);
            //wyświetlanie rekordu o indeksie 5
            Console.WriteLine("Czasopismo 5: {0}", czasopismoDAO.select(5));


            //dodawanie rekordu - wprowadzanie danych z konsoli
            czasopismoDAO.insert(new Czasopismo());
            Console.WriteLine("Lista czasopism w bazie: ");

            //wyświetlanie danych
            foreach (Czasopismo czasopismo in czasopismoDAO.selectAll())
            {
                Console.WriteLine("{0}", czasopismo.ToString());
            }

            Console.ReadKey();
        }
    }
}
