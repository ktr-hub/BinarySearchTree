using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BinarySearchTree
{
    public class INode
    {
        public int data;
        public INode leftNode;
        public INode rightNode;
        public INode(int data)
        {
            this.data = data;
            this.leftNode = null;
            this.rightNode = null;
        }
    }
}
