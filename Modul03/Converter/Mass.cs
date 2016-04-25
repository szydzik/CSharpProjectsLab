using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
public static class Mass
    {
        public enum UNIT { KILOGRAM, GRAM, TON, CENTAL, POUND, OUNCE }
        public static double Convert(UNIT baseUnit, double value, UNIT resultUnit)
        {
            return GetMass(GetKilosFromOtherUnit(baseUnit, value), resultUnit);
        }

        public static double GetKilosFromOtherUnit(UNIT baseUnit, double value)
        {
            switch (baseUnit)
            {
                case UNIT.KILOGRAM:
                    return value;
                case UNIT.GRAM:
                    return value * 1000;
                case UNIT.TON:
                    return value / 1000;
                case UNIT.CENTAL:
                    return value / 100;
                case UNIT.POUND:
                    return value / 0.453592;
                case UNIT.OUNCE:
                    return value / 0.02835;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }

        public static double GetMass(double kilos, UNIT resultUnit)
        {
            switch (resultUnit)
            {
                case UNIT.KILOGRAM:
                    return kilos;
                case UNIT.GRAM:
                    return kilos / 1000;
                case UNIT.TON:
                    return kilos * 1000;
                case UNIT.CENTAL:
                    return kilos * 100;
                case UNIT.POUND:
                    return kilos * 0.453592;
                case UNIT.OUNCE:
                    return kilos * 0.02835;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }
    }
}
