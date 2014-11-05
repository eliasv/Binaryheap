using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    public class BTNode<T>
    {
        private T data { get; set; }
        private BTNode<T> parent {get; set;}
        private BTNode<T> childLeft { get; set; }
        private BTNode<T> childRight { get; set; }

        public BTNode()
        {
            parent = null;
            childLeft = null;
            childRight = null;
        }

        public BTNode(T item)
            : this()
        {
            data = item;
        }

        public BTNode(BTNode<T> N)
        {
            data = N.data;
            parent = N.parent;
            childLeft = N.childLeft;
            childRight = N.childRight;
        }
    }
}