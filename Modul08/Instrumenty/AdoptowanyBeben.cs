using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstumentyPerkusyjne;

namespace Instrumenty
{
    class AdoptowanyBeben : Instrument
    {
        private Beben beben = new Beben();

        public override void Graj()
        {
            Console.WriteLine(beben.Uderz());
        }

        public override string Opis
        {
            get
            {
                return beben.ZwrocOpis();
            }
        }

        public override string ToString()
        {
            return "bęben";
        }
    }
}
