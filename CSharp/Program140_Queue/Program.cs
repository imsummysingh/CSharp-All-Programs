using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Program140_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue my_queue = new Queue();

            my_queue.Enqueue("GFG");
            my_queue.Enqueue(1);
            my_queue.Enqueue(123);
            my_queue.Enqueue(null);
            my_queue.Enqueue(2.4);
            my_queue.Enqueue("Geeks123");

            Console.WriteLine("The count of Queue is: {0}", my_queue.Count);

            foreach(var i in my_queue)
            {
                Console.WriteLine(i);
            }

            my_queue.Dequeue();
            my_queue.Dequeue();

            Console.WriteLine("The count of queue after removing element is: {0}", my_queue.Count);

            foreach (var i in my_queue)
            {
                Console.WriteLine(i);
            }

            my_queue.Clear();

            Console.WriteLine("The count of queue after clearing element is: {0}", my_queue.Count);

            Console.ReadLine();
        }
    }
}
