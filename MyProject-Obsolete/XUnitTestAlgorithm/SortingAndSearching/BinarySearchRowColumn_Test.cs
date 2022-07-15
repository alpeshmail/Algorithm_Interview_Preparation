using System;
using System.Collections.Generic;
using System.Text;
using Algorithm.SortingAndSearching;
using Xunit;

namespace XUnitTestAlgorithm.SortingAndSearching
{
    public class BinarySearchRowColumn_Test
    {
        [Fact]
        public void BinarySearchRowColumn_Test1()
        {
            int[,] mat = { { 10, 20, 30, 40 },
                   { 15, 25, 35, 45 },
                   { 27, 29, 37, 48 },
                   { 32, 33, 39, 50 } };
            int keyValue = 29;
            int[] expectedRow = { 2, 1 };
            BinarySearchRowColumn binarySearch = new BinarySearchRowColumn();
            var acutalResult = binarySearch.GetElement(mat, keyValue);
            //Assert.Equal(expectedResult, acutalResult);
            Console.WriteLine(acutalResult);
            for (int i = 0; i < acutalResult.Length; i++)
                Assert.Equal(acutalResult[i], expectedRow[i]);
        }

     

        [Fact]
        public void BinarySearchRowColumn_Test2()
        {
            int[,] mat = 
                { {35,45,55,65},
                  {40,50,60,70},
                  {52,54,62,73},
                  {57,58,64,75} }; 
            
            int keyValue = 73;
            int[] expectedRow = { 2, 3 };
            BinarySearchRowColumn binarySearch = new BinarySearchRowColumn();
            int[] acutalResult = binarySearch.GetElement(mat, keyValue);
            //Assert.Equal(expectedResult, acutalResult);
            for(int i=0;i < acutalResult.Length; i++)
                Assert.Equal(acutalResult[i], expectedRow[i]);
            
        }



        [Fact]
        public void BinarySearchRowColumn_Test3()
        {
            int[,] mat =
                { {35,45,55,65},
                  {40,50,60,70},
                  {52,54,62,73},
                  {57,58,64,75} };

            int keyValue = 57;
            int[] expectedRow = { 3, 0 };
            BinarySearchRowColumn binarySearch = new BinarySearchRowColumn();
            int[] acutalResult = binarySearch.GetElement(mat, keyValue);
            //Assert.Equal(expectedResult, acutalResult);
            for (int i = 0; i < acutalResult.Length; i++)
                Assert.Equal(acutalResult[i], expectedRow[i]);

        }

        [Fact]
        public void BinarySearchRowColumn_Test4()
        {
            int[,] mat =
                { {10, 20, 30, 40},
                    {15, 25, 35, 45},
                    {27, 29, 37, 48},
                    {32, 33, 39, 50}}; ;

            int keyValue = 100;
            int[] expectedRow = { -1, -1 };
            BinarySearchRowColumn binarySearch = new BinarySearchRowColumn();
            var acutalResult = binarySearch.GetElement(mat, keyValue);
            //Assert.Equal(expectedResult, acutalResult);
            Console.WriteLine(acutalResult);
            for (int i = 0; i < acutalResult.Length; i++)
                Assert.Equal(acutalResult[i], expectedRow[i]);

        }

        [Fact]
        public void BinarySearchRowColumn_Test5()
        {
            int[,] mat =
                { {35,45,55,65},
                  {40,50,60,70},
                  {52,54,62,73},
                  {57,58,64,75} };

            int keyValue = 75;
            int[] expectedRow = { 3, 3 };
            BinarySearchRowColumn binarySearch = new BinarySearchRowColumn();
            int[] acutalResult = binarySearch.GetElement(mat, keyValue);
            //Assert.Equal(expectedResult, acutalResult);
            for (int i = 0; i < acutalResult.Length; i++)
                Assert.Equal(acutalResult[i], expectedRow[i]);
        }

    }
 }
