using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.BinaryTrees.Node.Abstract;

namespace Trees.BinaryTrees
{
    public interface IBinaryTreeRamble<T> where T : IComparable
    {
        List<INode<T>> InOrder(INode<T> root);
        List<INode<T>> InOrderNR(INode<T> root);
        List<INode<T>> PostOrder(INode<T> root);
        List<INode<T>> PostOrderNR(INode<T> root);
        List<INode<T>> PreOrder(INode<T> root);
        List<INode<T>> PreOrderNR(INode<T> root);
        List<INode<T>> LevelOrder(INode<T> root);
        List<INode<T>> LevelOrderNR(INode<T> root);
    }
}
