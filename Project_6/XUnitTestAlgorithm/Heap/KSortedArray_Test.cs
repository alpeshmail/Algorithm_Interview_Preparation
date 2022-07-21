using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.Heap;
using Xunit;

namespace XUnitTestAlgorithm.Heap
{
    public class KSortedArray_Test
    {
        [Fact]
        public void KSortedArray_Test1()
        {
            int[] arr = { 6, 5, 3, 2, 8, 10, 9 };
            int k = 3;
            int[] expectedResult = { 2, 3, 5, 6, 8, 9, 10 };
            KSortedArray kSortedArray = new KSortedArray();
            var result = kSortedArray.DoSort(arr, k);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}
