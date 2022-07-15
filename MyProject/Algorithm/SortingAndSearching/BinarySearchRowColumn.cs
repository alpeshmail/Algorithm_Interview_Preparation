using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.SortingAndSearching
{
    public class BinarySearchRowColumn
    {

        public int[] GetElement(int[,] mat, int key)
        {
            int[] result = { -1,-1 };

            int n= mat.GetLength(0);
            int i = 0;int j = mat.GetLength(0) -1 ;

            while(i < n && j > -1)
            {
                if (mat[i, j] ==  key)
                {
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
                else if (mat[i, j] > key)
                {
                    j -= 1;
                }
                else {
                    //moving row
                    i += 1;
                }

                if (i > n - 1)
                    break;
                if (j == -1)
                    break;
            }



        //    int[,] matrix = {
        //        {35,45,55,65},
        //        {40,50,60,70},
        //        {52,54,62,73},
        //        {57,58,64,75}
        //};


            return result;
        }

    }
}
