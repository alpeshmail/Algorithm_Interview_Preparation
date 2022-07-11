using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Algorithm.DynamicProgramming;
using System.Linq;

namespace XUnitTestAlgorithm.DynamicProgramming
{
    public class EditDistance_Test
    {
        [Fact]
        public void EditDistance_1()
        {
            string str1 = "cat", str2 = "cut";
            //We can convert str1 into str2 by replacing 'a' with 'u'.
            int exptectResult = 1;
            TestOnlyLength(str1, str2, exptectResult);
        }

        [Fact]
        public void EditDistance_2()
        {
            string str1 = "sunday", str2 = "saturday";
            // we want to convert sunday to saturday
            // Last three and first characters are same.  We basically   
            // need to convert "un" to "atur".This can be done using  below three operations.
            // Replace 'n' with 'r', insert t, insert a

            List<EDMatrixVertexResult> exptectedResultList = new List<EDMatrixVertexResult>
            {
                new EDMatrixVertexResult() { EditDistanceActionType = EditDistanceActionType.Copy, OldChar = 's', NewChar = 's' },
                new EDMatrixVertexResult() { EditDistanceActionType = EditDistanceActionType.Insert, NewChar = 'a' },
                new EDMatrixVertexResult() { EditDistanceActionType = EditDistanceActionType.Insert, NewChar = 't' },
                new EDMatrixVertexResult() { EditDistanceActionType = EditDistanceActionType.Copy, OldChar = 'u', NewChar = 'u' },
                new EDMatrixVertexResult() { EditDistanceActionType = EditDistanceActionType.Replace, OldChar = 'n', NewChar = 'r' },
                new EDMatrixVertexResult() { EditDistanceActionType = EditDistanceActionType.Copy, OldChar = 'd', NewChar = 'd' },
                new EDMatrixVertexResult() { EditDistanceActionType = EditDistanceActionType.Copy, OldChar = 'a', NewChar = 'a' },
                new EDMatrixVertexResult() { EditDistanceActionType = EditDistanceActionType.Copy, OldChar = 'y', NewChar = 'y' }
            };

            int exptectResult = 3;
            Test(str1,str2,  exptectResult, exptectedResultList);
        }

        private static void TestOnlyLength(string str1, string str2, int exptectResult)
        {
            EditDistance editDistance = new EditDistance();
            var actualResult = editDistance.EditDistanceData(str1, str2);
            Console.WriteLine(actualResult);
            Assert.Equal(exptectResult, actualResult);
        }

        private static void Test(string str1, string str2, int exptectResult, List<EDMatrixVertexResult> exptectedResultArray)
        {
            EditDistance editDistance = new EditDistance();
            var acturalResult = editDistance.EditDistanceData_update(str1, str2);
            var actualResultArray = editDistance.Result;

            Console.WriteLine(acturalResult);
            Assert.Equal(exptectResult, acturalResult);
            Assert.Equal(exptectedResultArray.Count, editDistance.Result.Count);

            List<EditDistanceActionType> operationList = new List<EditDistanceActionType>() {
                EditDistanceActionType.Insert,EditDistanceActionType.Replace,EditDistanceActionType.Remove
            };
            //operationList = 

            var actualOperation = actualResultArray.Where(w => operationList.Contains(w.EditDistanceActionType)).ToList();
            var expectedOperation = exptectedResultArray.Where(w => operationList.Contains(w.EditDistanceActionType)).ToList();

            Assert.Equal(actualOperation.Count, expectedOperation.Count);

            for (int i=0;i< exptectedResultArray.Count; i++)
            {
                var actual = actualResultArray[i];
                var expected = exptectedResultArray[i];
                Assert.Equal(expected.EditDistanceActionType, actual.EditDistanceActionType);
                Assert.Equal(expected.OldChar, actual.OldChar);
                Assert.Equal(expected.NewChar, actual.NewChar);
            }
        }
    }
}
