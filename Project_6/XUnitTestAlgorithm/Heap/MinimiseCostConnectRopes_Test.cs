using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.Heap;
using Xunit;

namespace XUnitTestAlgorithm.Heap
{
    public class MinimiseCostConnectRopes_Test
    {
        [Fact]
        public void MinimiseCostConnectRopes_Test1()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int expectedResult = 33;
            MinimiseCostConnectRopes minimiseCostConnectRopes = new();
            int result = minimiseCostConnectRopes.GetMinCostUsedPriorityQueue(arr, arr.Length);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void MinimiseCostConnectRopes_Test2()
        {
            int[] arr = { 4, 3, 2, 6 };
            int expectedResult = 29;
            MinimiseCostConnectRopes minimiseCostConnectRopes = new();
            int result = minimiseCostConnectRopes.GetMinCostUsedPriorityQueue(arr, arr.Length);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void AmazonMediaEncoder_Test1()
        {
            int[] files = { 4, 8, 6, 12 };
            int numOfSubfiles = 4;
            int expectedResult = 58;
            MinimiseCostConnectRopes minimiseCostConnectRopes = new();
            int result = minimiseCostConnectRopes.GetMinCostUsedPriorityQueue(files, numOfSubfiles);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void MinimiseCostConnectRopes_MinHeap_Test1()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int expectedResult = 33;
            MinimiseCostConnectRopes minimiseCostConnectRopes = new();
            int result = minimiseCostConnectRopes.GetMinCostUseMinHeap(arr, arr.Length);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void MinimiseCostConnectRopes_minHeap_Test2()
        {
            int[] arr = { 4, 3, 2, 6 };
            int expectedResult = 29;
            MinimiseCostConnectRopes minimiseCostConnectRopes = new();
            int result = minimiseCostConnectRopes.GetMinCostUseMinHeap(arr, arr.Length);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void AmazonMediaEncoder_MinHeap_Test1()
        {
            int[] files = { 4, 8, 6, 12 };
            int numOfSubfiles = 4;
            int expectedResult = 58;
            MinimiseCostConnectRopes minimiseCostConnectRopes = new();
            int result = minimiseCostConnectRopes.GetMinCostUseMinHeap(files, numOfSubfiles);

            Assert.Equal(expectedResult, result);
        }
    }
}
