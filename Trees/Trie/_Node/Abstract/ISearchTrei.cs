using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.Trie._Node.Abstract
{
    public interface ISearchTrei : ITrie
    {
        /// <summary>
        /// Aranan kelimeyi geçmiş verilere göre varsa listesini döner
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        List<string> ContainsCompletedWord(string word);
        /// <summary>
        /// İlgili ağaçtaki layıtların hepsini getirir
        /// </summary>
        /// <returns></returns>
        List<string> HistoricalData();

    }
}
