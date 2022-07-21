using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Algorithm.Heap;

namespace XUnitTestAlgorithm.Heap
{
    public class KClosestNumbers_Test
    {
        [Fact]
        public void KClosestNumbers_Test1()
        {

            int K = 4, X = 35;
            int[] arr = { 12, 16, 22, 30, 35, 39, 42, 45, 48, 50, 53, 55, 56 };
            int[] expectedResult = { 30, 39, 42, 45 };

            KClosestNumbers kClosestNumbers = new KClosestNumbers();
            var result = kClosestNumbers.GetElementsExcludeKey(arr, K, X);

            Array.Sort(result);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }




        [Fact]
        public void KClosestNumbers_Test2()
        {

            int K = 2, X = 20;
            int[] arr = { -10, -50, 20, 17, 80 };
            int[] expectedResult = { 17, 20 };

            KClosestNumbers kClosestNumbers = new KClosestNumbers();
            var result = kClosestNumbers.GetElements(arr, K, X);

            Array.Sort(result);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }


        [Fact]
        public void KClosestNumbers_Test3()
        {
            //https://www.techiedelight.com/find-k-closest-elements-to-given-value-array/
            int K = 2, X = 8;
            int[] arr = { 2, 3,  5, 4, 6, 7 };
            int[] expectedResult = { 6, 7 };

            KClosestNumbers kClosestNumbers = new KClosestNumbers();
            var result = kClosestNumbers.GetElements(arr, K, X);

            Array.Sort(result);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void KClosestNumbers_Test4()
        {

            int K = 3, X = 5;
            int[] arr = { 10, 2, 14, 4, 7, 6 };
            int[] expectedResult = { 4, 6, 7 };

            KClosestNumbers kClosestNumbers = new KClosestNumbers();
            var result = kClosestNumbers.GetElements(arr, K, X);

            Array.Sort(result);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void KClosestNumbers_Test5()
        {
            int K = 4, X = 16;
            int[] arr = { 12, 10, 17, 15, 18, 21, 25 };
            int[] expectedResult = { 12, 15, 17, 18 };

            KClosestNumbers kClosestNumbers = new KClosestNumbers();
            var result = kClosestNumbers.GetElements(arr, K, X);

            Array.Sort(result);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void KClosestNumbers_PriorityQueue_Test2()
        {

            int K = 2, X = 20;
            int[] arr = { -10, -50, 20, 17, 80 };
            int[] expectedResult = { 17, 20 };

            KClosestNumbers kClosestNumbers = new KClosestNumbers();
            var result = kClosestNumbers.GetElementsPriorityQueue(arr, K, X);

            Array.Sort(result);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }


        [Fact]
        public void KClosestNumbers_PriorityQueue_Test3()
        {
            //https://www.techiedelight.com/find-k-closest-elements-to-given-value-array/
            int K = 2, X = 8;
            int[] arr = { 2, 3, 5, 4, 6, 7 };
            int[] expectedResult = { 6, 7 };

            KClosestNumbers kClosestNumbers = new KClosestNumbers();
            var result = kClosestNumbers.GetElementsPriorityQueue(arr, K, X);

            Array.Sort(result);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void KClosestNumbers_PriorityQueue_Test4()
        {

            int K = 3, X = 5;
            int[] arr = { 10, 2, 14, 4, 7, 6 };
            int[] expectedResult = { 4, 6, 7 };

            KClosestNumbers kClosestNumbers = new KClosestNumbers();
            var result = kClosestNumbers.GetElementsPriorityQueue(arr, K, X);

            Array.Sort(result);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void KClosestNumbers_PriorityQueue_Test5()
        {
            int K = 4, X = 16;
            int[] arr = { 12, 10, 17, 15, 18, 21, 25 };
            int[] expectedResult = { 12, 15, 17, 18 };

            KClosestNumbers kClosestNumbers = new KClosestNumbers();
            var result = kClosestNumbers.GetElementsPriorityQueue(arr, K, X);

            Array.Sort(result);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}
