using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode treeNode = new TreeNode(3);
            Implement_BinaryTree.Insert(9, treeNode);
            Implement_BinaryTree.Insert(90, treeNode);
            Implement_BinaryTree.Insert(32, treeNode);
            Implement_BinaryTree.Insert(7, treeNode);
            Implement_BinaryTree.Insert(44, treeNode);
            Implement_BinaryTree.Insert(60, treeNode);
            Implement_BinaryTree.Insert(86, treeNode);
            Implement_BinaryTree.Insert(93, treeNode);
            Implement_BinaryTree.Insert(99, treeNode);
            Implement_BinaryTree.Insert(100, treeNode);
            Implement_BinaryTree.Insert(2, treeNode);


            //Find Node
            TreeNode findNode = Implement_BinaryTree.Find(93, treeNode);


            //Smallest Value
            int? smallestValue = Implement_BinaryTree.SmallestValue(treeNode);


            //Largest Value
            int? largestValue = Implement_BinaryTree.LargestValue(treeNode);


            //InOrder Traversal 
            //Left->Root->Right Nodes recursively of each subtree 
            Implement_BinaryTree.InOrderTraversal(treeNode);


            //InOrder Traversal
            //Root->Left->Right Nodes recursively of each subtree 
            Implement_BinaryTree.PreOrderTraversal(treeNode);


            //Postorder Traversal
            //Left->Right->Root Nodes recursively of each subtree 
            Implement_BinaryTree.PreOrderTraversal(treeNode);


            //Highest Height
            Console.WriteLine($"Highest Height = {Implement_BinaryTree.Height(treeNode)}");


            //Left Height
            Console.WriteLine($"Left Height = {Implement_BinaryTree.Left_Height(treeNode)}");


            //Right Height
            Console.WriteLine($"Right Height = {Implement_BinaryTree.Right_Height(treeNode)}");


            //Number Of Leaf Nodes
            Console.WriteLine($"Number Of Leaf Nodes = {Implement_BinaryTree.NumberOfLeafNodes(treeNode)}");


            //IsBalanced
            Console.WriteLine($"IsBalanced = {Implement_BinaryTree.IsBalanced(treeNode)}");


            //End of the statement
            Console.WriteLine("Hello World!");
        }
    }
}
