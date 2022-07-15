using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Distance
{
    public class Map
    {
        public List<Node> Nodes { get; set; } = new List<Node>();
        public Node StartNode { get; set; }
        public Node EndNode { get; set; }
        public List<Node> ShortestPath { get; set; } = new List<Node>();

        private List<Edge> Edges;

        public Map(List<Edge> edges)
        {
            Edges = edges;
        }

        public void GenerateMapping()
        {
            Dictionary<string, Node> dicNodes = new Dictionary<string, Node>();
            for (var i = 0; i < Edges.Count; i++)
            {
                var edge1 = Edges[i];
                if (!dicNodes.ContainsKey(edge1.FromId))
                {
                    Node node = new Node(edge1.FromId, 0);
                    node.Connections = GetConnectionNode(edge1.FromId);
                    dicNodes.Add(edge1.FromId, node);
                }
                else if (!dicNodes.ContainsKey(edge1.ToId))
                {
                    Node node = new Node(edge1.ToId, 0);
                    node.Connections = GetConnectionNode(edge1.ToId);
                    dicNodes.Add(edge1.ToId, node);
                }
            }

            Nodes = dicNodes.Select(w => w.Value).ToList();

            foreach (var nodeItem in dicNodes)
            {
                var node = nodeItem.Value;
                var connections = node.Connections;
                foreach (var eachEdge in connections)
                {
                    var matchName = node.Name == eachEdge.ToId ? eachEdge.FromId : eachEdge.ToId;
                    eachEdge.ConnectedNode = Nodes.Where(w => w.Name == matchName).FirstOrDefault();
                }
            }
        }

        private List<Edge> GetConnectionNode(string FromId)
        {
            var listEdgesOfNodes = new List<Edge>();
            foreach (var eachEdge in Edges.Where(w => w.FromId == FromId || w.ToId == FromId))
            {
                listEdgesOfNodes.Add(new Edge() { FromId = eachEdge.FromId, ToId = eachEdge.ToId, Distance = eachEdge.Distance });
            }
            return listEdgesOfNodes;
        }
    }
}
