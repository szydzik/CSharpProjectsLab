using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Tester
    {
        static void Main(string[] args)
        {
            AVLTree<int, string> tree1 = new AVLTree<int, string>();

            tree1.Insert(1, "jedynka");
            tree1.Insert(1130, "tysiac sto trzydziesci");
            tree1.Insert(43, "czterdziesci trzy");
            tree1.Insert(-50, "minus piecdziesiat");
            tree1.Insert(-66, "minus szesciesiat szesc");
            tree1.Insert(12, "dwanascie");
            tree1.Insert(5, "5");
            tree1.Insert(6, "szesc");
            tree1.Insert(0, "zero");

            Console.WriteLine(tree1);

            Console.ReadKey();
        }
    }
}
