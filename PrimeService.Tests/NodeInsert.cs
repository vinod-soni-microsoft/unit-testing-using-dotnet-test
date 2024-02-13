using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeService.Tests
{
    internal class NodeInsert
    {
        public int Data;
        public NodeInsert Left;
        public NodeInsert Right;

        [Fact]
        public void NodeInsert()
        {
            var newNode = new NodeInsert { Data = data };
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
       
    }
}
