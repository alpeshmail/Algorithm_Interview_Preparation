using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Algorithm.DynamicProgramming.Knapsack;

namespace XUnitTestAlgorithm.DynamicProgramming.Knapsack
{

    public class Knapsack_0_1_Test
    {
        [Fact]
        public void Knapsack_0_1_Test_1()
        {
            int[] val = new int[] { 60, 100, 120 };
            int[] wt = new int[] { 10, 20, 30 };
            int w = 50;
            int expectedResult = 220;

            Knapsack_0_1 Knapsack_0_1 = new Knapsack_0_1();
            var acutalResult = Knapsack_0_1.Knapsack_0_1_Rec(val, wt, w);
            Console.WriteLine(acutalResult);
            Assert.Equal(expectedResult,acutalResult);
        }

      

        [Fact]
        public void Knapsack_0_1_Test_2()
        {
            int[] val = new int[] { 60, 100, 120 };
            int[] wt = new int[] { 2, 4, 5 };
            int w = 9;
            int expectedResult = 220;

            Knapsack_0_1 Knapsack_0_1 = new Knapsack_0_1();
            var acutalResult = Knapsack_0_1.Knapsack_DP_Matrix(val, wt, w);
            Console.WriteLine(acutalResult);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void Knapsack_0_1_Test_5()
        {
            int[] val = new int[] { 60, 100, 120 };
            int[] wt = new int[] { 10, 20, 30 };
            int w = 50;
            int expectedResult = 220;

            Knapsack_0_1 Knapsack_0_1 = new Knapsack_0_1();
            var acutalResult = Knapsack_0_1.Knapsack_DP_Matrix(val, wt, w);
            Console.WriteLine(acutalResult);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void Knapsack_0_1_Test_3()
        {
            int[] val = new int[] { 60, 100, 120 };
            int[] wt = new int[] { 2, 4, 5 };
            int w = 9;
            int expectedResult = 220;

            //Copy from greek
            Knapsack_0_1 Knapsack_0_1 = new Knapsack_0_1();
            var acutalResult = Knapsack_0_1.knapSack(w,wt, val, wt.Length);
            Console.WriteLine(acutalResult);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void Knapsack_0_1_Test_4()
        {
            int[] val = new int[] { 60, 100, 120 };
            int[] wt = new int[] { 2, 4, 5 };
            int w = 9;
            int expectedResult = 220;

            Knapsack_0_1 Knapsack_0_1 = new Knapsack_0_1();
            var acutalResult = Knapsack_0_1.Knapsack_DP_Matrix_2(val, wt, w);
            Console.WriteLine(acutalResult);
            Assert.Equal(expectedResult, acutalResult);
        }
    }
}
