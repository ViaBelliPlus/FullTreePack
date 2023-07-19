using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.Trie.CurseFindTree.Abstract
{
    public interface ICurse
    {
        /// <summary>
        /// Yeni küfür ekler
        /// </summary>
        /// <param name="word"></param>
        void CurseAdd(string word);
        /// <summary>
        /// Girilen cümle küfürse siler
        /// </summary>
        /// <param name="word"></param>
        void CurseRemove(string word);
        /// <summary>
        /// Girilen karakter ıle baslıyanları sıler
        /// </summary>
        /// <param name="character"></param>
        void CurseRemove(char character);
        /// <summary>
        /// Girilen cümle küfürmüdür
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        bool CurseSearch(string word);
        /// <summary>
        /// Küfürleri silinmiş bi şekilde geri verir
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        string TextEditör(string word);
        /// <summary>
        /// Küfürleri siler ve silinen küfürleri liste olarak geri döner
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        (string, List<string>) TextCurseEditör(string word);
        /// <summary>
        /// liste içindekileri siler
        /// </summary>
        /// <param name="word"></param>
        void CurseRemove(List<string> word);
        /// <summary>
        /// liste içindekiler ile başlıyanalrı siler
        /// </summary>
        /// <param name="word"></param>
        void CurseRemove(List<char> characters);
    }
}
