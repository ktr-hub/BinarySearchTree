using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BST
    {
        INode root;
        int leftCount = 0;
        int rightCount = 0;
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

        public void display(INode root)
        {
            if (root.leftNode != null)
            {
                leftCount++;
                display(root.leftNode);
            }
            Console.WriteLine("Data : " + root.data);
            if (root.rightNode != null)
            {
                rightCount++;
                display(root.rightNode);
            }
        }

        public int Size()
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                display(root);
                return 1+leftCount+rightCount;
            }
        }
    }
}
