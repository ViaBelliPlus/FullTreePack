using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinaryTrees.BBTree.Abstract
{
    public interface IBinaryBalanceTree<T> : IBinaryTreeBase<T> where T : IComparable
    {
        T RightRotation();
        T LeftRotation();
        T FindMax();
        T GetBalance();

    }
}
