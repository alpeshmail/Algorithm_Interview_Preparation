using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Algorithm.DynamicProgramming;

namespace XUnitTestAlgorithm.DynamicProgramming
{
    public class LongestCommonSubsequence_Test
    {
        /// <summary>
        /// //LCS for input Sequences “ABCDGH” and “AEDFHR” is “ADH” of length 3. 
        /// </summary>
        [Fact]
        public void LongestCommonSubsequence()
        {
            var expectedResult = "ADH";
            LongestCommonSubsequence longestCommonSubsequence = new LongestCommonSubsequence("ABCDGH","AEDFHR");
            var actualResult= longestCommonSubsequence.GetResult();
            Console.WriteLine(actualResult);
            Console.WriteLine(actualResult.Length);
            Assert.Equal(expectedResult.Length, actualResult.Length);
            Assert.Equal(expectedResult, actualResult);
        }

        /// <summary>
        /// LCS for input Sequences “AGGTAB” and “GXTXAYB” is “GTAB” of length 4. 
        /// </summary>
        [Fact]
        public void LongestCommonSubsequence_2()
        {
            var expectedResult = "GTAB";
            LongestCommonSubsequence longestCommonSubsequence = new LongestCommonSubsequence("AGGTAB", "GXTXAYB");
            var actualResult = longestCommonSubsequence.GetResult();
            Console.WriteLine(actualResult);
            Console.WriteLine(actualResult.Length);
            Assert.Equal(expectedResult.Length, actualResult.Length);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
