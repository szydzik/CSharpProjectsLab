using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTree
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


            Console.WriteLine(tree1);


            foreach (var node in tree1)
            {
                Console.WriteLine(node);
            }

            Console.ReadKey();
        }
    }
}
