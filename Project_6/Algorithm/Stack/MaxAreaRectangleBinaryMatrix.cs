using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Stack
{
    public class MaxAreaRectangleBinaryMatrix
    {
        public int GetMaxRectangleArea(int[,] binaryMat)
        {
            /*
            Input:
            0 1 1 0
            1 1 1 1
            1 1 1 1
            1 1 0 0
            Output : 8 */

            var row = binaryMat.GetLength(0);
            var col = binaryMat.GetLength(1);
            int[] mergedArray = new int[col];

            Histogram histogram = new();
            int maxAreaOfRectangle = 0;

            for (int i = 0; i < col; i++)
                mergedArray[i] = 0;

            for (int i=0;i< row; i++)
            {
                for (int j = 0; j < col; j++)
                    mergedArray[j] = binaryMat[i, j] == 0 ? 0: mergedArray[j]  + binaryMat[i,j] ;
                int area = histogram.GetMaximumArea(mergedArray);
                maxAreaOfRectangle = Math.Max(maxAreaOfRectangle, area);
            }
            return maxAreaOfRectangle;
        }
    }
}
