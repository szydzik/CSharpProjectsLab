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
            BigNumber n2 = new BigNumber(-0.00123m);
            BigNumber n3 = new BigNumber(0.000321m);
            BigNumber.Precision = 6;
            Console.WriteLine(n1 + n2);
            Console.ReadKey();
        }
    }
}
