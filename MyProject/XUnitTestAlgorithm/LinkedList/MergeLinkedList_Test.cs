using Algorithm.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestAlgorithm.LinkedList
{
    public class MergeLinkedList_Test
    {
        [Fact]
        public void MergeLinkList()
        {
            // 5->7->17->13->11 and second is 12->10->2->4->6, 
            //the first list should become 5->12->7->10->17->2->13->4->11->6 and second list should become empty.
            int[] firstValues = { 5,7, 17, 13, 11 };
            int[] secondValues = { 12, 10, 2, 4,6 };

            MergeLinkedList mergeLinkedList = new MergeLinkedList(firstValues, secondValues);
            mergeLinkedList.MergeList();

            var result1 = mergeLinkedList.FirstLinkList.PrintLinkedList();
            Console.WriteLine("FirstLinkedList:" + result1);
            var result2 = mergeLinkedList.SecondLinkList.PrintLinkedList();
            Console.WriteLine("SecondLinkedList:" + result2);
        }

        [Fact]
        public void MergeLinkList_2()
        {
            // For example, if the first list is 1->2->3 and second list is 4->5->6->7->8, 
            // then first list should become 1->4->2->5->3->6 and second list to 7->8.
            
            int[] firstValues = {1,2,3};
            int[] secondValues = { 4,5,6,7,8 };

            MergeLinkedList mergeLinkedList = new MergeLinkedList(firstValues, secondValues);
            mergeLinkedList.MergeList();

            var result1 = mergeLinkedList.FirstLinkList.PrintLinkedList();
            Console.WriteLine("FirstLinkedList:" + result1);
            var result2 = mergeLinkedList.SecondLinkList.PrintLinkedList();
            Console.WriteLine("SecondLinkedList:" + result2);
        }
    }
}
