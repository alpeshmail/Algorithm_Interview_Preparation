using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Distance.BackUp
{
    public class Edge_bk
    {
        public double Length { get; set; }
        public double Cost { get; set; }
        public Node_bk ConnectedNode { get; set; }

        public override string ToString()
        {
            return "-> " + ConnectedNode.ToString();
        }
    }
}
