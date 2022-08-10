using DataStructures.Trees.BinaryTree;

var root = new Node<int>(1);

root.Left = new Node<int>(2);
root.Right = new Node<int>(3);
root.Left.Left = new Node<int>(4);
root.Left.Right = new Node<int>(5);
root.Right.Left = new Node<int>(6);
root.Right.Right = new Node<int>(7);

