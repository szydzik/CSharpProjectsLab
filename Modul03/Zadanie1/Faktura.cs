using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Faktura
    {
        private DateTime dataSprzedazy;
        private DateTime terminZaplatyData;
        private int terminZaplatyDni;
        private double cenaNetto;
        private double cenaBrutto;
        private string numerFaktury;  // np. 102/A/2016
        public Lista lista;     // lista towarów

        //konstruktor
        public Faktura(DateTime dataSprzedazy,DateTime terminZaplatyData,string numerFaktury, Lista lista)
        {
            this.dataSprzedazy = dataSprzedazy;
            this.terminZaplatyData = terminZaplatyData;
            this.terminZaplatyDni= (terminZaplatyData - dataSprzedazy).Days;
            this.lista = lista;
            this.cenaBrutto = lista.CenaCalkBrutto();
            this.cenaNetto = lista.CenaCalkNetto();
            this.numerFaktury = numerFaktury;
        }

        //konstruktor do tworzenia kopii faktury
        public Faktura(Faktura faktura)
            : this(faktura.DataSprzedazy, faktura.TerminZaplatyData, faktura.numerFaktury, faktura.lista)
        { }

        public DateTime DataSprzedazy
        {
            get { return dataSprzedazy; }
            set { dataSprzedazy = value; }
        }

        public DateTime TerminZaplatyData
        {
            get { return terminZaplatyData; }
            set
            {
                if (value < dataSprzedazy)
                {
                    throw new ArgumentOutOfRangeException("Termin zaplaty musi być późniejszy niż data sprzedaży");
                }
                else
                {
                    terminZaplatyData = value;
                }
            }
        }

        public int TerminZaplatyDni
        {
            get { return (terminZaplatyData - dataSprzedazy).Days; }
        }

        public double CenaNetto
        {
            get { return cenaNetto; }
        }

        public double CenaBrutto
        {
            get { return cenaBrutto; }
        }

        public string NumerFaktury
        {
            get { return numerFaktury; }
        }
    }
}
