using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.Trie._Node.Abstract;

namespace Trees.Trie._Node.Concrate
{
    public class SearchNode : Trie, ISearchTrei
    { //Sadık
        public List<ITrie> ContainsCompletedWord(string word)
        {
            throw new NotImplementedException();
        }

        public List<ITrie> HistoricalData()
        {
            throw new NotImplementedException();
        }
    }
}
