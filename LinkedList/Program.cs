using LinkedList.Implement_ListNode;
using LinkedList.LeetCode;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Implement_a_LinkedList customLinkedList = new Implement_a_LinkedList();
            customLinkedList.AddFirst(1);
            customLinkedList.AddFirst(2);
            customLinkedList.AddFirst(3);
            customLinkedList.AddFirst(4);

            customLinkedList.RemoveLastNode(customLinkedList.Head);
            customLinkedList.PrintFromLast(customLinkedList.Head);

            //Remove Element
            LeetCodeList.Print_From_First(LeetCodeList.RemoveElement(6, customLinkedList.Head));

            Console.WriteLine("LinkedList!");
            Console.ReadLine();
        }
    }
}
