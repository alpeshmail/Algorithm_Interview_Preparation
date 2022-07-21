using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.Heap;

namespace XUnitTestAlgorithm.Heap
{
    public class LargestElement_Test
    {
        [Fact]
        public void KthLargestElement_Test1()
        {
            int[] arr = { 12, 3, 5, 7, 19 };
            int k = 4;
            LargestElement largest = new LargestElement();
            var result = largest.GetKthLargetElement(arr, k);

            Assert.Equal(5, result);

        }

        [Fact]
        public void KLargestElement_Test1()
        {
            int[] arr = { 12, 3, 5, 7, 19 };
            int k = 4;
            int[] exepctedResult = {  5, 7, 12, 19 };
            LargestElement largest = new LargestElement();
            int[] result = largest.GetKLargetElement(arr, k);

            Array.Sort(result);

            for(int i = 0; i < exepctedResult.Length; i++)
            {
                Assert.Equal(exepctedResult[i], result[i]);
            }
            

        }
    }
}
