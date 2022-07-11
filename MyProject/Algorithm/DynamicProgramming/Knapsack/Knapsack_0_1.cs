using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.DynamicProgramming.Knapsack
{
    public class Knapsack_0_1
    {

        public int Knapsack_0_1_Rec(int[] value,int[] weight,int capacity)
        {
            int length = value.Length;
            var output = KnapsackRec(value, weight, capacity, length);
            Console.WriteLine(output);
            return 0;
        }

        private int KnapsackRec(int[] value, int[] weight, int capacity, int length)
        {
            if (length == 0 || capacity == 0)
                return 0;
            if (weight[length - 1] > capacity)
            {
                int notIncludedItem = KnapsackRec(value, weight, capacity, length - 1);
                return notIncludedItem;
            }
            else
            {
                int includedItem = value[length - 1] + KnapsackRec(value, weight, capacity - weight[length - 1], length  -1);
                int notIncludedItem = KnapsackRec(value, weight, capacity, length - 1); 
                return Math.Max(includedItem, notIncludedItem);
            }
        }

        public int Knapsack_DP_Matrix(int[] value, int[] weight, int capacity)
        {
            int n = weight.Length;
            int[,] kdp = new int[n + 1, capacity + 1];

            for(int i=0;i <= n; i++)
            {
                Console.WriteLine(i);
                for(int j=0;j <= capacity; j++)
                {
                    if (j == 0 || i == 0)
                    {
                        kdp[i, j] = 0;
                    }
                    else if (j < weight[i - 1]  )
                    {
                        kdp[i, j] = kdp[i-1, j];
                    }
                    else
                    {
                        int prevValue =  j - weight[i - 1];
                        int includedValue = value[i - 1] + kdp[i - 1, prevValue];
                        int NotIncludedValue = kdp[i - 1, j];
                        kdp[i, j] = Math.Max(includedValue, NotIncludedValue);
                    }
                }
            }

            return kdp[n,capacity];
        }

        public int Knapsack_DP_Matrix_2(int[] value, int[] weight, int capacity)
        {
            int n = weight.Length;
            int[,] kdp = new int[2, capacity + 1];

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(i);
                for (int j = 0; j <= capacity; j++)
                {
                    if (j == 0 || i == 0)
                    {
                        kdp[0, j] = 0;
                        kdp[1, 0] = 0;
                    }
                    else if (j < weight[i - 1])
                    {
                        kdp[0, j] = kdp[1, j];
                    }
                    else
                    {
                        int prevValue = j - weight[i - 1];
                        int includedValue = value[i - 1] + kdp[0, prevValue];
                        int NotIncludedValue = kdp[0, j];
                        kdp[0, j] = kdp[1, j];// Copied previous value to up matrix
                        kdp[1, j] = Math.Max(includedValue, NotIncludedValue);
                    }
                }
            }

            return kdp[1, capacity];
        }

        /// <summary>
        /// copied version from geeksforgeeks
        /// </summary>
        /// <param name="W"></param>
        /// <param name="wt"></param>
        /// <param name="val"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int knapSack(int W, int[] wt,int[] val, int n)
        {
            int i, w;
            int[,] K = new int[n + 1, W + 1];

            // Build table K[][] in bottom
            // up manner
            for (i = 0; i <= n; i++)
            {
                for (w = 0; w <= W; w++)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;

                    else if (wt[i - 1] <= w)
                        K[i, w] = Math.Max(
                            val[i - 1]
                            + K[i - 1, w - wt[i - 1]],
                            K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            return K[n, W];
        }
    }
}
