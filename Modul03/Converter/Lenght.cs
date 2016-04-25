using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    
    public static class Lenght
    {
        public enum UNIT { METER, MILIMETER, INCH, YARD, NAUTICALMILE, LANDMILE, KILOMETER }
        public static double Convert(UNIT j1, double value, UNIT j2)
        {
            return GetLength(GetMetersFromOtherUnit(j1, value), j2);
        }

        public static double GetMetersFromOtherUnit(UNIT j, double value)
        {
            switch (j)
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

        public static double GetLength(double metr, UNIT j)
        {
            switch (j)
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
