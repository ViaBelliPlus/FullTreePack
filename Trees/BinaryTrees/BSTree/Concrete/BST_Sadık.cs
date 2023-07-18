using Core.Utilities.Results;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Trees.BinaryTrees.BSTree.Abstract;
using Trees.BinaryTrees.Node.Abstract;
using Trees.BinaryTrees.Node.Concrete;

namespace Trees.BinaryTrees.BSTree.Concrete
{
    public partial class BST<T> : IBinarySearchTree<T>,IEnumerable<T> where T : IComparable
    {
        public IBinaryNode<T> Root { get; set; }
        public BST()
        {
            Root = null; 
        }
        public BST(IEnumerable<T> collection):this()
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }
        /// <summary>
        /// Verilen T tipindeki değeri ağaca uygun şekilde ekler
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"></exception>
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
                    {/*
                      CompareTo() içine gelen ile değeri karsılastırır
                        içine gelen değer:
                        küçük ise -1
                        büyük ise +1
                        eşit ise 0 döner
                      */
                        current = current.Left; //burada currentın degerını curentin solu yaptık currentın degerı gitti ama parent tutuyor 
                        if (current == null) //boşpozisyon aranıyor current boş ise girer boş değilse wher bidaha döner boş yer buluncaya kadar
                        {
                            parent.Left = newNode; //deger atandı parent dedıgımız currentın bı oncesını tutuyor current null olunca parent yanı currentin bir öncesının soluna newNode ekliyor
                            break; //dongu kırıldı
                        }
                    }
                    //sağ - alt agac
                    else
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

        /// <summary>
        /// Gelen T Listesindeki elemanları uygun yerlere yerleştirir
        /// </summary>
        /// <param name="values"></param>
        public void AddRange(List<T> values)
        {
            foreach (var item in values)
            {
                Add(item);
            }
        }

        /// <summary>
        /// Bu methot çalıştırılır ise ağac komple silinecektir
        /// </summary>
        public void Clear()
        {
            Clear(Root); //kok almadan silme işlemi olduğu için rekürsif olmaz ondan böyle bişey yapıldı
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
        /// <summary>
        /// Ağacın en küçük değerini verir
        /// </summary>
        /// <returns></returns>
        public T FindMin()
        {
            var current = Root;
            while (current.Left!=null) //sol taraf null olana kadar ılerle
            {
                current = current.Left;//curentı bı sola at
            }
            return current.Value; //currentın valusunu gonder
        }
        public List<INode<T>> FindRootAll(T value)
        {
            throw new NotImplementedException();
        }

        public INode<T> FindRootDepht(T value)
        {
            throw new NotImplementedException();
        }

        public INode<T> FindRootFirst(T value)
        {
            throw new NotImplementedException();
        }
        public void ToDrawAllPaths()
        {
            throw new NotImplementedException();
        }
        public void RemoveAll(T value)
        {
            throw new NotImplementedException();
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
