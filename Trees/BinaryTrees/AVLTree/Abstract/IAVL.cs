using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.BinaryTrees.BBTree;
using Trees.BinaryTrees.BSTree;

namespace Trees.BinaryTrees.AVLTree
{
    public interface IAVL<T> : IBinaryBalanceTree<T>, IBinarySearchTree<T> where T : IComparable
    {
    }
}
