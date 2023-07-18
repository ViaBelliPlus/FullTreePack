
using System.Threading.Channels;
using Trees.BinaryTrees.BaseBT.Concrete;
using Trees.BinaryTrees.BSTree.Concrete;
using Trees.BinaryTrees.Node.Concrete;

BST<int> s = new BST<int>();




s.Add(80);
s.Add(70);
s.Add(60);
s.Add(90);
s.Add(90);
s.Add(90);
s.Add(90);
s.Add(120);
s.Add(65);
s.Add(115);
s.Add(55);



BinaryTree<int>.LevelOrderNR(s.Root).ForEach(i => Console.Write($"{i,-5}"));

Console.WriteLine();

