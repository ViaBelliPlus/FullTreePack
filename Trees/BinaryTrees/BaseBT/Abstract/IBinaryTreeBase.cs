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
        /// <summary>
        /// Verilen T tipindeki değeri ağaca uygun şekilde ekler
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"></exception>
        void Add(T value);
        /// <summary>
        /// Gelen T Listesindeki elemanları uygun yerlere yerleştirir
        /// </summary>
        /// <param name="values"></param>
        void AddRange(List<T> values);
        void Remove(IBinaryNode<T> value);
        void RemoveFirst(T value);
        void RemoveAll(T value);
        void RemoveRange(List<T> values);
        /// <summary>
        /// Bu methot çalıştırılır ise ağac komple silinecektir
        /// </summary>
        void Clear();

    }
}
