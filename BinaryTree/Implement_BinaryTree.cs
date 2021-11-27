using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Implement_BinaryTree
    {
        public static void Insert(int data, TreeNode Node)
        {
            if (Node != null)
            {
                if (data >= Node.val)
                {
                    if (Node.right == null)
                    {
                        Node.right = new TreeNode(data);
                    }
                    else
                    {
                        Insert(data, Node.right);
                    }
                }
                else
                {
                    if (Node.left == null)
                    {
                        Node.left = new TreeNode(data);
                    }
                    else
                    {
                        Insert(data, Node.left);
                    }
                }
            }
        }

        public static TreeNode Find(int data, TreeNode Node)
        {
            while (Node != null)
            {
                //if the current nodes data is equal to the value passed in return it
                if (data == Node.val)//soft delete check
                {
                    return Node;
                }
                else if (data > Node.val)//if the value passed in is greater than the current data then go to the right child
                {
                    Node = Node.right;
                }
                else//otherwise if the value is less than the current nodes data the go to the left child node 
                {
                    Node = Node.left;
                }
            }
            return null;
        }

        public static Nullable<int> SmallestValue(TreeNode Node)
        {
            // once we reach the last left node we return its data
            if (Node.left == null)
            {
                return Node.val;
            }
            else
            {//otherwise keep calling the next left node
                return SmallestValue(Node.left);
            }
        }

        public static Nullable<int> LargestValue(TreeNode Node)
        {
            // once we reach the last left node we return its data
            if (Node.right == null)
            {
                return Node.val;
            }
            else
            {//otherwise keep calling the next left node
                return LargestValue(Node.right);
            }
        }

        //Left->Root->Right Nodes recursively of each subtree 
        public static void InOrderTraversal(TreeNode Node)
        {
            if (Node.left != null)
                InOrderTraversal(Node.left);

            Console.Write(Node.val + " ");

            if (Node.right != null)
                InOrderTraversal(Node.right);
        }

        //Root->Left->Right Nodes recursively of each subtree 
        public static void PreOrderTraversal(TreeNode Node)
        {
            Console.Write(Node.val + " ");

            if (Node.left != null)
                PreOrderTraversal(Node.left);

            if (Node.right != null)
                PreOrderTraversal(Node.right);
        }

        //Left->Right->Root Nodes recursively of each subtree 
        public static void PostorderTraversal(TreeNode Node)
        {
            //First go to left child its children will be null so we print its data
            if (Node.left != null)
                PostorderTraversal(Node.left);

            //Then we go to the right node which will print itself as both its children are null
            if (Node.right != null)
                PostorderTraversal(Node.right);

            //Then we print the root node 
            Console.Write(Node.val + " ");
        }

        public static int Height(TreeNode Node)
        {
            //return 1 when leaf node is found
            if (Node.left == null && Node.right == null)
            {
                return 1; //found a leaf node
            }

            int left = 0;
            int right = 0;

            //recursively go through each branch
            if (Node.left != null)
                left = Height(Node.left);
            if (Node.right != null)
                right = Height(Node.right);

            //return the greater height of the branch
            if (left > right)
            {
                return (left + 1);
            }
            else
            {
                return (right + 1);
            }
        }

        public static int Left_Height(TreeNode Node)
        {
            if (Node.left == null)
            {
                return 1; //found a leaf node
            }

            int left = 0;

            if (Node.left != null)
                left = Left_Height(Node.left);

            return (left + 1);
        }

        public static int Right_Height(TreeNode Node)
        {
            if (Node.right == null)
            {
                return 1; //found a leaf node
            }

            int right = 0;

            if (Node.right != null)
                right = Right_Height(Node.right);

            return (right + 1);
        }

        public static int NumberOfLeafNodes(TreeNode Node)
        {
            //return 1 when leaf node is found
            if (Node.left == null && Node.left == null)
            {
                return 1; //found a leaf node
            }

            int leftLeaves = 0;
            int rightLeaves = 0;

            //recursively call NumOfLeafNodes returning 1 for each leaf found
            if (Node.left != null)
            {
                leftLeaves = NumberOfLeafNodes(Node.left);
            }
            if (Node.right != null)
            {
                rightLeaves = NumberOfLeafNodes(Node.right);
            }

            //add values together 
            return leftLeaves + rightLeaves;
        }

        public static bool IsBalanced(TreeNode Node)
        {
            int LeftHeight = Node.left != null ? Left_Height(Node) : 0;
            int RightHeight = Node.right != null ? Right_Height(Node) : 0;

            int heightDifference = LeftHeight - RightHeight;

            if (Math.Abs(heightDifference) > 1)
            {
                return false;
            }
            else
            {
                return ((Node.left != null ? IsBalanced(Node.left) : true) && (Node.right != null ? IsBalanced(Node.right) : true));
            }
        }
    }
}
