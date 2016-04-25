using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public static class Power
    {

        public enum UNIT { WATT, HORSEPOWER }
        public static double Convert(UNIT baseUnit, double value, UNIT resultUnit)
        {
            return GetPower(GetWattsFromOtherUnit(baseUnit, value), resultUnit);
        }

        public static double GetWattsFromOtherUnit(UNIT baseUnit, double value)
        {
            switch (baseUnit)
            {
                case UNIT.WATT:
                    return value;
                case UNIT.HORSEPOWER:
                    return value * 735.498;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }

        public static double GetPower(double watts, UNIT resultUnit)
        {
            switch (resultUnit)
            {
                case UNIT.WATT:
                    return watts;
                case UNIT.HORSEPOWER:
                    return watts / 735.498;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }
}
