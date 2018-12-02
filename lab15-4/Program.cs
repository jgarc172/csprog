using System;
using System.Collections.Generic;

namespace lab15_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> q = new Queue<char>();
            q.Enqueue('a');
            q.Enqueue('b');
            q.Enqueue('c');
            q.Enqueue('d');

            Console.WriteLine("queue contains ");
            printQ(q);

            q.Enqueue('a');
            q.Enqueue('b');
            q.Enqueue('c');
            q.Enqueue('d');

            Stack<char> iStack = new Stack<char>();
            Console.WriteLine("reversing queue . . .");
            while (q.Count > 0)
            {
                iStack.Push(q.Dequeue());
            }
            while (iStack.Count > 0)

            {

                q.Enqueue(iStack.Pop());

                Console.WriteLine(q.Dequeue());

            }

        }
        public static void printQ(Queue<char> q)
        {
            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }
        }

    }
}
