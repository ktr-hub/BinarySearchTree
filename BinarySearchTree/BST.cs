using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BST
    {
        INode root;
        public BST()
        {
            this.root = null;
        }

        public void Add(int data)
        {
            INode iNode = new INode(data);
            if(root == null)
            {
                root = iNode;
            }
            else
            {
                INode temp = root;
                while(temp!=null)
                {
                    if (temp.data.CompareTo(data) > 0)
                    {
                        if (temp.leftNode == null)
                        {
                            temp.leftNode = iNode;
                            break;
                        }
                        temp = temp.leftNode;
                    }
                    else
                    {
                        if (temp.rightNode == null)
                        {
                            temp.rightNode = iNode;
                            break;
                        }
                        temp = temp.rightNode;
                    }
                }
            }
            Console.WriteLine(data + " Added Successfully");
        }
    }
}
