using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.Trie._Node.Abstract
{
    public interface ICurseTrie : ITrie
    {
        /// <summary>
        /// verilen string değerin olup olmadığını kontrol eder bool döner 
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        bool ContainsWord(string word);
    }
}
