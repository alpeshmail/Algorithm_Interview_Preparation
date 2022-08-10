using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.Stack;
using Xunit;

namespace XUnitTestAlgorithm.Stack
{
    public class NearestGreater_Test
    {
        [Fact]
        public void NextGreaterElement_Test1()
        {
            //Next Grreater Element and NearestGreater To Right are same
            //https://www.geeksforgeeks.org/next-greater-element/
            int[] nums = { 1, 3, 2, 4 };
            int[] expectedResult = { 3, 4, 4, -1 };
            NearestGreater nextElement = new NearestGreater();
            var result = nextElement.GetNearestGreaterToRight(nums);
            for(int i=0;i< expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void NextGreaterElement_Test2()
        {
            //Next Grreater Element and NearestGreater To Right are same
            //https://www.geeksforgeeks.org/next-greater-element/
            int[] nums = { 4, 5, 2, 25 };
            int[] expectedResult = { 5, 25, 25, -1 };
            NearestGreater nextElement = new NearestGreater();
            var result = nextElement.GetNearestGreaterToRight(nums);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }


        [Fact]
        public void NextGreaterElement_Test3()
        {
            //Next Grreater Element and NearestGreater To Right are same
            //https://www.geeksforgeeks.org/next-greater-element/
            int[] nums = { 13, 7, 6, 12 };
            int[] expectedResult = { -1, 12, 12, -1 };
            NearestGreater nextElement = new NearestGreater();
            var result = nextElement.GetNearestGreaterToRight(nums);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void NextGreaterElement_Test4()
        {
            //Next Grreater Element and NearestGreater To Right are same
            //https://www.geeksforgeeks.org/next-greater-element/
            int[] nums = { 11, 13, 21, 3 };
            int[] expectedResult = { 13, 21, -1, -1 };
            NearestGreater nextElement = new NearestGreater();
            var result = nextElement.GetNearestGreaterToRight(nums);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void NextGreaterElement_Test5()
        {
            //Next Grreater Element and NearestGreater To Right are same
            //https://www.geeksforgeeks.org/next-greater-element/
            int[] nums = { 6, 8, 0, 1, 3 };
            int[] expectedResult = { 8, -1, 1, 3, -1 };
            NearestGreater nextElement = new NearestGreater();
            var result = nextElement.GetNearestGreaterToRight(nums);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void NearestGreaterToLeft_Element_Test1()
        {
            //Next Grreater Element and NearestGreater To Right are same
            //https://www.callicoder.com/nearest-greater-to-left/
            int[] nums = { 1,3,2,4 };
            int[] expectedResult = { -1, -1, 3, -1 };
            NearestGreater nextElement = new NearestGreater();
            var result = nextElement.GetNearestGreaterToLeft(nums);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void NearestGreaterToLeft_Element_Test2()
        {
            //Next Grreater Element and NearestGreater To Right are same
            //https://www.callicoder.com/nearest-greater-to-left/
            int[] nums = { 9, 4, 15, 6, 2, 10 };
            int[] expectedResult = { -1, 9, -1, 15, 6, 15 };
            NearestGreater nextElement = new NearestGreater();
            var result = nextElement.GetNearestGreaterToLeft(nums);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }


    }
}
