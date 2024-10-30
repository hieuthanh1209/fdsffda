using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class IntLinkedList
    {
        private IntNode first;
        private IntNode last;
        private int count;

        public IntLinkedList()
        {
            first = null;
            last = null;
        }

        public int Count { get => CountNode(); }
        internal IntNode First { get => first; set => first = value; }
        internal IntNode Last { get => last; set => last = value; }

        public int CountNode()
        {
            IntNode node = First;
            count = 1;
            while (node.Next != null)
            {
                node = node.Next;
                count++;
            }
            return count;
        }

        private bool IsEmpty()
        {
            return first == null;
        }

        public void AddFist(IntNode node)
        {
            if (IsEmpty())
            {
                first = node;
                last = node;
            }
            else
            {
                node.Next = first;
                first = node;
            }
        }

        public void AddLast(IntNode node)
        {
            if (IsEmpty())
            {
                first = node;
                last = node;
            }
            else
            {
                last.Next = node;
                last = node;
            }
        }

        public void ShowList()
        {
            if (!IsEmpty())
            {
                for (IntNode p = first; p != null; p = p.Next)
                {
                    Console.Write(p.Data + "->");
                }
                Console.WriteLine("null");
            }
        }

        public void Input()
        {
            Console.Write("Nhap so luong node: ");
            int soNode = int.Parse(Console.ReadLine());
            for (int i = 0; i < soNode; i++)
            {
                Console.Write("Nhap data cho node: ");
                int data = int.Parse(Console.ReadLine());
                IntNode node = new IntNode(data);
                AddFist(node);
            }
        }

        public IntNode TimMax()
        {
            IntNode maxNode = first;
            IntNode p = first.Next;
            while (p != null)
            {
                if (p.Data > maxNode.Data)
                {
                    maxNode = p;
                }
                p = p.Next;
            }
            return maxNode;
        }

        public IntNode TimX(int x)
        {
            IntNode p = first;
            while (p != null)
            {
                if (p.Data == x)
                {
                    return p;
                }
                p = p.Next;
            }
            return null;
        }
    }
}
