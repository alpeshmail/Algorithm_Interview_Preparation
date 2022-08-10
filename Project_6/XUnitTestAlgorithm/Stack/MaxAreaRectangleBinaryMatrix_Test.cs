using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.Stack;
using Xunit;


namespace XUnitTestAlgorithm.Stack
{
    public class MaxAreaRectangleBinaryMatrix_Test
    {
        [Fact]
        public void MaxAreaRectangleBinaryMatrix_Test1()
        {
            /*https://www.geeksforgeeks.org/maximum-size-rectangle-binary-sub-matrix-1s/
            
            Input:
            0 1 1 0
            1 1 1 1
            1 1 1 1
            1 1 0 0
            Output :
            8
            Explanation : 
            The largest rectangle with only 1's is from 
            (1, 0) to (2, 3) which is
            1 1 1 1
            1 1 1 1 

             */
            int[,] binaryMat  = {  { 0, 1, 1, 0 },
                                    { 1, 1, 1, 1 },
                                    { 1, 1, 1, 1 },
                                    { 1, 1, 0, 0 } 
                                };

            int result = 8;

            MaxAreaRectangleBinaryMatrix maxAreaRectangleBinaryMatrix = new MaxAreaRectangleBinaryMatrix();
            var actualResult= maxAreaRectangleBinaryMatrix.GetMaxRectangleArea(binaryMat);

            Assert.Equal(result, actualResult);

        }

        [Fact]
        public void MaxAreaRectangleBinaryMatrix_Test2()
        {
            /*
            https://www.interviewbit.com/problems/max-rectangle-in-binary-matrix/
            
            Example :

            A : [  1 1 1
                   0 1 1
                   1 0 0 
                ]

            Output : 4 

            As the max area rectangle is created by the 2x2 rectangle created by (0,1), (0,2), (1,1) and (1,2)

             */
            int[,] binaryMat = {  { 1, 1 , 1},
                                    { 0 ,1 ,1 },
                                    { 1, 0, 0  },
                                };

            int result = 4;

            MaxAreaRectangleBinaryMatrix maxAreaRectangleBinaryMatrix = new MaxAreaRectangleBinaryMatrix();
            var actualResult = maxAreaRectangleBinaryMatrix.GetMaxRectangleArea(binaryMat);

            Assert.Equal(result, actualResult);

        }

        [Fact]
        public void MaxAreaRectangleBinaryMatrix_Test3()
        {
            /*
            https://www.geeksforgeeks.org/maximum-size-rectangle-binary-sub-matrix-1s/

            Input:
            0 1 1
            1 1 1
            0 1 1      
            Output:
            6
            Explanation : 
            The largest rectangle with only 1's is from 
            (0, 1) to (2, 2) which is
            1 1
            1 1
            1 1

             */
            int[,] binaryMat = {  {  0, 1, 1},
                                    {1, 1, 1 },
                                    {0, 1, 1  },
                                };

            int result = 6;

            MaxAreaRectangleBinaryMatrix maxAreaRectangleBinaryMatrix = new MaxAreaRectangleBinaryMatrix();
            var actualResult = maxAreaRectangleBinaryMatrix.GetMaxRectangleArea(binaryMat);

            Assert.Equal(result, actualResult);

        }
        [Fact]
        public void MaxAreaRectangleBinaryMatrix_Test4()
        {
            /*
            https://leetcode.com/problems/maximal-rectangle/

            Input: matrix = [["1","0","1","0","0"],["1","0","1","1","1"],["1","1","1","1","1"],["1","0","0","1","0"]]
            Output: 6
            Explanation: The maximal rectangle is shown in the above picture.


             */
            int[,] binaryMat = {  {1,0,1,0,0}
                                 ,{1,0,1,1,1}
                                 ,{1,1,1,1,1}
                                 ,{1,0,0,1,0}
                                };

            int result = 6;

            MaxAreaRectangleBinaryMatrix maxAreaRectangleBinaryMatrix = new MaxAreaRectangleBinaryMatrix();
            var actualResult = maxAreaRectangleBinaryMatrix.GetMaxRectangleArea(binaryMat);

            Assert.Equal(result, actualResult);

        }

        [Fact]
        public void MaxAreaRectangleBinaryMatrix_Test5()
        {
            /*
            https://leetcode.com/problems/maximal-rectangle/

            Input: matrix = [["0"]]
            Output: 0
             */
            int[,] binaryMat = { {0} };

            int result = 0;

            MaxAreaRectangleBinaryMatrix maxAreaRectangleBinaryMatrix = new MaxAreaRectangleBinaryMatrix();
            var actualResult = maxAreaRectangleBinaryMatrix.GetMaxRectangleArea(binaryMat);

            Assert.Equal(result, actualResult);

        }

        [Fact]
        public void MaxAreaRectangleBinaryMatrix_Test6()
        {
            /*
            https://leetcode.com/problems/maximal-rectangle/

            Input: matrix = [["1"]]
            Output: 1


             */
            int[,] binaryMat = { { 1 } };

            int result = 1;

            MaxAreaRectangleBinaryMatrix maxAreaRectangleBinaryMatrix = new MaxAreaRectangleBinaryMatrix();
            var actualResult = maxAreaRectangleBinaryMatrix.GetMaxRectangleArea(binaryMat);

            Assert.Equal(result, actualResult);

        }
    }
}
