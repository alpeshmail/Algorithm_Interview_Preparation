using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.LinkedList
{
    public class LinkedListNode
    {
        public int Value { get; set; }
        public char Data;
        public LinkedListNode Next { get; set; }

        public LinkedListNode(int _value)
        {
            Value = _value;
        }

        public LinkedListNode(char _data)
        {
            Data = _data;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public string PrintLinkedList()
        {
            StringBuilder sb = new StringBuilder();
            var node = this;
            string starArrow = " => ";
            do
            {
                sb.AppendFormat("{0} {1}", node.ToString(), starArrow);
                node = node.Next;
            }
            while (node != null);
            if (sb.Length > 0)
                sb.Length = sb.Length - starArrow.Length;
            return sb.ToString();
        }

        public string PrintRecursiveLinkedList()
        {
            var currentNode = this;
            string strLinkedList = GetRecursiveList(currentNode);
            Console.WriteLine(strLinkedList);
            return strLinkedList;
        }

        private string GetRecursiveList(LinkedListNode node)
        {
            if (node.Next != null)
            {
                var result = GetRecursiveList(node.Next);
                //return string.Format("{0} => {1}", result, node.ToString());
                return string.Format("{0} => {1}", node.ToString(), result);
            }
            return node.ToString();
        }
    }
}
