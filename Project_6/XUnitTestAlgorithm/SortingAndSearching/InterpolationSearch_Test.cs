using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.SortingAndSearching;
using Xunit;

namespace XUnitTestAlgorithm.SortingAndSearching
{
    public class InterpolationSearch_Test
    {
        [Fact]
        public void InterpolationSearch_Test1()
        {
            int[] arr = { 10, 12, 13, 16, 18, 19, 20, 21,
                      22, 23, 24, 33, 35, 42, 47 };
            int X = 18;

            InterpolationSearch interpolationSearch = new InterpolationSearch();
            var result = interpolationSearch.Search(arr,X);
            Assert.Equal(4,result);

        }

        [Fact]
        public void InterpolationSearch_Test2()
        {
            int[] arr = { 10, 12, 13, 16, 18, 19, 20, 21,
                      22, 23, 24, 33, 35, 42, 47 };
            int X = 42;

            InterpolationSearch interpolationSearch = new InterpolationSearch();
            var result = interpolationSearch.Search(arr, X);
            Assert.Equal(13, result);

        }
    }
}
