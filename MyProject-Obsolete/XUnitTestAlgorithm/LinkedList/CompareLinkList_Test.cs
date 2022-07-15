using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Algorithm.LinkedList;

namespace XUnitTestAlgorithm.LinkedList
{
    /// <summary>
    /// Compare two strings represented as linked lists
    /// </summary>
    public class CompareLinkList_Test
    {
        [Fact]
        public void CompareString_linkList()
        {
            string strA = "geeksb";
            string strB = "geeksa";
            var expectedResult = 1;
            LinkedListNode linkedListNodeA1_Head = CreateLinkList.GetLinkedList(strA);
            LinkedListNode linkedListNodeB1_Head = CreateLinkList.GetLinkedList(strB);

            CompareLinkList compareLinkList = new CompareLinkList();
            var actualResult = compareLinkList.Compare(linkedListNodeA1_Head, linkedListNodeB1_Head);
            Console.WriteLine(actualResult);
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void CompareString_linkList_1()
        {
            string strA = "geeksa";
            string strB = "geeksb";
            var expectedResult = -1;
            CompareStringLinkListTest(strA, strB, expectedResult);
        }

        [Fact]
        public void CompareString_linkList_2()
        {
            string strA = "geeksa";
            string strB = "geeks";
            var expectedResult = 1;
            CompareStringLinkListTest(strA, strB, expectedResult);
        }

        [Fact]
        public void CompareString_linkList_3()
        {
            string strA = "geeksa";
            string strB = "geeksa";
            var expectedResult = 0;
            CompareStringLinkListTest(strA, strB, expectedResult);
        }

        private void CompareStringLinkListTest(string strA, string strB, int expectedResult)
        {
            LinkedListNode linkedListNodeA1_Head = CreateLinkList.GetLinkedList(strA);
            LinkedListNode linkedListNodeB1_Head = CreateLinkList.GetLinkedList(strB);

            CompareLinkList compareLinkList = new CompareLinkList();
            var actualResult = compareLinkList.Compare(linkedListNodeA1_Head, linkedListNodeB1_Head);
            Console.WriteLine(actualResult);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
