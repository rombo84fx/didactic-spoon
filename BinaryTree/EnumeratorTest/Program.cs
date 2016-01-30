using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace EnumeratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree1 = new Tree<int>(10);
            tree1.InsertIntoTree(5, 11, 5, -12, 15, 0, 14, -8, 10);
            foreach (int item in tree1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
