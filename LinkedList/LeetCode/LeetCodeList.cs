using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.LeetCode
{
    public class LeetCodeList
    {
        public static ListNode RemoveElement(int data, ListNode Node) //5,6,4
        {
            ListNode initialNode = new ListNode(0);
            var returnNode = initialNode;
            while (Node != null)
            {
                if (Node.val != data)
                {
                    returnNode.next = Node;
                    returnNode = returnNode.next;
                }
                else
                {
                    returnNode.next = null;
                }
                Node = Node.next;
            }
            return initialNode.next;
        }

        public static ListNode ReverseList(ListNode Node) //2,3,4
        {
            ListNode reverseList = null;
            while (Node != null)
            {
                reverseList = AddValue_ToFirst(Node.val, reverseList);
                Node = Node.next;
            }
            return reverseList;
        }

        public static ListNode AddValue_ToLast(int data, ListNode Node)
        {
            if (Node == null)
            {
                Node = new ListNode(data);
            }
            else
            {
                Node.next = AddValue_ToLast(data, Node.next);
            }
            return Node;
        }

        public static ListNode AddValue_ToFirst(int data, ListNode Node)
        {
            ListNode returnNode = new ListNode(data);
            if (Node != null)
            {
                returnNode.next = Node;
            }
            return returnNode;
        }

        public static void Print_From_First(ListNode Head)
        {
            if (Head != null)
            {
                Console.WriteLine(Head.val);
                Print_From_First(Head.next);
            }
        }

        public static void PrintFromLast(ListNode Head)
        {
            if (Head != null)
            {
                PrintFromLast(Head.next);
                Console.WriteLine(Head.val);
            }
        }
    }
}
