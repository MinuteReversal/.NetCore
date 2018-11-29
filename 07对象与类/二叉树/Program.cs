using System;
using System.Collections.Generic;

namespace 二叉树
{
    /*
    *                  A
    *                 / \
    *                B   C
    *               / \ / \
    *              D  E F  G
    */
    class BinaryNode
    {
        public BinaryNode Left { get; set; }
        public string Content { get; set; }
        public BinaryNode Right { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var root = CreateTree();
            Console.WriteLine(string.Join(",", Preorder(root)));
            Console.WriteLine(string.Join(",", PostOrder(root)));

        }
        ///<summary>先序遍历</summary>
        static List<string> Preorder(BinaryNode node)
        {
            var list = new List<string>();

            list.Add(node.Content);
            if (node.Left != null)
            {
                list.AddRange(Preorder(node.Left));//自己调用自己
            }
            if (node.Right != null)
            {
                list.AddRange(Preorder(node.Right));//自己调用自己
            }

            return list;
        }
        ///<summary>后序遍历</summary>
        static List<string> PostOrder(BinaryNode node)
        {
            var list = new List<string>();
            list.Add(node.Content);
            if (node.Right != null)
            {
                list.AddRange(PostOrder(node.Right));//自己调用自己
            }
            if (node.Left != null)
            {
                list.AddRange(PostOrder(node.Left));//自己调用自己
            }
            return list;
        }


        static BinaryNode CreateTree()
        {
            return new BinaryNode()
            {
                Content = "A",
                Left = new BinaryNode()
                {
                    Content = "B",
                    Left = new BinaryNode()
                    {
                        Content = "D"
                    },
                    Right = new BinaryNode()
                    {
                        Content = "E"
                    }
                },
                Right = new BinaryNode()
                {
                    Content = "C",
                    Left = new BinaryNode()
                    {
                        Content = "F"
                    },
                    Right = new BinaryNode()
                    {
                        Content = "G"
                    }
                }
            };
        }
    }
}
