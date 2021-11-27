using System;
using System.Collections.Generic;
using System.Linq;

//First In First Out
namespace Queue
{
    class Program
    {
        public static Queue<int> queueValues = new Queue<int>();

        static void Main(string[] args)
        {
            // First in First Out
            // Enqueue -- Add element to the top of the list
            // Dequeue -- Remove element from top of the list
            // peek -- display the leement from the top of the list

            Implement_Queue queue = new Implement_Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Dequeue();

            Console.WriteLine(queue.Peek());

            foreach (int currentValue in queueValues)
            {
                Console.WriteLine(currentValue);
            }
            Console.WriteLine("Hello World!");
        }

        public void Enqueue()
        {
            queueValues.Enqueue(1);
            queueValues.Enqueue(2);
            queueValues.Enqueue(3);
            queueValues.Enqueue(4);
            queueValues.Enqueue(5);
            queueValues.Enqueue(6);
            queueValues.Enqueue(7);
        }

        public void Dequeue()
        {
            int value = queueValues.Dequeue();
            Console.WriteLine(value);
        }

        public void DequeueOnExists()
        {
            if (queueValues.Any())
            {
                queueValues.Dequeue();
            }
            queueValues.TryDequeue(out int value);
        }

        public void DequeueSpecificValue()
        {
            queueValues = new Queue<int>(queueValues.Where(x => x != 2));
        }
    }
}
