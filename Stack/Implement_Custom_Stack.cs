using LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Implement_Custom_Stack
    {
        public ListNode Head;

        public Implement_Custom_Stack()
        {
            Head = null;
        }

        public void Push(int value)
        {
            if (Head == null)
            {
                Head = new ListNode(value);
            }
            else
            {
                ListNode temp = Head;
                Head = new ListNode(value);
                Head.next = temp;
            }
        }

        public void Pop()
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
