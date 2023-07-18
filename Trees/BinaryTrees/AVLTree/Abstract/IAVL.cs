using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.BinaryTrees.BBTree.Abstract;
using Trees.BinaryTrees.BSTree.Abstract;

namespace Trees.BinaryTrees.AVLTree.Abstract
{
    public interface IAVL<T> : IBinaryBalanceTree<T>, IBinarySearchTree<T> where T : IComparable
    {
    }
}
