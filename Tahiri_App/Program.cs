using Trees.BinaryTrees.BSTree.Concrete;
BST<int> intss = new();
intss.Add(11);
BST<int> ints = new();
ints.Add(100);
ints.Add(2);
ints.Add(10);
ints.Add(11);
ints.Add(200);
ints.Add(210);
ints.Add(500);
ints.Add(90);
ints.Add(54);
#region DeepNode() Kontrol
var deep = ints.DeepNode();
#endregion
#region FindMax() Kontrol
var max = ints.FindMax();
#endregion
#region FindRoot() Kontrol
bool ctr = ints.FindRoot(intss.Root);
#endregion
#region FindPath Kontrol
var path = ints.FindPath(deep);
#endregion

Console.ReadLine();
