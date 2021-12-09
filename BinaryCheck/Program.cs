using System;
using System.Collections.Generic;

namespace BinaryCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            int previous = 0;
            List<int> data = new List<int>();
            IntNode tree = CreateTree();
            BuildList(tree, data);
            foreach (int i in data) {
                if (i < previous) { check = false; }
                previous = i;
            }


            Console.Write("Is this tree a valid binary tree?" + check);
        }

        public static IntNode CreateTree()
        {
            IntNode tree = new IntNode(5);
            tree.left = new IntNode(3);
            tree.left.left = new IntNode(1);
            tree.left.right = new IntNode(8);
            tree.right = new IntNode(9);
            tree.right.left = new IntNode(7);
            tree.right.right = new IntNode(10);
            return tree;
        }

        public static void BuildList(IntNode tree, List<int> data)
        {
            if (tree != null)
            {
                BuildList(tree.left,data);
                data.Add(tree.data);
                // Check to see if it's bigger than previous 
                //Console.Write(tree.data + " ");
                BuildList(tree.right,data);
                
            }
        }

    }

    public class IntNode{

        public int data;
        public IntNode left;
        public IntNode right;
        public IntNode(int value) { data = value; }
        }

}
