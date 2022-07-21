using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Algorithm.Heap;

namespace XUnitTestAlgorithm.Heap
{
    public class KClosestPointsToOrigin_Test
    {
        [Fact]
        public void KClosestPointsToOrigin_Test1()
        {

            int K = 2;
            int[,] arr = { { 3, 3 }, { 5, -1 }, { -2, 4 } };
            int[,] expectedResult = { { 3, 3 }, { -2, 4 } };

            KClosestPointsToOrigin kClosestPointsToOrigin = new();
            var result = kClosestPointsToOrigin.GetClosesPoints(arr, K);

            int n = expectedResult.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                Assert.Equal(expectedResult[i,0], result[i,0]);
                Assert.Equal(expectedResult[i, 1], result[i, 1]);
            }
        }

        [Fact]
        public void KClosestPointsToOrigin_Test2()
        {

            int K = 3;
            int[,] arr = { { 1, 0 }, { 2, 1 }, { 3, 6 }, { -5, 2 }, { 1, -4 } } ;
            int[,] expectedResult = { { 1, 0 }, { 2, 1 }, { 1, -4 } };

            KClosestPointsToOrigin kClosestPointsToOrigin = new();
            var result = kClosestPointsToOrigin.GetClosesPoints(arr, K);

            int n = expectedResult.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                Assert.Equal(expectedResult[i, 0], result[i, 0]);
                Assert.Equal(expectedResult[i, 1], result[i, 1]);
            }
        }
    }
}
