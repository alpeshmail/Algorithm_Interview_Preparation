using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.Heap;
using Xunit;

namespace XUnitTestAlgorithm.Heap
{
    public class MaxHeap_Test
    {
        [Fact]
        public void MaxHeap_Test1()
        {
            //12, 3, 5, 7, 19 
            MaxHeap maxHeap = new MaxHeap(5);
            maxHeap.Add(3);
            maxHeap.Add(5);
            maxHeap.Add(7);
            maxHeap.Add(19);
            maxHeap.Add(12);
            Console.WriteLine("test");

        }
    }
}
