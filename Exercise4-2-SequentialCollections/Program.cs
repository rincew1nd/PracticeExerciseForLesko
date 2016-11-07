using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_2_SequentialCollections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QueueEx.Test();
            StackEx.Test();
            Console.ReadKey();
        }

        public class QueueEx
        {
            public static void Test()
            {
                var queue = new Queue<string>();
                queue.Enqueue("First");
                queue.Enqueue("Second");
                queue.Enqueue("Third");
                queue.Enqueue("Fourth");

                Console.WriteLine("\nQueue exercise:");
                while (queue.Count != 0)
                    Console.WriteLine($"Position {queue.Count} : Value \"{queue.Dequeue()}\"");
                Console.WriteLine("Queue is empty");
            }
        }

        public class StackEx
        {
            public static void Test()
            {
                var queue = new Stack<string>();
                queue.Push("First");
                queue.Push("Second");
                queue.Push("Third");
                queue.Push("Fourth");

                Console.WriteLine("\nStack exercise:");
                while (queue.Count != 0)
                    Console.WriteLine($"Position {queue.Count} : Value \"{queue.Pop()}\"");
                Console.WriteLine("Stack is empty");
            }
        }
    }
}
