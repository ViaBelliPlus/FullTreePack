using System.Collections;
using Trees.BinaryTrees.BaseBT.Concrete;
using Trees.BinaryTrees.Node.Abstract;

namespace Trees.BinaryTrees.BSTree.Concrete
{
    internal class BSTEnumetator<T> : IEnumerator<T> where T : IComparable
    {
        public List<IBinaryNode<T>> list;
        public int index = -1;
        public BSTEnumetator(IBinaryNode<T> root)
        {
            list = BinaryTree<T>.LevelOrder(root).ToList();
            index++;
        }

        public T Current => list[index].Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            list = null;
        }

        public bool MoveNext()
        {
            index++;
            return index < list.Count ? true : false;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}