using System;

namespace 链表
{

    class Node
    {
        public int Content;
        public Node Next;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var first = new Node();
            Node current = first;
            for (var i = 0; i < 10; i++)
            {
                current.Content = i;
                current = current.Next = new Node();
            }

            current = first;
            while (null != current.Next)
            {
                Console.Write(current.Content);
                current = current.Next;
            }
        }
    }
}
