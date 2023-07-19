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
            ITrie current = this; //Buradan drekt olarak ilk routu yakalayabiliriz
            foreach (var c in word)
            {
                if (!current.Children.TryGetValue(c, out ITrie child)) //burada currentın cocuklarına arasında ilgili c harfı varmı yokmu ona bakıyoruz yok ıse gır ve olustur var ise o har onun adresini childe atar

                {//out var child bunun eklenmesi olusturulan yeni cocugu dısarıdan erısebılmek
                    child = new Trie(); //yenı boş trie olustur
                    current.Children.Add(c, child); // c de gelen harfi yeni boş trie ekle
                }
                current = child; //yeni cocuga giriyoruz artık
            }
            current.IsEndOfWord = true; //burada current dedıgımız en son harf olmus olur onun bır kelımeyı temsıl etıgını bıldırmek gerk 
        }
        public bool Remove(char character)
        {
            ITrie current = this;
           return current.Children.Remove(character);
        }

        public bool Remove(List<char> character)
        {
            foreach (var c in character)
            {
                Remove(c);
            }
            return true;
        }

    }
}
