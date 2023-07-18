using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.BinaryTrees.Node.Abstract;

namespace Trees.BinaryTrees
{
    public interface IBinaryTreeBase<T> where T : IComparable
    {
        void Add(T value); 
        void AddRange(List<T> values);
        void Remove(INode<T> value);
        void Remove(T value);
        void RemoveAll(T value);
        void RemoveAll(INode<T> value);
        void RemoveRange(List<T> values);
        void Clear();

    }
}
