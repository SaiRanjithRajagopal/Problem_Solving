using System;
using System.Collections.Generic;
using System.Linq;

//Last In First Out
namespace Stack
{
    class Program
    {
        public static Stack<int> insertValue = new Stack<int>();

        static void Main(string[] args)
        {
            //Stack is last in first out
            //Push Inserts an item at the top of the stack.
            //Pop Removes and returns items from the top of the stack.
            //Peek()  Returns the top item from the stack.

            //Custom Stack
            Custom_Stack();

            //Loop All 
            foreach (int currentValue in insertValue)
            {
                Console.WriteLine(currentValue);
            }

            Console.WriteLine("Hello World!");
        }

        public void Push()
        {
            insertValue.Push(1);
            insertValue.Push(2);
            insertValue.Push(3);
        }

        public void Pop()
        {
            //Another Way 1
            int value = insertValue.Pop();
            Console.WriteLine(value);

            //Another Way 2
            if (insertValue.Count > 0) //2
            {
                Console.WriteLine($"Pop - {insertValue.Pop()}");
            }

            //Another Way 3
            if (insertValue.Any()) //3
            {
                Console.WriteLine($"Pop - {insertValue.Pop()}");
            }

            //another Way 4
            // int? g = insertValue.Any() ? insertValue.Pop() : null;

            //another Way 5
            if (insertValue.Contains(5)) //5
            {
                insertValue.Pop();
            }
        }

        public void Peek()
        {
            int value = insertValue.Peek();
            Console.WriteLine(value);
            Console.WriteLine($"Peek - {insertValue.Peek()}");
        }

        public void PopOnExists()
        {
            if (insertValue.Any())
            {
                insertValue.Pop();
            }
            insertValue.TryPop(out int value);
        }

        public void PopSpecificValue()
        {
            insertValue = new Stack<int>(insertValue.Where(x => x != 2));
        }

        public static void Custom_Stack()
        {
            Implement_Custom_Stack customStack = new Implement_Custom_Stack();

            //Push
            customStack.Push(5);
            customStack.Push(6);
            customStack.Push(7);

            //Pop
            customStack.Pop();

            //Peek
            Console.WriteLine(customStack.Peek());
        }
    }
}
