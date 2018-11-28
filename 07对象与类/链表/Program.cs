using System;

namespace 链表
{
    //定义一个类，名字叫做节点
    class Node
    {
        public int Content;//内容
        public Node Next;//指向下一个对象
    }

    class Program
    {
        static void Main(string[] args)
        {
            var first = new Node();
            Node current = first;//保留第一个对象的地址
            for (var i = 0; i < 10; i++)//添加9个成员
            {
                current.Content = i;
                current.Next = new Node();//为新创建的对象创建快捷方式
                current = current.Next;//current地址修改为刚才创建的对象
            }

            current = first;
            while (null != current.Next)//遍历访问每个成员
            {
                Console.Write(current.Content);
                current = current.Next;
            }
        }
    }
}
