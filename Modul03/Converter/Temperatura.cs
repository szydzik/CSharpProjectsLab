using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class Temperatura
    {
        private double celsjusz;

        public Temperatura(double i, string s)
        {
            SetTemperatura(i, s);
        }

        public void SetTemperatura(double i, string s)
        {
            switch (s)
            {
                case "kelvin":
                    celsjusz = i - 273.15;
                    break;
                case "celsjusz":
                    celsjusz = i;
                    break;
                case "fahrenheit":
                    celsjusz = (i - 32) / 1.8;
                    break;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }

        public double GetTemperatura(string s)
        {
            switch (s)
            {
                case "kelvin":
                    return celsjusz + 273.15;
                case "celsjusz":
                    return celsjusz;
                case "fahrenheit":
                    return (celsjusz * 1.8) + 32;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }


    }
}

