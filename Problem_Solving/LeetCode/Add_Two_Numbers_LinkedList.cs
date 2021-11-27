using LinkedList;
using LinkedList.Implement_ListNode;
using LinkedList.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_Solving.LeetCode
{
    public class Add_Two_Numbers_LinkedList
    {
        static Implement_a_LinkedList firstList;
        static Implement_a_LinkedList secondList;

        public Add_Two_Numbers_LinkedList()
        {
            //5,6,4
            firstList = new Implement_a_LinkedList();
            firstList.AddLast(5);
            firstList.AddLast(6);
            firstList.AddLast(4);

            //2,4,3
            secondList = new Implement_a_LinkedList();
            secondList.AddLast(2);
            secondList.AddLast(4);
            secondList.AddLast(3);
        }

        public static void Add_Two_Numbers()
        {
            //Convert to string
            string listOneValue = null;
            ConvertToString(firstList.Head, ref listOneValue);

            //Convert to string
            string listTwoValue = null;
            ConvertToString(secondList.Head, ref listTwoValue);

            //Add two values
            int finalValue = Int32.Parse(listOneValue) + Int32.Parse(listTwoValue);

            //Convert into int Array
            int[] result = finalValue.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray(); //807

            //Save the Value into new list
            //ListNode resultSet_First = new ListNode(0, null);
            ListNode resultSet_Last = new ListNode(0, null);
            foreach (int value in result)
            {
                //resultSet_First.next = AddValue_ToFirst(value, resultSet_First.next); //Last in First //708
                resultSet_Last.next = LeetCodeList.AddValue_ToLast(value, resultSet_Last.next);  //Fisrt in First out //807
            }

            LeetCodeList.Print_From_First(resultSet_Last);
        }

        public static void ConvertToString(ListNode Head, ref string value)
        {
            if (Head != null)
            {
                value = value + Head.val;
                ConvertToString(Head.next, ref value);
            }
        }
    }
}
