using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Distance.BackUp
{
    public class Node_bk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Point_bk Point { get; set; }
        public List<Edge_bk> Connections { get; set; } = new List<Edge_bk>();

        public double? MinCostToStart { get; set; }
        public Node_bk NearestToStart { get; set; }
        public bool Visited { get; set; }
        public double StraightLineDistanceToEnd { get; set; }

        internal static Node_bk GetRandom(Random rnd, string name)
        {
            return new Node_bk
            {
                Point = new Point_bk
                {
                    X = rnd.NextDouble(),
                    Y = rnd.NextDouble()
                },
                Id = Guid.NewGuid(),
                Name = name
            };
        }

        internal void ConnectClosestNodes(List<Node_bk> nodes, int branching, Random rnd, bool randomWeight)
        {
            var connections = new List<Edge_bk>();
            foreach (var node in nodes)
            {
                if (node.Id == this.Id)
                    continue;

                var dist = Math.Sqrt(Math.Pow(Point.X - node.Point.X, 2) + Math.Pow(Point.Y - node.Point.Y, 2));
                connections.Add(new Edge_bk
                {
                    ConnectedNode = node,
                    Length = dist,
                    Cost = randomWeight ? rnd.NextDouble() : dist,
                });
            }
            connections = connections.OrderBy(x => x.Length).ToList();
            var count = 0;
            foreach (var cnn in connections)
            {
                //Connect three closes nodes that are not connected.
                if (!Connections.Any(c => c.ConnectedNode == cnn.ConnectedNode))
                    Connections.Add(cnn);
                count++;

                //Make it a two way connection if not already connected
                if (!cnn.ConnectedNode.Connections.Any(cc => cc.ConnectedNode == this))
                {
                    var backConnection = new Edge_bk { ConnectedNode = this, Length = cnn.Length };
                    cnn.ConnectedNode.Connections.Add(backConnection);
                }
                if (count == branching)
                    return;
            }
        }

        public double StraightLineDistanceTo(Node_bk end)
        {
            return Math.Sqrt(Math.Pow(Point.X - end.Point.X, 2) + Math.Pow(Point.Y - end.Point.Y, 2));
        }

        internal bool ToCloseToAny(List<Node_bk> nodes)
        {
            foreach (var node in nodes)
            {
                var d = Math.Sqrt(Math.Pow(Point.X - node.Point.X, 2) + Math.Pow(Point.Y - node.Point.Y, 2));
                if (d < 0.01)
                    return true;
            }
            return false;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
