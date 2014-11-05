using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    public class BTNode<T>
    {
        private T data;
        private BTNode<T> parent;
        private BTNode<T> childLeft;
        private BTNode<T> childRight;

        public void BTNode<T>()
        {
            parent = null;
            childLeft = null;
            childRight = null;
        }
    }
}