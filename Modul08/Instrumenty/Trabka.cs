using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrumenty
{
    class Trabka : Instrument
    {
        public override void Graj()
        {
            Console.WriteLine("Tra ta ta ta");
        }

        public override string Opis
        {
            get { return "Trabka jest to instrument dęty blaszany..."; }
        }

        public override string ToString()
        {
            return "trabka";

        }
    }
}
