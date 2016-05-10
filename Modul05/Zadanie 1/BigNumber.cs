using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class BigNumber
    {
        private decimal number;
        private static int precision=5;

        public static int Precision
        {
            get { return precision; }
            set
            {
                if (value >= 0 && value <= 20) precision = value;
                else throw new ArgumentOutOfRangeException("Dokładność musi mieścić się w przedziale od 0 do 20!");
            }
        }

        public decimal Number
        {
            get { return number; }
            set
            {
                if (value.GetType()==typeof(decimal))
                {
                    number = value;
                }else
                {
                    Console.WriteLine("Zły typ danych");
                }
            }
        }
            
        public BigNumber(decimal number)
        {
            this.number = number;
        }

        public BigNumber(double number)
        {
            this.number = Convert.ToDecimal(number);
        }

        public BigNumber(string number)
        {
            this.number = decimal.Parse(number);
        }

        public static decimal Floor(decimal value, int decimalPlaces)
        {
            decimal adjustment = Convert.ToDecimal(Math.Pow(10, decimalPlaces));
            if (value >= 0) return Math.Floor(value * adjustment) / adjustment;
            else return Math.Ceiling(value * adjustment) / adjustment;
        }

        public static BigNumber operator +(BigNumber a,BigNumber b)
        {
            BigNumber ret=null;
            decimal temp = a.Number + b.Number;
            temp = Floor(temp, Precision);
            ret = new BigNumber(temp);
            return ret;
        }

        public static BigNumber operator -(BigNumber a,BigNumber b)
        {
            BigNumber ret = null;
            decimal temp = a.Number - b.Number;
            temp = Floor(temp, Precision);
            ret = new BigNumber(temp);
            return ret;
        }

        public static BigNumber operator *(BigNumber a, BigNumber b)
        {
            BigNumber ret = null;
            decimal temp = a.Number * b.Number;
            temp = Floor(temp, Precision);
            ret = new BigNumber(temp);
            return ret;
        }

        public static BigNumber operator *(BigNumber a,double b)
        {
            BigNumber ret = null;
            decimal temp = a.Number * Convert.ToDecimal(b);
            temp = Floor(temp, Precision);
            ret = new BigNumber(temp);
            return ret;
        }

        public static BigNumber FromDouble(double number)
        {
            return new BigNumber(number);
        }

        public static BigNumber FromDecimal(decimal number)
        {
            return new BigNumber(number);
        }

        public static BigNumber FromString(string number)
        {
            return new BigNumber(number);
        }

        public static double ToDouble(BigNumber number)
        {
            return Convert.ToDouble(number.number);
        }

        public static decimal ToDecimal(BigNumber number)
        {
            return number.number;
        }

        public override string ToString()
        {
            return number.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            BigNumber a = obj as BigNumber;
            if (a == null) return false;
            return (number == a.Number);
        }

    }
}
