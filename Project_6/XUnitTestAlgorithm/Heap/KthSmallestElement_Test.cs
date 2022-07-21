using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.Heap;
using Xunit;

namespace XUnitTestAlgorithm.Heap
{
    public class KthSmallestElement_Test
    {
        [Fact]
        public void KthSmallestElement_Test1()
        {
            int[] arr = { 12, 3, 5, 7, 19 };
            int k = 4;
            KthSmallestElement kthSmallestElement = new KthSmallestElement();
            var result= kthSmallestElement.GetElement(arr, k);

            Assert.Equal(12, result);


        }

        [Fact]
        public void KthSmallestElement_Test2()
        {
            int[] arr = { 12, 3, 5, 7, 4, 19, 26 };
            int k = 3;
            KthSmallestElement kthSmallestElement = new KthSmallestElement();
            var result = kthSmallestElement.GetElement(arr, k);

            Assert.Equal(5, result);


        }

        [Fact]
        public void KthSmallestElement_Test3()
        {
            int[] arr = { 12, 3, 5, 7, 4, 19, 26 };
            int k = 4;
            KthSmallestElement kthSmallestElement = new KthSmallestElement();
            var result = kthSmallestElement.GetElement(arr, k);

            Assert.Equal(7, result);


        }


        [Fact]
        public void KthSmallestElement_Test4()
        {
            int[] arr = { 10, 5, 4, 3, 48, 15, 6, 2, 33, 53, 10 };
            int k = 4;
            KthSmallestElement kthSmallestElement = new KthSmallestElement();
            var result = kthSmallestElement.GetElement(arr, k);

            Assert.Equal(5, result);


        }

        [Fact]
        public void KthSmallestElement_SortedList_Test1()
        {
            int[] arr = { 12, 3, 5, 7, 19 };
            int k = 4;
            KthSmallestElement kthSmallestElement = new KthSmallestElement();
            var result = kthSmallestElement.GetElementUsedSortedList(arr, k);

            Assert.Equal(12, result);


        }

        [Fact]
        public void KthSmallestElement_SortedList_Test2()
        {
            int[] arr = { 12, 3, 5, 7, 4, 19, 26 };
            int k = 3;
            KthSmallestElement kthSmallestElement = new KthSmallestElement();
            var result = kthSmallestElement.GetElementUsedSortedList(arr, k);

            Assert.Equal(5, result);


        }

        [Fact]
        public void KthSmallestElement_SortedList_Test3()
        {
            int[] arr = { 12, 3, 5, 7, 4, 19, 26 };
            int k = 4;
            KthSmallestElement kthSmallestElement = new KthSmallestElement();
            var result = kthSmallestElement.GetElementUsedSortedList(arr, k);

            Assert.Equal(7, result);


        }


        [Fact]
        public void KthSmallestElement_SortedList_Test4()
        {
            int[] arr = { 10, 5, 4, 3, 48, 15, 6, 2, 33, 53, 10 };
            int k = 4;
            KthSmallestElement kthSmallestElement = new KthSmallestElement();
            var result = kthSmallestElement.GetElementUsedSortedList(arr, k);

            Assert.Equal(5, result);


        }

        [Fact]
        public void KthSmallestElement_PriorityQueue_Test1()
        {
            int[] arr = { 12, 3, 5, 7, 19 };
            int k = 4;
            KthSmallestElement kthSmallestElement = new KthSmallestElement();
            var result = kthSmallestElement.GetElementUsedPriorityQueue(arr, k);

            Assert.Equal(12, result);


        }

        [Fact]
        public void KthSmallestElement_PriorityQueue_Test2()
        {
            int[] arr = { 12, 3, 5, 7, 4, 19, 26 };
            int k = 3;
            KthSmallestElement kthSmallestElement = new KthSmallestElement();
            var result = kthSmallestElement.GetElementUsedPriorityQueue(arr, k);

            Assert.Equal(5, result);


        }

        [Fact]
        public void KthSmallestElement_PriorityQueue_Test3()
        {
            int[] arr = { 12, 3, 5, 7, 4, 19, 26 };
            int k = 4;
            KthSmallestElement kthSmallestElement = new KthSmallestElement();
            var result = kthSmallestElement.GetElementUsedPriorityQueue(arr, k);

            Assert.Equal(7, result);


        }


        [Fact]
        public void KthSmallestElement_PriorityQueue_Test4()
        {
            int[] arr = { 10, 5, 4, 3, 48, 15, 6, 2, 33, 53, 10 };
            int k = 4;
            KthSmallestElement kthSmallestElement = new KthSmallestElement();
            var result = kthSmallestElement.GetElementUsedPriorityQueue(arr, k);

            Assert.Equal(5, result);


        }

    }
}
