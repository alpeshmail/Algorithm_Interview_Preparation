using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.LinkedList
{
    /*
     * https://www.geeksforgeeks.org/compare-two-strings-represented-as-linked-lists/
     Examples: 
        Input: list1 = g->e->e->k->s->a
                  list2 = g->e->e->k->s->b
        Output: -1
        Explanation: “geeksb” is lexicographically greater than “geeksa”.

        Input: list1 = g->e->e->k->s->a
                  list2 = g->e->e->k->s
        Output: 1
        Explanation: “geeksa” is greater than “geeks”.

        Input: list1 = g->e->e->k->s
                  list2 = g->e->e->k->s
        Output: 0
        Explanation: Both the strings are “geeks”.
         */
    /// <summary>
    /// Compare two strings represented as linked lists
    /// Given two strings, represented as linked lists (every character is a node in a linked list). 
    /// Write a function compare() that works similar to strcmp(), i.e., 
    /// it returns 0 if both strings are the same, 1 if the first linked list is lexicographically greater, and -1 if the second string is lexicographically greater.
    /// </summary>
    public class CompareLinkList
    {
        public int Compare(LinkedListNode A, LinkedListNode B)
        {

            if (A == null && B == null)
                return 0;
            LinkedListNode node1 = A, node2 = B;
            while(node1 != null && node2 != null && node1.Data == node2.Data)
            {
                node1 = node1.Next;
                node2 = node2.Next;
            }

            if (node1 != null && node2 != null)
            {
                return (node1.Data > node2.Data ? 1 : -1);
            }
            if (node1 != null && node2 == null)
            {
                return 1;
            }
            if (node1 == null && node2 != null)
            {
                return - 1;
            }
            return 0;
        }
    }
}
