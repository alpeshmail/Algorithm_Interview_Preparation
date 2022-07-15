using Algorithm.Distance;
using Algorithm.LinkedList;
using System;
using Xunit;
namespace XUnitTestAlgorithm.LinkedList
{
    public class SingleLinkedList_Test
    {
        [Fact]
        public void SingleLinkedList_InsertNode()
        {
            SortedLinkedList singleLinkedList = CreateLinkedList();
            singleLinkedList.SortAndInsert(9);
            var result= singleLinkedList.PrintLinkedList();
            //var result = SingleLinkedList.PrintRecursiveLinkedList();
            Console.WriteLine(result);
        }

        [Fact]
        public void SingleLinkedList_DeleteNode()
        {
            SortedLinkedList singleLinkedList = CreateLinkedList();
            singleLinkedList.DeleteNode(6);
            var result = singleLinkedList.PrintLinkedList();
            //var result = SingleLinkedList.PrintRecursiveLinkedList();
            Console.WriteLine(result);
        }


        private SortedLinkedList CreateLinkedList()
        {
            SortedLinkedList singleLinkedList = new SortedLinkedList();
            singleLinkedList.SortAndInsert(5);
            singleLinkedList.SortAndInsert(2);
            singleLinkedList.SortAndInsert(3);
            singleLinkedList.SortAndInsert(6);
            singleLinkedList.SortAndInsert(10);
            singleLinkedList.SortAndInsert(15);
            singleLinkedList.SortAndInsert(1);
            return singleLinkedList;
        }
    }
}
