using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Program138_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack my_stack = new Stack();
            my_stack.Push("Summy");
            my_stack.Push("Sunny");
            my_stack.Push("Ranjeet");
            my_stack.Push(1234);
            my_stack.Push(null);
            my_stack.Push(123.87);
            my_stack.Push('S');

            foreach(var i in my_stack)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
