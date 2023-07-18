using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinaryTrees.Node.Abstract
{
    public interface IBinaryNode<T>:INode<T>
    {
        T Value { get; set; }
        IBinaryNode<T> Right { get; set; }
        IBinaryNode<T> Left { get; set; }
    }
}
