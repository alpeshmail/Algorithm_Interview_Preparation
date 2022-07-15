using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Distance
{
    public class Edge
    {
        public string FromId { get; set; }
        public string ToId { get; set; }
        public double Distance { get; set; }
        public Node ConnectedNode { get; set; }
    }

}
