using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.LinkedList
{
    public class CreateLinkList
    {
        public static LinkedListNode GetLinkedList(int[] intArray)
        {
            if (intArray == null || intArray.Length == 0)
                return null;
            var headNode = new LinkedListNode(intArray[0]);
            var node = headNode;
            for (int i = 1; i < intArray.Length; i++)
            {
                var NextNode = new LinkedListNode(intArray[i]);
                node.Next = NextNode;
                node = NextNode;
            }
            return headNode;
        }
        public static LinkedListNode GetLinkedList(string strA)
        {
            return GetLinkedList(strA, out _);
        }

        public static LinkedListNode GetIntLinkedList(string strA)
        {
            return GetLinkedList(strA, out _);
        }

        public static LinkedListNode GetLinkedList(string strA,out int length)
        {
            var strCharArray = strA.ToCharArray();
            length = strCharArray.Length;
            var headNode = new LinkedListNode(strCharArray[0]);
            var node = headNode;

            for (int i = 1; i < strCharArray.Length; i++)
            {
                var NextNode = new LinkedListNode(strCharArray[i]);
                node.Next = NextNode;
                node = NextNode;
            }

            return headNode;
        }

        public static LinkedListNode GetIntLinkedList(string strA, out int length)
        {
            var strCharArray = strA.ToCharArray();
            length = strCharArray.Length;
            var headNode = GetNode(strCharArray, 0);
            var node = headNode;

            for (int i = 1; i < strCharArray.Length; i++)
            {
                LinkedListNode NextNode = GetNode(strCharArray, i);
                node.Next = NextNode;
                node = NextNode;
            }

            return headNode;
        }

        private static LinkedListNode GetNode(char[] strCharArray, int i)
        {
            var iValue = Convert.ToInt32(strCharArray[i].ToString());
            var node= new LinkedListNode(iValue);
            return node;
        }
    }
}
