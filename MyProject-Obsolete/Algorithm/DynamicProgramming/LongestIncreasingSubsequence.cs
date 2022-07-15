using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithm.DynamicProgramming
{
    /// <summary>
    /// Input: arr[] = {3, 10, 2, 1, 20}
    /// Output: Length of LIS = 3
    /// The longest increasing subsequence is 3, 10, 20
    /// </summary>
    public class LongestIncreasingSubsequence
    {
        public List<LisOutPut> LisValue { get; private set; }

        public int LIS(int[] arr)
        {
            int iMaxLength = 1;
            List<LisOutPut> lstIncreasingSubsequence = new List<LisOutPut>();
            int[] lisArray = new int[arr.Length];
            for (var i = 0; i < lisArray.Length; i++)
                lisArray[i] = 1;

            for(var i = 1; i < arr.Length; i++)
            {
                LisOutPut lisOutPut = new LisOutPut();
                for (var j=0; j < i; j++)
                {
                    if (arr[j] < arr[i] && lisArray[i] < (lisArray[j] + 1))
                    {
                        lisArray[i] = lisArray[j] + 1;
                        if (lisArray[i] > iMaxLength)
                            iMaxLength = lisArray[i];
                        lisOutPut.Add(arr[j]);
                    }

                    //Simple Logic
                    //if (arr[j] < arr[i])
                    //{
                    //    var maxValue = Math.Max(lisArray[i], lisArray[j] + 1);
                    //    lisArray[i] = maxValue;
                    //}
                }
                lisOutPut.Add(arr[i]);
                lstIncreasingSubsequence.Add(lisOutPut);
            }

            LisValue = lstIncreasingSubsequence.Where(w => w.Length == iMaxLength).ToList();

            return iMaxLength;
        }

    }

    public class LisOutPut
    {
        public int Length { get { return Subsequence.Count; } }
        public List<int> Subsequence { get; private set; }

        public LisOutPut()
        {
            Subsequence = new List<int>();
        }

        public void Add(int value)
        {
            Subsequence.Add(value);
        }
    }
}
