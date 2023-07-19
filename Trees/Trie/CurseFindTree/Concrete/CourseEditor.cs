using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.Trie._Node.Concrate;
using Trees.Trie.CurseFindTree.Abstract;
using Trees.Trie.SearchEngineTree.Abstract;

namespace Trees.Trie.CurseFindTree.Concrete
{
    public class CourseEditor : ICurse
    {
        public CurseNode Node { get; set; }
        public CourseEditor()
        {
            Node = new CurseNode();
        }
        public CourseEditor(CurseNode node)
        {
            Node = node;
        }
        public void CurseAdd(string word) => Node.Add(word);
        public void CurseRemove(string word) => Node.Remove(word);
        public void CurseRemove(char character) => Node.Remove(character);
        public void CurseRemove(List<string> word) => Node.RemoveRange(word);
        public void CurseRemove(List<char> characters) => Node.Remove(characters);
        public bool CurseSearch(string word) => Node.ContainsWord(word);
        public (string, List<string>) TextCurseEditör(string word)
        {
            throw new NotImplementedException();
        }
        public string TextEditör(string word)
        {
            throw new NotImplementedException();
        }
    }
}
