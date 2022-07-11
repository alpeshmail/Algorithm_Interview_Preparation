using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Distance
{
    public class Node
    {
        public string Name { get; set; }
        public List<Edge> Connections { get; set; } = new List<Edge>();
        public Node NearestToStart { get; set; }
        public bool Visited { get; set; }
        public double Distance { get; set; }

        public double MinDistince { get; set; }

        public ResultTravelPath ResultTravelPath { get; set; }

        public Node(string _name,double distinct)
        {
            Name = _name;
            Distance = distinct;
            Visited = false;
        }

        public void ConnectClosestNodes(List<Node> nodes)
        {

        }
    }


}
