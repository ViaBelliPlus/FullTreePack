using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.Trie._Node.Abstract;

namespace Trees.Trie._Node.Concrate
{
    public class CurseNode : Trie, ICurseTrie
    { //Tahiri
        public bool ContainsWord(string word)
        {
            ITrie current = this; //içinde bulundugumuz treiden başalr
            foreach (var c in word) //strıng ıcındekı charları gez
            {
                if (!current.Children.TryGetValue(c, out var data)) //aradıgımız yok ıse gır buraya 
                {
                    return false; //hata dondur aranan kelıme yokk de
                }
                current = data;
            }
            //burada bızım strıngın son harfıne gelrıız onun ısaretlımı yoksa degılmı ona bakarız
            return current.IsEndOfWord; //son kelıme bızım ıcın son harfmıdir onun kontrolu donsun drekt
        }
    }
}
