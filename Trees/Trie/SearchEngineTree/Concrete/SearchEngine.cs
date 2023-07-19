using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.Trie._Node.Concrate;
using Trees.Trie.SearchEngineTree.Abstract;

namespace Trees.Trie.SearchEngineTree.Concrete
{
    public partial class SearchEngine : ISearch
    {
        public SearchNode Node { get; set; }
        public SearchEngine()
        {
            Node = new SearchNode();
        }
        public SearchEngine(SearchNode node)
        {
            Node = node;
        }
        public void AllPastRemove()
        {
            throw new NotImplementedException();
        }

        public List<string> Past() => Node.HistoricalData();
        public void PastRemove(string word) => Node.Remove(word);
        public void PastRemove(char character) => Node.Remove(character);
        public void PastRemove(List<string> word) => Node.RemoveRange(word);
        public void PastRemove(List<char> characters) => Node.Remove(characters);
        public List<string> Search(string word) => Node.ContainsCompletedWord(word);
    }


}
