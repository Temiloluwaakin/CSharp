using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackObject
{
    class Container
    {
        static void Main(string[] args)
        {
            IStack stack = new Stacks();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            stack.DisplayArray();

            stack.Pop();
            stack.Pop();

            stack.DisplayArray();



        }
    }
}
