using Trees.BinaryTrees.BSTree.Concrete;
BST<int> intss = new();
intss.Add(11);
intss.Add(10);
intss.Add(9);
intss.Add(12);
var lists = intss.InOrderNR();
BST<int> ints = new();
ints.Add(100);
ints.Add(220);
ints.Add(100);
ints.Add(2);
ints.Add(1);
ints.Add(10);
ints.Add(11);
ints.Add(200);
ints.Add(150);
ints.Add(170);
ints.Add(190);
ints.Add(110);
ints.Add(410);
ints.Add(220);
ints.Add(220);
ints.Add(210);
ints.Add(280);
ints.Add(297);
ints.Add(210);
ints.Add(500);
ints.Add(90);
ints.Add(54);

ints.ToDrawAllPaths();
var list = ints.LevelOrder();

#region DeepNode() Kontrol
var deep = ints.DeepNode();
#endregion
#region FindMax() Kontrol
var max = ints.FindMax();
#endregion
#region FindRoot() Kontrol
bool ctr = ints.FindRoot(intss.Root);
#endregion
ints.RemoveFirst(2);
#region FindPath Kontrol
var path = ints.FindPath(deep);
#endregion

Console.ReadLine();
