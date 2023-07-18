using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.BinaryTrees.BSTree.Abstract;
using Trees.BinaryTrees.Node.Abstract;

namespace Trees.BinaryTrees.BSTree.Concrete
{
    public partial class BST<T> : IBinarySearchTree<T> where T : IComparable
    {
        public INode<T> DeepNode()
        {
            throw new NotImplementedException();
        }

        public T FindMax()
        {
            throw new NotImplementedException();
        }

        public bool FindRoot(INode<T> node)
        {
            throw new NotImplementedException();
        }
        public INode<T> FindPath(INode<T> findedRoot)
        {
            throw new NotImplementedException();
        }
        
        public T MaxDepht()
        {
            throw new NotImplementedException();
        }

        public void Remove(INode<T> value)
        {
            throw new NotImplementedException();
        }

        public void Remove(T value)
        {
            throw new NotImplementedException();
        }
        public void RemoveAll(INode<T> value)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(List<T> values)
        {
            throw new NotImplementedException();
        }
    }
}
