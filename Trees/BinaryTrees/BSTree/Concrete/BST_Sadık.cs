using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Trees.BinaryTrees.BSTree.Abstract;
using Trees.BinaryTrees.Node.Abstract;
using Trees.BinaryTrees.Node.Concrete;

namespace Trees.BinaryTrees.BSTree.Concrete
{
    public partial class BST<T> : IBinarySearchTree<T> where T : IComparable
    {
        public IBinaryNode<T> Root { get; set; }
        public BST()
        {
            Root = null; 
        }

        public void Add(T value)
        {
            if (value == null) throw new ArgumentNullException();
            var newdata = new BSTNode<T>(value); 
            if (Root==null)
            {
                Root = newdata;
            }
            var current = Root;
            while (current!=null)
            {
                if (value.CompareTo(current.Value)<0) //Küçük ise sol a geç
                {
                    current = current.Left;
                    if (true)
                    {

                    }
                }
                else if (value.CompareTo(current.Value)>0)// buyuk sag a geç
                {

                }
            }
        }

        public void AddRange(List<T> values)
        {
            throw new NotImplementedException();
        }
        public void Clear()
        {
            throw new NotImplementedException();
        }
        public T FindMin()
        {
            throw new NotImplementedException();
        }
        public List<INode<T>> FindRootAll(T value)
        {
            throw new NotImplementedException();
        }

        public INode<T> FindRootDepht(T value)
        {
            throw new NotImplementedException();
        }

        public INode<T> FindRootFirst(T value)
        {
            throw new NotImplementedException();
        }
        public void ToDrawAllPaths()
        {
            throw new NotImplementedException();
        }
        public void RemoveAll(T value)
        {
            throw new NotImplementedException();
        }
    }
}
