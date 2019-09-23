using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(13);
            stack.Push("adam");
            stack.Push("33");
            stack.Push(5);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }

    public class Stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new ArgumentException("The object is null!");
            else
                _list.Add(obj);
        }

        public object Pop()
        {
            var numberOfObj = _list.Count;
            if (numberOfObj < 1)
                throw new ArgumentException("List is empty!");
            else
            {
                var currentObj = _list[numberOfObj - 1];
                _list.Remove(currentObj);

                return currentObj;
            }
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}
