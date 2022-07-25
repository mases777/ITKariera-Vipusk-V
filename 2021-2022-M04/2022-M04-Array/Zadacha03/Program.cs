using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var stack = new ArrayStack<int>();

            //var items = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            //foreach (var item in items)
            //{
            //    stack.Push(item);
            //}

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine($"{stack.Pop()}");
            //}

            //var stack2 = new Stack<int>();
            //var items2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //foreach (var item in items2)
            //{
            //    stack2.Push(item);
            //}
            //while (stack2.Count > 0)
            //{
            //    Console.WriteLine($"{stack2.Pop()}");
            //}

            var queue = new Queue<int>();
            var items3 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (var item in items3)
            {
                queue.Enqueue(item);
            }
            while (queue.Count > 0)
            {
                Console.WriteLine($"{queue.Dequeue()}");
            }
        }
    }
}
