using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Algorithm.LinkedList;

namespace XUnitTestAlgorithm.LinkedList
{
    public class AddTwoNumbers_Test
    {
        [Fact]
        public void SumOnLinkList()
        {
            int value1 = 563, value2 = 842;
            var expectedResult = value1 + value2;
            AddTwoNumbers addTwoNumbers = new AddTwoNumbers();
            var acutualResult = addTwoNumbers.DoSum(value1, value2);
            Console.WriteLine(acutualResult);
            Assert.Equal(expectedResult, acutualResult);
        }

        [Fact]
        public void SumOnLinkList_2()
        {
            int value1 = 999, value2 = 18;
            var expectedResult = value1 + value2;
            AddTwoNumbers addTwoNumbers = new AddTwoNumbers();
            var acutualResult = addTwoNumbers.DoSum(999, 18);
            Console.WriteLine(acutualResult);
            Assert.Equal(expectedResult, acutualResult);
        }
    }
}
