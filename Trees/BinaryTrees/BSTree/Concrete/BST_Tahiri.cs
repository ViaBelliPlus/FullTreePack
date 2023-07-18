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
        public INode<T> DeepNode(IBinaryNode<T> root)
        {
            var ptr = Root;
            while(ptr.Right != null && ptr.Left != null)
            {
                int rightDepht = MaxDepht(root.Right);
                int leftDepht = MaxDepht(ptr.Left);
                if(rightDepht < leftDepht)
                {
                    ptr = ptr.Left;
                }
                else
                {
                    ptr = ptr.Right;
                }
            }
            return ptr;
        }

        public T FindMax()
        {
            Validate(Root);
            var ptr = Root;
            while (ptr.Right != null) { ptr = ptr.Right; }
            return ptr.Right.Value;
        }

        public bool FindRoot(INode<T> node)
        {
            throw new NotImplementedException();
        }
        public INode<T> FindPath(INode<T> findedRoot)
        {
            throw new NotImplementedException();
        }
        
        public int MaxDepht(IBinaryNode<T> root)
        {
            if (root == null) return 0;
            int leftDepht = MaxDepht(root.Left);
            int rightDepht = MaxDepht(root.Right);

            return (leftDepht > rightDepht) ? leftDepht + 1: rightDepht + 1;
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
        private void Validate(object? obj)
        {
            if(obj == null) throw new ArgumentNullException(nameof(obj));
        }
        private void Validate(object? obj,object? obj2)
        {
            if(obj == null || obj2 == null) throw new ArgumentNullException(nameof(obj2));
        }
    }
}
