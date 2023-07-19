using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.Trie.SearchEngineTree.Abstract
{
    public interface ISearch
    {
        /// <summary>
        /// Geçmişte ararnan herşeyi getirir
        /// </summary>
        /// <returns></returns>
        List<string> Past();
        /// <summary>
        /// Girilen cümle yada karakterle başlayan kelimeleri listeler
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        List<string> Search(string word);
        void AllPastRemove();
        /// <summary>
        /// Girilen cümle küfürse siler
        /// </summary>
        /// <param name="word"></param>
        void PastRemove(string word);
        /// <summary>
        /// Girilen karakter ıle baslıyanları sıler
        /// </summary>
        /// <param name="character"></param>
        void PastRemove(char character);

        /// <summary>
        /// liste içindekileri siler
        /// </summary>
        /// <param name="word"></param>
        void PastRemove(List<string> word);
        /// <summary>
        /// liste içindekiler ile başlıyanalrı siler
        /// </summary>
        /// <param name="word"></param>
        void PastRemove(List<char> characters);
    }
}
