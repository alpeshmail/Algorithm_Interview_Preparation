using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.Stack;
using Xunit;

namespace XUnitTestAlgorithm.Stack
{
    public class ExtendedStack_Test
    {
        [Fact]
        public void ExtendedStack_Test1()
        {
            int result;
            ExtendedStack s = new ExtendedStack();
            s.Push(3);
            s.Push(5);
            result = s.GetMinElement();
            Assert.Equal(3, result);
            s.Push(11);
            result = s.GetMaxElement();
            Assert.Equal(11, result);
            s.Pop();
            result = s.GetMaxElement();
            Assert.Equal(5, result);
            result = s.GetMaxElement();
            s.Push(2);
            s.Push(1);
            result = s.GetMinElement();
            Assert.Equal(1, result);
            s.Pop();
            result = s.GetMinElement();
            Assert.Equal(2, result);
            s.Pop();
            s.Peek();
        }
    }
}
