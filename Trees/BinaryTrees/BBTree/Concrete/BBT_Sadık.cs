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
        public IResult Add(T value)
        {
            throw new NotImplementedException();
        }

        public IResult AddRange(List<T> values)
        {
            throw new NotImplementedException();
        }

        public IResult Clear()
        {
            throw new NotImplementedException();
        }

        public IDataResult<T> GetBalance()
        {
            throw new NotImplementedException();
        }

        public IDataResult<T> LeftRotation()
        {
            throw new NotImplementedException();
        }

        public IResult Remove(INode<T> value)
        {
            throw new NotImplementedException();
        }

        public IResult Remove(T value)
        {
            throw new NotImplementedException();
        }

        public IResult RemoveAll(T value)
        {
            throw new NotImplementedException();
        }

        public IResult RemoveAll(INode<T> value)
        {
            throw new NotImplementedException();
        }

        public IResult RemoveRange(List<T> values)
        {
            throw new NotImplementedException();
        }

        public IDataResult<T> RightRotation()
        {
            throw new NotImplementedException();
        }
    }
}
