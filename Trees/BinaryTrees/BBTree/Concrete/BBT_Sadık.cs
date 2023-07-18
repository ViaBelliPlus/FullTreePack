using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.BinaryTrees.BBTree.Abstract;
using Trees.BinaryTrees.Node.Abstract;

namespace Trees.BinaryTrees.BBTree.Concrete
{
    public partial class BBT<T> : IBinaryBalanceTree<T> where T : IComparable
    {
        public void Add(T value)
        {
            throw new NotImplementedException();
        }

        public void AddRange(List<T> values)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public T GetBalance()
        {
            throw new NotImplementedException();
        }

        public T LeftRotation()
        {
            throw new NotImplementedException();
        }

        public void Remove(IBinaryNode<T> value)
        {
            throw new NotImplementedException();
        }

        public void RemoveFirst(T value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAll(T value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAll(IBinaryNode<T> value)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(List<T> values)
        {
            throw new NotImplementedException();
        }

        public T RightRotation()
        {
            throw new NotImplementedException();
        }

        T IBinaryBalanceTree<T>.FindMax()
        {
            throw new NotImplementedException();
        }
    }
}
