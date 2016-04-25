using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public static class Temperature
    {
        public enum UNIT { KELVIN, CELSIUS, FAHRENHEIT}
        public static double Convert(UNIT baseUnit, double value, UNIT resultUnit)
        {
            return GetTemperature(GetCelsiusFromOtherUnit(baseUnit, value), resultUnit);
        }

        public static double GetCelsiusFromOtherUnit(UNIT baseUnit, double value)
        {
            switch (baseUnit)
            {
                case UNIT.KELVIN:
                    return value - 273.15;
                case UNIT.CELSIUS:
                    return  value;
                case UNIT.FAHRENHEIT:
                    return (value - 32) / 1.8;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }

        public static double GetTemperature(double celsius, UNIT resultUnit)
        {
            switch (resultUnit)
            {
                case UNIT.KELVIN:
                    return celsius + 273.15;
                case UNIT.CELSIUS:
                    return celsius;
                case UNIT.FAHRENHEIT:
                    return (celsius * 1.8) + 32;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }


    }
}

