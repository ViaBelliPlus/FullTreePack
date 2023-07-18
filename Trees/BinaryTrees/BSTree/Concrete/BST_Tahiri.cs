using Core.Utilities.Messages;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Trees.BinaryTrees.BSTree.Abstract;
using Trees.BinaryTrees.Node.Abstract;

namespace Trees.BinaryTrees.BSTree.Concrete
{
    public partial class BST<T> : IBinarySearchTree<T> where T : IComparable
    {
        public IBinaryNode<T> DeepNode()
        {
            #region O(n^2)
            /*
            var ptr = Root;
            while (ptr.Right != null || ptr.Left != null)
            {
                int rightDepht = MaxDepht(ptr.Right);
                int leftDepht = MaxDepht(ptr.Left);
                if(rightDepht < leftDepht)
                {
                    ptr = ptr.Left;
                }
                else
                {
                    ptr = ptr.Right;
                }
            }
            return ptr;
            */
            #endregion 
            #region O(n)
            var Q = new Queue<IBinaryNode<T>>(); // Kuyruk yapısına ekleme yaparak aşağı doğru ekleyeceğiz
            Q.Enqueue(Root);
            IBinaryNode<T> temp = null; //Boş bir değişken
            while (Q.Count > 0) //Kurukta kontrol edilecek değer kalmayınca döngü durur.
            {
                temp = Q.Dequeue(); // Burada kuyruğa eklenmiş ilk değeri çıkartıyoruz.
                //Daha sonra sağını ve solunu kontrol ediyoruz.
                if (temp.Left != null)
                {
                    Q.Enqueue(temp.Left); //Null değilse kuyruğa kontrol yapmak için ekliyoruz.
                }
                if (temp.Right != null)
                {
                    Q.Enqueue(temp.Right);
                }
                //Bu işlemleri sırasıyla yaptığımızda kuyruğa eklenen her değer için bir kontrol yapacak ve o değeri daha derine götürebiliyorsa kuyruğa ekleyecektir. Böylece kuyruğa son eklenen değer en derindeki değer olacaktır.
            }
            return temp;
            #endregion
        }
        //O(log(n))
        public T FindMax()
        {
            Validate(Root); //Kökümüz boş mu o kontrol edilir.
            var ptr = Root;
            while (ptr.Right != null) { ptr = ptr.Right; } //Sağ tarafta en büyük değer olacağı için en sağa gidilmeye çalışılır.
            return ptr.Value;
        }
        //O(long(n))
        public bool FindRoot(IBinaryNode<T> node)
        {
            Validate(node);
            var ptr = Root;
            while (ptr != node) //Node ve arama pointerımız eşit ise döngü sonlanır.
            {
                if (ptr == null) return false; //ptr null olduğu halde hala döngü sonlanmadıysa o zaman böyle bir node yoktur.

                if (node.Value.CompareTo(ptr.Value) < 0) //Değerlerini kontrol ederek sağa veya sola doğru hareket ediyoruz.
                {
                    ptr = ptr.Left;
                }
                else
                {
                    ptr = ptr.Right;
                }
            }
            return true; //Döngü düzgün bir şekilde sonlandıysa node ilgili ağaçta vardır.
        }
        //O(log(n))
        public List<IBinaryNode<T>> FindPath(IBinaryNode<T> findedRoot)
        {
            Validate(findedRoot);
            var ptr = Root;
            var Q = new List<IBinaryNode<T>>(); //Kuruğa ilgili path'i ekleyeceğiz ekleyeceğiz.
            Q.Add(Root);
            while (!ptr.Equals(findedRoot)) //Node ve arama pointerımız eşit ise döngü sonlanır.
            {
                if (ptr == null) throw new ArgumentException(ErrorMessages.MissingValueMessage); //ptr null olduğu halde hala döngü sonlanmadıysa o zaman böyle bir node yoktur.

                if (findedRoot.Value.CompareTo(ptr.Value) < 0) //Değerlerini kontrol ederek sağa veya sola doğru hareket ediyoruz.
                {
                    Q.Add(ptr.Left); //
                    ptr = ptr.Left;
                }
                else
                {
                    Q.Add(ptr.Right);
                    ptr = ptr.Right;
                }
            }
            return Q;
        }
        public int MaxDepht(IBinaryNode<T> root) //Recursive mantıkla çalışır!
        {
            if (root == null) return 0;
            int leftDepht = MaxDepht(root.Left);
            int rightDepht = MaxDepht(root.Right);

            return (leftDepht > rightDepht) ? leftDepht + 1 : rightDepht + 1;
        }

        public void Remove(IBinaryNode<T> value)
        {
            Validate(value);
            if (FindRoot(value))
            {
                if (value.Right == null && value.Left == null)
                {
                    var Q = FindPath(value);
                    var temp = Q[Q.Count - 1];
                    var temp2 = Q[Q.Count - 2];
                    if (temp2.Right != null && temp2.Right.Equals(temp))
                    {
                        temp2.Right = null;
                    }
                    else
                    {
                        temp2.Left = null;
                    }
                }
                else
                {
                    IBinaryNode<T> removedRoot = FindMinRoot(value.Right);
                    value.Value = removedRoot.Value;
                    Remove(removedRoot);
                }
            }
        }
        private IBinaryNode<T> FindMinRoot(IBinaryNode<T> root)
        {
            IBinaryNode<T> current = root;
            while (current.Left != null) //sol taraf null olana kadar ılerle
            {
                current = current.Left;//curentı bı sola at
            }
            return current; //currentın valusunu gonder
        }
        public void RemoveFirst(T value)
        {
            Validate(value);
            Remove(FindRootFirst(value));
        }
        public void RemoveRange(List<T> values)
        {
            foreach (T value in values)
            {
                if (FindRootFirst(value) != null)
                    RemoveFirst(value);
            }
        }
    }
    private void Validate(object? obj)
    {
        if (obj == null) throw new ArgumentNullException(nameof(obj));
    }
    private void Validate(object? obj, object? obj2)
    {
        if (obj == null || obj2 == null) throw new ArgumentNullException(nameof(obj2));
    }
}
}
