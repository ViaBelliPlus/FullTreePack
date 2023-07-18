using System.Collections;
using Trees.BinaryTrees.Node.Abstract;

namespace Trees.BinaryTrees.BSTree.Concrete
{
    internal class BSTEnumetator<T> : IEnumerator<T> where T : IComparable
    {
        public List<IBinaryNode<T>> list;
        public int index=-1;
        public BSTEnumetator(IBinaryNode<T> root)
        {
           // gelinecek
        }

        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}