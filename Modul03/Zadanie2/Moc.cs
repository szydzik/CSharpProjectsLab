using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Moc
    {
        private double wat;

        public Moc(double i, string s)
        {
            SetMoc(i, s);
        }

        public void SetMoc(double i, string s)
        {
            switch (s)
            {
                case "wat":
                    wat = i;
                    break;
                case "kon mechaniczny":
                    wat = i * 735.498;
                    break;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }
        public double GetMoc(string s)
        {
            switch (s)
            {
                case "wat":
                    return wat;
                case "kon mechaniczny":
                    return wat / 735.498;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }
    }
}
