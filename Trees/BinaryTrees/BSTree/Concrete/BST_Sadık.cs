using Core.Utilities.Results;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Trees.BinaryTrees.BaseBT.Concrete;
using Trees.BinaryTrees.BSTree.Abstract;
using Trees.BinaryTrees.Node.Abstract;
using Trees.BinaryTrees.Node.Concrete;

namespace Trees.BinaryTrees.BSTree.Concrete
{
    public partial class BST<T> : IBinarySearchTree<T>, IEnumerable<T> where T : IComparable
    {
        public IBinaryNode<T> Root { get; set; }
        public BST()
        {
            Root = null;
        }
        public BST(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public void Add(T value)
        {
            if (value == null) throw new ArgumentNullException();
            var newNode = new BSTNode<T>(value);

            if (Root == null) //hiç eleman yok ise buraya koyarız
            {
                Root = newNode;
            }
            else
            {
                var current = Root; //root referansını aldık
                IBinaryNode<T> parent; //bunu ontrollerin içinde kullanıcaz 
                while (true)
                {
                    parent = current; //parent == current olmus oldu currentın degerı degısecek o yuzden currentın bı oncekını tutucak sekılde yapılandırıldı

                    //sol - alt agac
                    if (value.CompareTo(current.Value) < 0) //kucuk deger
                    {
                        current = current.Left; //burada currentın degerını curentin solu yaptık currentın degerı gitti ama parent tutuyor 
                        if (current == null) //boşpozisyon aranıyor current boş ise girer boş değilse wher bidaha döner boş yer buluncaya kadar
                        {
                            parent.Left = newNode; //deger atandı parent dedıgımız currentın bı oncesını tutuyor current null olunca parent yanı currentin bir öncesının soluna newNode ekliyor
                            break; //dongu kırıldı
                        }
                    }
                    //sağ - alt agac
                    else //burada eşit değerler sağ tarafa eklendi
                    {
                        current = current.Right; //saga kayıyoruz burada 
                        if (current == null) //boş pozisyon gelince gireriz
                        {
                            parent.Right = newNode; //deger atandı parent dedıgımız currentın bı oncesını tutuyor current null olunca parent yanı currentin bir öncesının soluna newNode ekliyor
                            break;//dongu kırıldı
                        }
                    }
                }
            }
        }
        public void AddRange(List<T> values)
        {
            if (values == null) throw new ArgumentNullException();
            foreach (var item in values)
            {
                Add(item);
            }
        }
        public void Clear()
        {
            Clear(Root); //kok almadan silme işlemi olduğu için rekürsif olmaz ondan böyle bişey yapıldı
            Root = null; //ustekı rootu sılmez burada tamamen sildik
        }
        private void Clear(IBinaryNode<T> Root)
        {
            if (Root != null) //null değilken gir
            {
                Clear(Root.Left); //ilk sola gir
                Clear(Root.Right); //sonra sağa
                Root.Left = null; //sil
                Root.Right = null; //sil
            }
        }
        public T FindMin()
        {
            var current = Root;
            while (current.Left != null) //sol taraf null olana kadar ılerle
            {
                current = current.Left;//curentı bı sola at
            }
            return current.Value; //currentın valusunu gonder
        }


        protected List<IBinaryNode<T>> findRootAlllist = new();
        public List<IBinaryNode<T>> FindRootAll(T value)
        {
            if (value == null) throw new ArgumentNullException();
            return FindRootAll(Root, value);
        }
        protected List<IBinaryNode<T>> FindRootAll(IBinaryNode<T> Root, T value)
        {
            var current = Root;
            while (value.CompareTo(current.Value) != 0) //eşit değil ise gir
            {
                if (value.CompareTo(current.Value) < 0)//-1 küçük deger kucuk ıse sola gıdıcez
                {
                    current = current.Left;
                }
                else if (value.CompareTo(current.Value) > 0) //deger buyuk ıse saga gıdıcez
                {
                    current = current.Right;
                }
                if (current == null)
                {
                    return null;
                }
            }
            findRootAlllist.Add(current); //listeye ekle bu nodu
            FindRootAll(current.Right, value); //ekleme işleminde eşit olanları sağa eklemıiştık bulunanın sagına git dedik
            return findRootAlllist; //listeyi döndük
        }

        public INode<T> FindRootDepht(T value)
        {
            var data = FindRootAll(value);
            data.Reverse(); //en sonu alabilmek için yaptık
            return data[0];
        }

        public IBinaryNode<T> FindRootFirst(T value)
        {
            if (value == null) throw new ArgumentNullException();
            var current = Root;
            while (value.CompareTo(current.Value) != 0) //eşit değil ise gir
            {
                if (value.CompareTo(current.Value) < 0)//-1 küçük deger kucuk ıse sola gıdıcez
                {
                    current = current.Left;
                }
                else if (value.CompareTo(current.Value) > 0) //deger buyuk ıse saga gıdıcez
                {
                    current = current.Right;
                }
                if (current == null)
                {
                    return null;
                }
            }
            return current;
        }


        public void ToDrawAllPaths()
        {
            if (Root == null) throw new ArgumentNullException();
            var path = new T[256];  //dedgerlerı tutucak dızı 
            PrintPath(Root, path, 0);
        }

        private void PrintPath(IBinaryNode<T> root, T[] path, int len)
        {
            if (root == null)
            {
                return; //root null ıse gerı doncez
            }
            path[len] = root.Value; //diziye degerleri atıyoruz
            len++; //1 artırdık bı sonrakı degerı eklemek için
            if (root.Left == null && root.Right == null)
            {
                //yaprak ise yazdırmaya git
                PrintArray(path, len);
            }
            else //yaptak degil ise 
            {
                PrintPath(root.Left, path, len); //ilk sola git diziyi ve uzunlugu da götür 
                PrintPath(root.Right, path, len); //sonra aynı sekilde sağa git 
            }
        }
        private void PrintArray(T[] path, int len) //gelen pathi yazdırır
        {
            for (int l = 0; l < len; l++)
            {
                Console.Write($"{path[l],-5}");
            }
            Console.WriteLine("");
        }



        public void RemoveAll(T value)
        {
            while (true)
            {
                var data = FindRootFirst(value);
                if (data != null)
                {
                    RemoveFirst(value);
                }
                else
                {
                    break;
                }
            }
        }
        /*
        #region Sadık Remove
        private IBinaryNode<T> DeleteNode(IBinaryNode<T> root, T value)
        {
            if (root == null)
                return null;

            // Değeri aranan düğümü bul
            if (value.CompareTo(root.Value) < 0) //deger kucuk ıse sola gıt
            {
                root.Left = DeleteNode(root.Left, value);
            }
            else if (value.CompareTo(root.Value) > 0)//deger buyuk ıse saga gıt
            {
                root.Right = DeleteNode(root.Right, value);
            }
            else
            {
                // Silinecek düğüm bulundu

                // Durum 1: Yaprak düğüm
                if (root.Left == null && root.Right == null)
                {
                    root = null;
                }
                // Durum 2: Tek çocuklu düğüm
                else if (root.Left == null) //solu null ıse sağını döndür
                {
                    root = root.Right; //burada solu olmadıgı ıcın drekt olarak sağındaki ilk elemanı göndeririz
                }
                else if (root.Right == null) //sagı null ıse solu dondur
                {
                    root = root.Left;//burada sağı olmadıgı ıcın drekt olarak solundaki ilk elemanı göndeririz
                }
                // Durum 3: İki çocuklu düğüm
                else
                {
                    var successor = FindMinimum(root.Right); // Sağ alt ağacın en küçük değerli düğümü bul cunku sıstemı tek o bozmaz

                    //root.Value = successor.Value; // Silinecek düğümün değerini kucukdeger ile güncelle
                    //root.Right = DeleteNode(root.Right, successor.Value); // degeri değiştirileni agacın kokunu kuculterek sileriz çünkü asıl sılınmek ıstenılenın altındak min değeri bulduk ve onun değerini ona kopyaladık aynı gederden 2 tane var o yuzden

                    successor.Left = root.Left;
                    successor.Right = root.Right;
                    root = successor;
                    successor = null;
                }
            }

            return root;
        }
        #endregion
        */
        private IBinaryNode<T> FindMinimum(IBinaryNode<T> node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }

            return node;
        }


        public IEnumerator<T> GetEnumerator()
        {
            return new BSTEnumetator<T>(Root);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
