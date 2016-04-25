using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public static class Quantity
    {
        public enum UNIT { PIECE, THREESCORE, DOZEN, FIFTEEN}

        public static double Convert(UNIT baseUnit, double value, UNIT resultUnit)
        {
            return GetQuantity(GetPiecesFromOtherUnit(baseUnit, value), resultUnit);
        }

        public static double GetPiecesFromOtherUnit(UNIT baseUnit, double value)
        {
            switch (baseUnit)
            {
                case UNIT.PIECE:
                    return value;
                case UNIT.THREESCORE:
                    return value * 60;
                case UNIT.DOZEN:
                    return value * 12;
                case UNIT.FIFTEEN:
                    return value * 15;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }

        public static double GetQuantity(double pieces, UNIT resultUnit)
        {
            switch (resultUnit)
            {
                case UNIT.PIECE:
                    return pieces;
                case UNIT.THREESCORE:
                    return pieces / 60;
                case UNIT.DOZEN:
                    return pieces / 12;
                case UNIT.FIFTEEN:
                    return pieces / 15;
                default:
                    throw new ArgumentException("Nie rozpoznano jednostki");
            }
        }
    }
}
