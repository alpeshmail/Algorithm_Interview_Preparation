using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.LinkedList
{
    /// <summary>
    /// https://www.geeksforgeeks.org/sum-of-two-linked-lists/
    /// Add two numbers represented by linked lists | Set 2
    ///Given two numbers represented by two linked lists, write a function that returns the sum list. T
    ///he sum list is linked list representation of the addition of two input numbers.
    ///It is not allowed to modify the lists. Also, not allowed to use explicit extra space (Hint: Use Recursion).
    ///Example Input:
    /// First List: 5->6->3  
    ///  Second List: 8->4->2 
    ///  Output   Resultant list: 1->4->0->5
    /// </summary>
    public class AddTwoNumbers
    {
        public int carry = 0;
        public LinkedListNode ResultNode = null;

        public int DoSum(int valueA1,int valueB1)
        {
            var linkedListNode_A1 = CreateLinkList.GetIntLinkedList(valueA1.ToString(),out int valueALength);
            var linkedListNode_B1 = CreateLinkList.GetIntLinkedList(valueB1.ToString(), out int valueBLength);

            if (valueALength > valueBLength)
            {
                var total = valueBLength - valueALength;
                linkedListNode_B1 = AddPrecedingZero(linkedListNode_B1, total);
            }
            else if (valueBLength > valueALength)
            {
                var total = valueALength - valueBLength;
                linkedListNode_A1 = AddPrecedingZero(linkedListNode_A1, total);
            }

           Sum(linkedListNode_A1, linkedListNode_B1);
            if (carry > 0)
                PushToLinkList(carry);
            var displayResult= CombineResult(out int result);
            Console.WriteLine(displayResult);
            return result;
        }

        private LinkedListNode AddPrecedingZero(LinkedListNode node, int total)
        {
            LinkedListNode headNode = new LinkedListNode(0);
            var newNode = headNode;
            for (var i = 1; i <= total; i++)
            {
                newNode.Next = new LinkedListNode(0);
                if (i != total)
                    newNode = newNode.Next;
            }
            newNode.Next = node;
            return headNode;
        }

        private void Sum(LinkedListNode node1, LinkedListNode node2)
        {
            if (node1 == null)
            {
               
                return;
            }
            if (node1.Next != null && node2.Next != null)
                Sum(node1.Next, node2.Next);
            var result = node1.Value + node2.Value + carry;
            var sum = result >= 10 ? result % 10 : result;
            carry = result / 10;
            PushToLinkList(sum);
        }

        private void PushToLinkList(int sum) {
            var node = new LinkedListNode(sum)
            {
                Next = ResultNode
            };
            ResultNode = node;
        }

        public string CombineResult(out int Result)
        {
            StringBuilder sbDispalyNode = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            var node = ResultNode;
            string starArrow = " => ";
            do
            {
                sbDispalyNode.AppendFormat("{0} {1}", node.ToString(), starArrow);
                sb.Append(node.ToString().Trim());
                node = node.Next;
            }
            while (node != null);
            if (sbDispalyNode.Length > 0)
                sbDispalyNode.Length -= starArrow.Length;
            Result = Convert.ToInt32(sb.ToString());
            return sbDispalyNode.ToString();
        }
    }
}
