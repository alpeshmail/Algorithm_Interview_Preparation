using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Algorithm.Heap;


namespace XUnitTestAlgorithm.Heap
{
    public  class KFrequence_Test
    {
        [Fact]
        public void KFrequenceNumbers_Test1()
        {

            int K = 2;
            int[] arr = { 3, 1, 4, 4, 5, 2, 6, 1 };
            int[] expectedResult = { 1, 4 };

            KFrequence kFrequence = new KFrequence();
            var result = kFrequence.GetElements(arr, K);

            Array.Sort(result);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void KFrequenceNumbers_PriorityQueue_Test1()
        {

            int K = 2;
            int[] arr = { 3, 1, 4, 4, 5, 2, 6, 1 };
            int[] expectedResult = { 1, 4 };

            KFrequence kFrequence = new KFrequence();
            var result = kFrequence.GetElementsPriorityQueue(arr, K);

            Array.Sort(result);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void KFrequenceNumbers_Test2()
        {

            int K = 4;
            int[] arr = { 7, 10, 11, 5, 2, 5, 5, 7, 11, 8, 9 };
            int[] expectedResult = { 5, 11, 7, 10 };

            KFrequence kFrequence = new KFrequence();
            var result = kFrequence.GetElements(arr, K);

            Array.Sort(result);
            Array.Sort(expectedResult);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void KFrequenceNumbers_PriorityQueue_Test2()
        {


            int K = 4;
            int[] arr = { 7, 10, 11, 5, 2, 5, 5, 7, 11, 8, 9 };
            int[] expectedResult = { 5, 11, 7, 10 };

            KFrequence kFrequence = new KFrequence();
            var result = kFrequence.GetElementsPriorityQueue(arr, K);

            Array.Sort(result);
            Array.Sort(expectedResult);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void KFrequence_Sort_Test1()
        {

           
            int[] arr = { 2, 5, 2, 8, 5, 6, 8, 8 };
            int[] expectedResult = { 8, 8, 8, 2, 2, 5, 5, 6 };

            KFrequence kFrequence = new KFrequence();
            var result = kFrequence.GetSortArray(arr);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void KFrequence_Sort_Test2()
        {


            int[] arr = { 2, 5, 2, 6, -1, 9999999, 5, 8, 8, 8 };
            int[] expectedResult = { 8, 8, 8, 2, 2, 5, 5,  6, -1, 9999999 };

            KFrequence kFrequence = new KFrequence();
            var result = kFrequence.GetSortArray(arr);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}
