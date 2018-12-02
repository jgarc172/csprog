using System;
using System.Collections.Generic;

namespace lab15_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> alphabet = new Stack<char>();
            alphabet.Push('A');
            Console.WriteLine(alphabet.Peek());
            
            alphabet.Push('B');
            Console.WriteLine(alphabet.Peek());
            
            alphabet.Push('C');
            Console.WriteLine(alphabet.Peek());

            Console.WriteLine("First iteration:");
            while (alphabet.Count > 0)
            {
                Console.WriteLine(alphabet.Pop());
            }

            Console.WriteLine("count is {0}", alphabet.Count);
        }
    }
}
