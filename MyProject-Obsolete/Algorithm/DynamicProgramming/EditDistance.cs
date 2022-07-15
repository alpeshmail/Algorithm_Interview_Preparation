using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithm.DynamicProgramming
{
    /*
     Input:   str1 = "geek", str2 = "gesek"
Output:  1
We can convert str1 into str2 by inserting a 's'.
         */
    /// <summary>
    /// https://www.youtube.com/watch?v=We3YDTzNXEk
    /// https://www.youtube.com/watch?v=b6AGUjqIPsA
    /// </summary>
    public class EditDistance
    {
        public string CalculatedString { get; private set; }

        public List<EDMatrixVertexResult> Result { get; private set; }

        public int EditDistanceData(string str1,string str2)
        {
            int totalDistance;
            int m = str1.Length;
            int n = str2.Length;
            int[,] distanceArray = new int[m + 1, n + 1];
           

            for(int i=0;i<= m; i++)
            {
                for(int j=0;j<= n; j++)
                {
                    if (i == 0 && j == 0)
                        distanceArray[i, j] = 0;
                    else if (i== 0 && j > 0)
                        distanceArray[i, j] = distanceArray[i, j - 1] + 1;
                    else if (i >  0 && j == 0 )
                        distanceArray[i, j] = distanceArray[i -1, j] + 1;
                    else
                    {
                        //Fillup acutal logic
                        if (str1[i - 1] == str2[j -1])
                        {
                            distanceArray[i, j] = distanceArray[i - 1, j - 1];
                        }
                        else
                        {
                            int iLeft = distanceArray[i, j - 1]; //Insert
                            int iCross = distanceArray[i-1, j - 1]; //Replace
                            int iTop = distanceArray[i-1, j]; //Remove
                            int minValue = Math.Min(Math.Min(iLeft, iCross), iTop);
                            distanceArray[i, j] = 1 + minValue;
                        }
                    }

                }
            }

            totalDistance = distanceArray[m, n];
            /*
            while(m== 0 || n == 0)
            {
                if (str1[m-1] == str1[n - 1])
                {
                    finalResultString = str1[m - 1] + finalResultString;
                    m--;
                    n--;
                }
                else if (str1[m - 1] != str1[n - 1] && distanceArray[m,n] != distanceArray[m-1, n-1])
                {

                }
            }
            */
            return totalDistance;
        }

        public EDMatrixVertex AddDistance(int iInsertValue,int iReplaceValue,int iRemoveValue)
        {
            EDMatrixVertex eDMatrixVertex= null;

            //int minValue = Math.Min(Math.Min(iInsertValue, iReplaceValue), iRemoveValue);
            //edMatrixVertex = EDMatrixVertex.Create(minValue + 1);

            if (iReplaceValue <= iInsertValue && iReplaceValue <= iRemoveValue)
            {
                eDMatrixVertex = EDMatrixVertex.Create(iReplaceValue + 1);
                eDMatrixVertex.EditDistanceActionType = EditDistanceActionType.Replace;
            }
            else if (iInsertValue <= iReplaceValue && iInsertValue <= iRemoveValue)
            {
                eDMatrixVertex = EDMatrixVertex.Create(iInsertValue + 1);
                eDMatrixVertex.EditDistanceActionType = EditDistanceActionType.Insert;
            }
            else if (iRemoveValue <= iReplaceValue &&  iRemoveValue <= iInsertValue)
            {
                eDMatrixVertex = EDMatrixVertex.Create(iRemoveValue + 1);
                eDMatrixVertex.EditDistanceActionType = EditDistanceActionType.Remove;
            }
            return eDMatrixVertex;
        }

        public int EditDistanceData_update(string str1, string str2)
        {
            string finalResultString = "";
            int totalDistance;
            int m = str1.Length;
            int n = str2.Length;
            EDMatrixVertex[,] distanceArray = new EDMatrixVertex[m + 1, n + 1];
            int calValue;

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 && j == 0)
                        distanceArray[i, j] = EDMatrixVertex.Create(0);
                    else if (i == 0 && j > 0)
                    {
                        calValue = distanceArray[i, j - 1].Value + 1;
                        var edMatrix = EDMatrixVertex.Create(calValue);
                        edMatrix.EditDistanceActionType = EditDistanceActionType.Insert;
                        
                        distanceArray[i, j] = edMatrix;

                    }
                    else if (i > 0 && j == 0)
                    {
                        calValue = distanceArray[i - 1, j].Value + 1;
                        var edMatrix = EDMatrixVertex.Create(calValue);
                        edMatrix.EditDistanceActionType = EditDistanceActionType.Remove;
                        distanceArray[i, j] = edMatrix;
                    }
                    else
                    {
                        //Fillup acutal logic
                        if (str1[i - 1] == str2[j - 1])
                        {
                            calValue = distanceArray[i - 1, j - 1].Value;
                            var edMatrix = EDMatrixVertex.Create(calValue);
                            edMatrix.EditDistanceActionType = EditDistanceActionType.Copy;
                            distanceArray[i, j] = edMatrix;
                        }
                        else
                        {   
                            int insert = distanceArray[i, j - 1].Value; //Insert
                            int replace = distanceArray[i - 1, j - 1].Value; //Replace
                            int remove = distanceArray[i - 1, j].Value; //Remove
                            distanceArray[i, j] = AddDistance(insert, replace, remove);
                            //int minValue = Math.Min(Math.Min(insert, replace), remove);
                            //calValue = minValue + 1;
                            //distanceArray[i, j] = EDMatrixVertex.Create(calValue);
                        }
                    }

                }
            }

            totalDistance = distanceArray[m, n].Value;
            Stack<char> stack = new Stack<char>(); //it can give you new string.
                                                   // List<string> lst = new List<string>();
            Stack<EDMatrixVertexResult> resultStack = new Stack<EDMatrixVertexResult>();



            while (m != 0 && n != 0)
            {
                if (str1[m-1] == str2[n - 1])
                {
                    stack.Push(str1[m - 1]);
                    finalResultString = str1[m - 1] + finalResultString;
                   // lst.Add(string.Format("Match Character str1 {0} and str2 {1}", str1[m - 1], str2[n - 1]));
                    resultStack.Push(new EDMatrixVertexResult() {
                        EditDistanceActionType = EditDistanceActionType.Copy
                        ,OldChar= str1[m - 1], NewChar= str2[n - 1] });
                    m--;
                    n--;
                }
                else if (str1[m - 1] != str2[n - 1])
                {
                    var currentValue = distanceArray[m, n];
                    var previsouValue = distanceArray[m-1, n-1];
                    if (currentValue.EditDistanceActionType == EditDistanceActionType.Replace)
                    {
                        //M is replace with n
                        stack.Push(str2[n - 1]);
                        finalResultString = str2[n - 1] + finalResultString;
                        //lst.Add(string.Format("Replace {0} with {1}", str1[m - 1], str2[n - 1]));
                        resultStack.Push(new EDMatrixVertexResult() {
                            EditDistanceActionType = EditDistanceActionType.Replace ,
                            OldChar = str1[m - 1] ,NewChar = str2[n - 1]
                        });
                        m--;
                        n--;
                    }
                    else if (currentValue.EditDistanceActionType == EditDistanceActionType.Insert)
                    {
                        stack.Push(str2[n - 1]);
                        finalResultString = str2[n - 1] + finalResultString;
                        //lst.Add(string.Format("Insert Character {0}", str2[n - 1]));
                        resultStack.Push(new EDMatrixVertexResult() {
                            EditDistanceActionType = EditDistanceActionType.Insert,
                            NewChar = str2[n - 1]
                        });
                        n--;
                    }
                    else if (currentValue.EditDistanceActionType == EditDistanceActionType.Remove)
                    {
                        //lst.Add(string.Format("Remove Character {0}", str1[m - 1]));
                        resultStack.Push(new EDMatrixVertexResult() {
                            EditDistanceActionType = EditDistanceActionType.Remove,
                            OldChar = str1[m - 1]
                        });
                        m--;
                    }
                }
            }

            CalculatedString = finalResultString;
            Result = resultStack.ToList();
            return totalDistance;
        }
    }

    public class EDMatrixVertex
    {
        public int Value { get; set; }
        public EditDistanceActionType EditDistanceActionType { get; set; }
        public static EDMatrixVertex Create(int _value)
        {
            return new EDMatrixVertex()
            {
                Value = _value,
                EditDistanceActionType = EditDistanceActionType.None
            };
        }
    }

    public class EDMatrixVertexResult
    {
        public EditDistanceActionType EditDistanceActionType { get; set; }

        public char NewChar { get; set; }
        public char OldChar { get; set; }
    }

    public enum EditDistanceActionType
    {
        None=1,
        Copy=2,
        Replace=3,
        Insert=4,
        Remove=5
    }
}
