using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.Trie._Node.Abstract;

namespace Trees.Trie._Node.Concrate
{
    public partial class Trie : ITrie
    {
        public bool IsEndOfWord { get; set; }
        public Dictionary<char, ITrie> Children { get; set; } = new();

        public void Add(string word)
        {
            var root = this; //Buradan drekt olarak ilk routu yakalayabiliriz
            throw new NotImplementedException();
        }
        public bool Remove(char character)
        {
            throw new NotImplementedException();
        }

        public bool Remove(List<char> character)
        {
            throw new NotImplementedException();
        }
    }
}
