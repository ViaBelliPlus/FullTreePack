using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.Trie._Node.Abstract
{
    public interface ITrie
    {
        bool IsEndOfWord { get; set; }
        Dictionary<char, ITrie> Children { get; set; }
        /// <summary>
        /// Verilen string değeri ağaçta saklar
        /// </summary>
        /// <param name="word"></param>
        void Add(string word);
        /// <summary>
        /// Verilen string değeri ağaçtan siler
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        bool Remove(string word);
        /// <summary>
        /// Listede gelen tüm stringleri siler
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        bool RemoveRange(List<string> words);
        /// <summary>
        /// Mesela character=A ise a harfi ile başlıyan kelimelerin hepsini siler
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        bool Remove(char character);
        /// <summary>
        /// Listede gelen Tüm char ları ıle baslıyan kelimeleri siler
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        bool Remove(List<char> character);
    }
}
