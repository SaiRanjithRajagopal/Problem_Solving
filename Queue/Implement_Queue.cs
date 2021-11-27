using LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    public class Implement_Queue
    {
        public ListNode Head;

        public Implement_Queue()
        {
            Head = null;
        }

        public void Enqueue(int value)
        {
            if (Head == null)
            {
                Head = new ListNode(value);
            }
            else
            {
                AddItem(value, Head);
            }
        }

        private void AddItem(int value, ListNode node)
        {
            if (node.next != null)
            {
                AddItem(value, node.next);
            }
            else
            {
                node.next = new ListNode(value);
            }
        }

        public void Dequeue()
        {
            if (Head != null)
            {
                Head = Head.next;
            }
            else
            {
                throw new Exception();
            }
        }

        public int Peek()
        {
            if (Head != null)
            {
                return Head.val;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
