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
        int MaxDepht(IBinaryNode<T> root);
        IBinaryNode<T> DeepNode();
        void ToDrawAllPaths();
        Queue<IBinaryNode<T>> FindPath(IBinaryNode<T> findedRoot);
        INode<T> FindRootDepht(T value);
        List<INode<T>> FindRootAll(T value);
        bool FindRoot(IBinaryNode<T> node);
        INode<T> FindRootFirst(T value);

    }
}
