using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.BinaryTrees.Node.Abstract;

namespace Trees.BinaryTrees.Node.Concrete
{
    public class BSTNode<T>:IBinaryNode<T> where T : IComparable
    {
        public T Value { get; set; }
        public IBinaryNode<T> Right { get; set; }
        public IBinaryNode<T> Left { get; set; }
        public BSTNode(T value)
        {
            Value = value;
        }

        public override string ToString() => $"{Value}";
    }
}
