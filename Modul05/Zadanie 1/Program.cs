using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigNumber n1 = new BigNumber(0.000321);
            BigNumber n2 = new BigNumber(-0.00123213m);
            BigNumber n3 = new BigNumber(0.00012m);
            BigNumber.Precision = 6;
            Console.WriteLine(n1 - n3);
            BigNumber.Precision = 10;
            Console.WriteLine(n2 * n3);
            BigNumber.Precision = 20;
            Console.WriteLine(n2 * 4.32143);
            Console.ReadKey();
        }
    }
}
