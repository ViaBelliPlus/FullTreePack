﻿using Core.Utilities.Results;
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
        /// <summary>
        /// Ağacın en küçük değerini verir
        /// </summary>
        /// <returns></returns>
        T FindMin();
        T MaxDepht();
        INode<T> DeepNode();
        void ToDrawAllPaths();
        INode<T> FindPath(INode<T> findedRoot);
        /// <summary>
        /// Verilen degerın en son nodunu döner
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        INode<T> FindRootDepht(T value);
        /// <summary>
        /// T degerine sahip tüm Nodları verir
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        List<IBinaryNode<T>> FindRootAll(T value);
        bool FindRoot(INode<T> node);
        /// <summary>
        /// Verilen değerin nodunu verir
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        INode<T> FindRootFirst(T value);

    }
}
