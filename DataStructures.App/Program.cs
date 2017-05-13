using System;
using DataStructures.Core;
using DataStructures.Core.Contracts;

namespace DataStructures.App
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine(stack.Empty);
            Console.WriteLine(stack.Top);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Empty);
            Console.ReadKey();*/
            var queue = new Queue<int>();
            queue.Push(1);
            queue.Push(2);
            queue.Push(3);
            queue.Push(4);
            Console.WriteLine(queue.Empty);
            Console.WriteLine(queue.Top);
            Console.WriteLine(queue.Pop());
            Console.WriteLine(queue.Pop());
            Console.WriteLine(queue.Pop());
            Console.WriteLine(queue.Pop());
            Console.WriteLine(queue.Empty);
            Console.ReadKey();
        }
    }
}
