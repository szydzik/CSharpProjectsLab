using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    
    public static class Lenght
    {
        public enum UNIT { METER, MILIMETER, INCH, YARD, NAUTICALMILE, LANDMILE, KILOMETER }
        public static double Convert(UNIT baseUnit, double value, UNIT resultUnit)
        {
            return GetLength(GetMetersFromOtherUnit(baseUnit, value), resultUnit);
        }

        public static double GetMetersFromOtherUnit(UNIT baseUnit, double value)
        {
            switch (baseUnit)
            {
                case UNIT.METER:
                    return value;
                case UNIT.MILIMETER:
                    return value / 1000;
                case UNIT.INCH:
                    return value * 0.0254;
                case UNIT.YARD:
                    return value * 0.9144;
                case UNIT.NAUTICALMILE:
                    return value * 1852;
                case UNIT.LANDMILE:
                    return value * 1609.344;
                case UNIT.KILOMETER:
                    return value * 1000;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }

        public static double GetLength(double metr, UNIT resultUnit)
        {
            switch (resultUnit)
            {
                case UNIT.METER:
                    return metr;
                case UNIT.MILIMETER:
                    return metr * 1000;
                case UNIT.INCH:
                    return metr / 0.0254;
                case UNIT.YARD:
                    return metr / 0.9144;
                case UNIT.NAUTICALMILE:
                    return metr / 1852;
                case UNIT.LANDMILE:
                    return metr / 1609.344;
                case UNIT.KILOMETER:
                    return metr / 1000;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }
    }
}
