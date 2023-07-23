using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.BinaryTrees.Node;

namespace Trees.BinaryTrees.BaseBT
{
    public static class BinaryTree<T>
    {
        public static List<IBinaryNode<T>> list;
        static BinaryTree()
        {
            list = new List<IBinaryNode<T>>();
        }

        /// <summary>
        /// InOrder --> Left - Data - Right
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        private static List<IBinaryNode<T>> InOrderAlgorithm(IBinaryNode<T> root)
        {
            if (root != null)
            {
                InOrderAlgorithm(root.Left);
                list.Add(root);
                InOrderAlgorithm(root.Right);
            }
            return list;
        }
        /// <summary>
        ///  InOrderNr --> Left - Data - Right
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static List<IBinaryNode<T>> InOrderNR(IBinaryNode<T> root)
        {
            var stcak = new Stack<IBinaryNode<T>>(); //bir stack yapısı kullanmamız gerekir
            IBinaryNode<T> currentNode = root; //temp deger
            bool done = false;//kontrol saglıycak bıze 
            while (!done)
            {
                if (currentNode != null) //boş değilse gir
                {
                    stcak.Push(currentNode); // stac e suankı nod u veririz
                    currentNode = currentNode.Left; // sonra curudu bir alta göndeririz sol göndercez null olması önemsiz null olursa bir alta gidicek 
                }
                else //gelen current null ise girer buraya
                {
                    if (stcak.Count == 0) //stacın elemanı önemlidir burada 
                    {
                        done = true; //eleman kalmadı ise true don while yi kır
                    }
                    else//stacde eleman var ise gir
                    {
                        currentNode = stcak.Pop(); //en son eklenen eleman çekilir ve current noda verilir burada bi sorun olmaz cünkü current boş olduğu zaman buraya giriyorduk 
                        list.Add(currentNode); //lsteye currentı ekleriz 
                        currentNode = currentNode.Right; //burada en altta oluyoruz currentin sağına gir dedik sağı null ise gene buraya gelir nul değil ise o degerşde stac e ekler sonra onun dallarına  bakar ve böyle devam eder bu işlem
                    }
                }
            }
            return list;
        }
        /// <summary>
        ///  PostOrder --> Data - Left - Right
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        private static List<IBinaryNode<T>> PostOrderAlgorithm(IBinaryNode<T> root)
        {
            if (root != null)
            {
                PostOrderAlgorithm(root.Left);
                PostOrderAlgorithm(root.Right);
                list.Add(root);
            }
            return list;
        }
        
        public static List<IBinaryNode<T>> PostOrderNR(IBinaryNode<T> root)
        {
            if (root == null) throw new ArgumentException();
            Stack<IBinaryNode<T>> stack = new Stack<IBinaryNode<T>>();
            stack.Push(root);
            IBinaryNode<T> prev = null; //Listeye giren son eleman
            while (stack.Count > 0)
            {
                var temp = stack.Peek();
                if((temp.Right == null && temp.Left == null) || (prev != null && (temp.Left == prev || temp.Right == prev)))
                {
                    list.Add(temp);
                    stack.Pop();
                    prev = temp;
                    continue;
                }
                if(temp.Right != null)
                {
                    stack.Push(temp.Right);
                }
                if(temp.Left != null)
                {
                    stack.Push(temp.Left);
                }
            }
            return list;
        }


        private static List<IBinaryNode<T>> PreOrderAlgorithm(IBinaryNode<T> root)
        {
            if (root != null)
            {
                list.Add(root);
                PreOrderAlgorithm(root.Left);
                PreOrderAlgorithm(root.Right);
            }
            return list;
        }
        public static List<IBinaryNode<T>> PreOrderNR(IBinaryNode<T> root)
        {
            // D - L - R

            if (root == null) throw new ArgumentNullException();
            Stack<IBinaryNode<T>> s = new();
            s.Push(root);
            IBinaryNode<T> current = root;
            while (s.Count > 0)
            {
                current = s.Pop();
                list.Add(current);
                if (current.Right != null)
                {
                    s.Push(current.Right);
                }
                if (current.Left != null)
                {
                    s.Push(current.Left);
                }
            }
            return list;
        }
        private static List<IBinaryNode<T>> LevelOrderAlgorithm(Queue<IBinaryNode<T>> values)
        {
            if (values.Count > 0)
            {
                IBinaryNode<T> temp = values.Dequeue();
                list.Add(temp);
                if (temp.Left != null)
                {
                    values.Enqueue(temp.Left);
                }
                if (temp.Right != null)
                {
                    values.Enqueue(temp.Right);
                }
                LevelOrderAlgorithm(values);
            }

            return list;
        }
        public static List<IBinaryNode<T>> LevelOrderNR(IBinaryNode<T> root)
        {
            if (root == null) throw new ArgumentNullException();
            Queue<IBinaryNode<T>> s = new();
            s.Enqueue(root);

            while (s.Count > 0)
            {
                var current = s.Dequeue();
                list.Add(current);
                if (current.Left != null)
                {
                    s.Enqueue(current.Left);
                }
                if (current.Right != null)
                {
                    s.Enqueue(current.Right);
                }
            }
            return list;
        }
        public static List<IBinaryNode<T>> LevelOrder(IBinaryNode<T> root)
        {
            if (list.Count > 0) Clear(list);
            Queue<IBinaryNode<T>> temp = new();
            temp.Enqueue(root);
            return LevelOrderAlgorithm(temp);
        }
        /// <summary>
        ///  PostOrder --> Data - Left - Right
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static List<IBinaryNode<T>> PreOrder(IBinaryNode<T> root)
        {
            if (list.Count > 0) Clear(list);
            return PreOrderAlgorithm(root);
        }
        public static List<IBinaryNode<T>> PostOrder(IBinaryNode<T> root)
        {
            if (list.Count > 0) Clear(list);
            return PostOrderAlgorithm(root);
        }
        public static List<IBinaryNode<T>> InOrder(IBinaryNode<T> root)
        {
            if (list.Count > 0) Clear(list);
            return InOrderAlgorithm(root);
        }
        private static int Series(int i, int n)
        {
            int toplam = 0;
            for (; i <= n; i++)
            {
                toplam += (int)MathF.Pow(2, i);
            }
            return toplam;
        }
        private static void Clear(List<IBinaryNode<T>> list) => list.Clear();
    }
}
