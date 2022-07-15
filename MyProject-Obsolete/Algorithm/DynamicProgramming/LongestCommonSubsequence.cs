using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.DynamicProgramming
{
    /// <summary>
    /// https://www.geeksforgeeks.org/longest-common-subsequence-dp-4/
    /// https://www.youtube.com/watch?v=sSno9rV8Rhg
    /// Examples: 
    /// LCS for input Sequences “ABCDGH” and “AEDFHR” is “ADH” of length 3. 
    /// LCS for input Sequences “AGGTAB” and “GXTXAYB” is “GTAB” of length 4. 
    /// Time Complexity of the above implementation is O(mn) 
    /// </summary>
    public class LongestCommonSubsequence
    {
        public string str1 { get; private set; }
        public string str2 { get; private set; }

        public LongestCommonSubsequence(string _str1, string _str2)
        {
            str1 = _str1;
            str2 = _str2;
        }

        public string GetResult()
        {
            int m = str1.Length;
            int n = str2.Length;
            int[,] lcs = new int[m+1, n+1];

            for(var i = 0; i <= m; i++)
            {
                for(var j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        lcs[i, j] = 0;
                    else if (str1[i-1] == str2[j-1])
                    {
                        lcs[i, j] = 1 + lcs[i-1,j-1];
                    }
                    else if (str1[i-1] != str2[j-1])
                    {
                        lcs[i, j] = Math.Max(lcs[i - 1, j], lcs[i, j - 1]);
                        //lcs[i, j] = Max(lcs[i - 1, j], lcs[i, j - 1]);
                    }
                }
            }

            string result="";
     
            while (m != 0 && n != 0)
            {
                if (lcs[m,n] != lcs[m -1, n - 1])
                {
                    result = str1[m-1] + result;
                }
                m--;
                n--;
            }

            Console.WriteLine(result);
            return result;
        }

        private int Max(int v1, int v2)
        {
            if (v1 > v2)
                return v1;
            else
                return v2;
        }
    }
}
