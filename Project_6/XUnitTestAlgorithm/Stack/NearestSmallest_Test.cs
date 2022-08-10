using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.Stack;
using Xunit;

namespace XUnitTestAlgorithm.Stack
{
    public class NearestSmallest_Test
    {
        [Fact]
        public void NearestSmallest_ToLeft_Test1()
        {
            //Next Grreater Element and NearestGreater To Right are same
            
            int[] nums = { 4,5,2,10,8};
            int[] expectedResult = { -1, 4, -1, 2, 2 };
            NearestSmallest nearest = new NearestSmallest();
            var result = nearest.GetNearestSmallestToLeft(nums);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void NearestSmallest_ToLeft_Test2()
        {
            //Next Grreater Element and NearestGreater To Right are same
            //https://www.procoding.org/nearest-smaller-to-left/
            //https://www.geeksforgeeks.org/find-the-nearest-smaller-numbers-on-left-side-in-an-array/
            int[] nums = { 1, 6, 4, 10, 2, 5 };
            int[] expectedResult = { -1, 1, 1, 4, 1, 2 };
            NearestSmallest nearest = new NearestSmallest();
            var result = nearest.GetNearestSmallestToLeft(nums);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void NearestSmallest_ToLeft_Test3()
        {
            //Next Grreater Element and NearestGreater To Right are same
            //https://www.procoding.org/nearest-smaller-to-left/
            int[] nums = { 1, 3, 0, 2, 5 };
            int[] expectedResult = { -1, 1, -1, 0, 2 };
            NearestSmallest nearest = new NearestSmallest();
            var result = nearest.GetNearestSmallestToLeft(nums);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void NearestSmallest_ToRight_Test1()
        {
            //Next Grreater Element and NearestGreater To Right are same
            //https://www.procoding.org/nearest-smaller-to-right/
            int[] nums = { 4, 5, 2, 0 };
            int[] expectedResult = { 2, 2, 0, -1 };
            NearestSmallest nearest = new NearestSmallest();
            var result = nearest.GetNearestSmallestToRight(nums);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void NearestSmallest_ToRight_Test2()
        {
            //Next Grreater Element and NearestGreater To Right are same
            //https://www.procoding.org/nearest-smaller-to-right/
            int[] nums = { 1, 6, 4, 10, 2, 5 };
            int[] expectedResult = { -1, 4, 2, 2, -1, -1 };
            NearestSmallest nearest = new NearestSmallest();
            var result = nearest.GetNearestSmallestToRight(nums);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void NearestSmallest_ToRight_Test3()
        {
            //Next Grreater Element and NearestGreater To Right are same
            //https://www.geeksforgeeks.org/next-smaller-element/
            int[] nums = { 4, 8, 5, 2, 25 };
            int[] expectedResult = { 2, 5, 2,-1,-1 };
            NearestSmallest nearest = new NearestSmallest();
            var result = nearest.GetNearestSmallestToRight(nums);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void NearestSmallest_ToRight_Test4()
        {
            //Next Grreater Element and NearestGreater To Right are same
            //https://www.geeksforgeeks.org/next-smaller-element/
            int[] nums = { 13, 7, 6, 12 };
            int[] expectedResult = { 7, 6, -1, -1 };
            NearestSmallest nearest = new NearestSmallest();
            var result = nearest.GetNearestSmallestToRight(nums);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}
