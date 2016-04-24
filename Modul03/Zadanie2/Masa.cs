using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Masa
    {

        private double kilogram;

        public Masa(double i, string s)
        {
            SetMasa(i, s);
        }

        public double GetMasa(string s)
        {
            switch (s)
            {
                case "kilogram":
                    return kilogram;
                case "gram":
                    return kilogram * 1000;
                case "tona":
                    return kilogram / 1000;
                case "kwintal":
                    return kilogram / 100;
                case "funt":
                    return kilogram / 0.453592;
                case "uncja":
                    return kilogram / 0.02835;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }


        public void SetMasa(double i, string s)
        {
            switch (s)
            {
                case "kilogram":
                    kilogram = i;
                    break;
                case "gram":
                    kilogram = i / 1000;
                    break;
                case "tona":
                    kilogram = i * 1000;
                    break;
                case "kwintal":
                    kilogram = i * 100;
                    break;
                case "funt":
                    kilogram = i * 0.453592;
                    break;
                case "uncja":
                    kilogram = i * 0.02835;
                    break;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }

    }
}
