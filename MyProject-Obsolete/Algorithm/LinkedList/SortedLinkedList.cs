using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.LinkedList
{/// <summary>
/// Given a linked list which is sorted, how will you insert in sorted way
/// Exiting Link list - 2 => 5 => 7 => 10 => 15
/// add new node in 9 between 7 and 10 so link list will keep sorted
/// </summary>
    public class SortedLinkedList
    {
        private LinkedListNode LinkedListNode;

        public void SortAndInsert(int value)
        {
            if (LinkedListNode == null)
            {
                LinkedListNode = new LinkedListNode(value);
                return;
            }
            else if (LinkedListNode.Value > value)
            {
                var newNode = new LinkedListNode(value);
                newNode.Next = LinkedListNode;
                LinkedListNode = newNode;
            }
            else
            {
                var node = LinkedListNode;
                var newNode= new LinkedListNode(value);
                do
                {
                    if (node.Next == null){
                        node.Next = newNode;
                        return;
                    }
                    else if (node.Next.Value >= newNode.Value && node.Value <= newNode.Value)
                    {
                        newNode.Next = node.Next;
                        node.Next = newNode;
                        return;
                    }
                    node = node.Next;
                } while (node != null);
            }
        }

        public void DeleteNode(int value)
        {
            DeleteNodeFromLinkedList(value);
            GC.Collect();
        }

        public void DeleteNodeFromLinkedList(int value)
        {
            var node = LinkedListNode;
            if (value == LinkedListNode.Value)
            {
                LinkedListNode = node.Next;
                node.Next = null;
                return;
            }
            while(node.Next != null)
            {
                if (node.Next.Value == value)
                {
                    var currentNode = node.Next;
                    var nextNode = currentNode.Next;
                    node.Next = nextNode;
                    currentNode.Next = null;
                    return;
                }
                node = node.Next;
            }
        }

        public string PrintLinkedList()
        {
            StringBuilder sb = new StringBuilder();
            var node = LinkedListNode;
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
            string strLinkedList = GetRecursiveList(LinkedListNode);
            Console.WriteLine(strLinkedList);
            return strLinkedList;
        }

        private string GetRecursiveList(LinkedListNode node)
        {
            if (node.Next != null)
            {
                var result =  GetRecursiveList(node.Next);
                //return string.Format("{0} => {1}", result, node.ToString());
                return string.Format("{0} => {1}",  node.ToString(), result);
            }
            return node.ToString();
        }
    }
}
