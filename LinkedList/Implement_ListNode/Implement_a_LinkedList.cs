using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Implement_ListNode
{
    public class Implement_a_LinkedList
    {
        public ListNode Head;
        public Implement_a_LinkedList()
        {
            Head = null;
        }

        public void AddFirst(int data)
        {
            if (Head == null)
            {
                Head = new ListNode(data);
            }
            else
            {
                ListNode temp = Head;
                Head = new ListNode(data);
                Head.next = temp;
            }
        }

        public void AddLast(int data)
        {
            if (Head == null)
            {
                Head = new ListNode(data);
            }
            else
            {
                AddValueToLast(Head, data);
            }
        }
        private void AddValueToLast(ListNode Head, int data)
        {
            if (Head.next != null)
            {
                AddValueToLast(Head.next, data);
            }
            else
            {
                Head.next = new ListNode(data);
            }
        }

        public void RemoveLastNode(ListNode Head)
        {
            if (Head.next != null)
            {
                if (Head.next.next == null) //7->5->2->3
                {
                    Head.next = null;
                }
                else
                {
                    RemoveLastNode(Head.next);
                }
            }
        }

        public ListNode RemoveFrontNode()
        {
            Head = Head.next;
            return this.Head;
        }

        public void ClearAll()
        {
            this.Head = null;
        }

        public void Print_From_First(ListNode Head)
        {
            if (Head != null)
            {
                Console.WriteLine(Head.val);
                Print_From_First(Head.next);
            }
        }

        public void PrintFromLast(ListNode Head)
        {
            if (Head != null)
            {
                PrintFromLast(Head.next);
                Console.WriteLine(Head.val);
            }
        }
    }
}
