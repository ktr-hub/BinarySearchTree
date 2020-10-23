using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BST bst = new BST();
            bst.Add(56);
            bst.Add(30);
            bst.Add(70);
            bst.Add(99);
            bst.Add(20);
            Console.WriteLine(bst.Size());
        }
    }
}
