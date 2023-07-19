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
    public partial class CourseEditor : ICurse
    {
        public SearchNode Node { get; set; }
        public CourseEditor()
        {
            Node=new SearchNode();
        }
        public CourseEditor(SearchNode node)
        {
            Node = node;
        }
        public void CurseAdd(string word)
        {
            throw new NotImplementedException();
        }

        public void CurseRemove(string word)
        {
            throw new NotImplementedException();
        }

        public void CurseRemove(char character)
        {
            throw new NotImplementedException();
        }

       
    }
}
