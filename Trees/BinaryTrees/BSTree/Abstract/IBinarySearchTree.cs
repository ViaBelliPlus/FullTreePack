using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.BinaryTrees.Node.Abstract;

namespace Trees.BinaryTrees.BSTree.Abstract
{
    public interface IBinarySearchTree<T> : IBinaryTreeBase<T> where T : IComparable
    {
        T FindMax();
        T FindMin();
        T MaxDepht();
        INode<T> DeepNode();
        void ToDrawAllPaths();
        INode<T> FindPath(INode<T> findedRoot);
        INode<T> FindRootDepht(T value);
        List<INode<T>> FindRootAll(T value);
        bool FindRoot(INode<T> node);
        INode<T> FindRootFirst(T value);

    }
}
