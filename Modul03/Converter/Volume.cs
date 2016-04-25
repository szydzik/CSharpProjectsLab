using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public static class Objetosc
    {

        public enum UNIT { LITER, CUBIC, NOGGIN, GALLON }
        public static double Convert(UNIT baseUnit, double value, UNIT resultUnit)
        {
            return GetVolume(GetLitersFromOtherUnit(baseUnit, value), resultUnit);
        }

        public static double GetLitersFromOtherUnit(UNIT baseUnit, double value)
        {
            switch (baseUnit)
            {
                case UNIT.LITER:
                    return value;
                case UNIT.CUBIC:
                    return value * 1000;
                case UNIT.NOGGIN:
                    return value * 0.25;
                case UNIT.GALLON:
                    return value * 4.5456;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }


        public static double GetVolume(double liters, UNIT resultUnit)
        {
            switch (resultUnit)
            {
                case UNIT.LITER:
                    return liters;
                case UNIT.CUBIC:
                    return liters / 1000;
                case UNIT.NOGGIN:
                    return liters / 0.25;
                case UNIT.GALLON:
                    return liters / 4.5456;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }


    }
}
