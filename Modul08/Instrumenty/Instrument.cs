using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrumenty
{
    class Instrument
    {
        public virtual void Graj()
        {
            Console.WriteLine("Instrumenty wydaja dźwieki o róznej częstotliwości i barwie...");
        }

        public virtual string Opis
        {
            get { return "Instrument muzyczny - przyrzad wytwarzajacy dźwiek"; }
        }

        public override string ToString()
        {
            return "instrument";
            
        }
    }
}
