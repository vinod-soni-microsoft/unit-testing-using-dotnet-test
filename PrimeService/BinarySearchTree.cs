using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeService
{
    internal class Node    {
        public int Data;
        public Node Left;
        public Node Right;
    }

    internal class BinarySearchTree
    {
        private Node _root;
        public Node Root
        {
            get
            {
                return _root;
            }
        }
        public void Insert(int data)
        {
            var newNode = new Node { Data = data };
            if (_root == null)
            {
                _root = newNode;
                return;
            }
            var current = _root;
            while (current != null)
            {
                if (data < current.Data)
                {
                    if (current.Left == null)
                    {
                        current.Left = newNode;
                        return;
                    }
                    current = current.Left;
                }
                else if (data > current.Data)
                {
                    if (current.Right == null)
                    {
                        current.Right = newNode;
                        return;
                    }
                    current = current.Right;
                }
                else
                {
                    return;
                }
            }
        }

        public void Delete(int data)
        {
            Node parent = null;
            var current = _root;
            while (current != null)
            {
                if (data < current.Data)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (data > current.Data)
                {
                    parent = current;
                    current = current.Right;
                }
                else
                {
                    break;
                }
            }
            if (current == null)
            {
                return;
            }
            if (current.Right == null)
            {
                if (parent == null)
                {
                    _root = current.Left;
                }
                else
                {
                    if (current.Data < parent.Data)
                    {
                        parent.Left = current.Left;
                    }
                    else
                    {
                        parent.Right = current.Left;
                    }
                }
            }
            else
            {
                var leftmost = current.Right;
                parent = null;
                while (leftmost.Left != null)
                {
                    parent = leftmost;
                    leftmost = leftmost.Left;
                }
                if (parent != null)
                {
                    parent.Left = leftmost.Right;
                }
                else
                {
                    current.Right = leftmost.Right;
                }
                current.Data = leftmost.Data;
            }
        }
      
    }
}
