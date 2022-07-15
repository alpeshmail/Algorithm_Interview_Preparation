using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithm.Distance
{
    /// <summary>
    /// Dijkstra’s shortest path algorithm | Greedy Algo-7
    // Find sortest distanec between two cities
    //https://www.geeksforgeeks.org/dijkstras-shortest-path-algorithm-greedy-algo-7/
    /// </summary>
    public class Graph
    {
        private List<Edge> Edges;
        private Map Map;
        public Graph()
        {
            Edges = new List<Edge>();
        }

        public void AddEdge(string _fromId, string _toId, double _distance)
        {
            var edge = new Edge()
            {
                FromId = _fromId,
                ToId = _toId,
                Distance = _distance
            };

            Edges.Add(edge);
        }

        public void CreateGraph()
        {
            Map = new Map(Edges);
            Map.GenerateMapping();
        }

        public double FindSortDistance(string fromId, string toId)
        {
            var djikstraSearchEngine = new DjikstraSearchEngine(Map);
            return djikstraSearchEngine.GetShortestPathDijikstra(fromId, toId);
        }
    }

    public class Graph_bk
    {
        private List<Edge> Edges;
        private readonly Map Map;
        public Graph_bk()
        {
            Edges = new List<Edge>();
            Map = new Map(Edges);
        }

        public void AddEdge(string _fromId, string _toId, double _distance)
        {
            var edge = new Edge()
            {
                FromId = _fromId,
                ToId = _toId,
                Distance = _distance
            };

            Edges.Add(edge);
        }

        /// <summary>
        /// Working version, above is simplified version
        /// </summary>
        public void CreateGraph_Working()
        {
            Dictionary<string, Node> dicNodes = new Dictionary<string, Node>();
            List<Node> Nodes = new List<Node>();
            var edge = Edges[0];
            Node firstnode = new Node(edge.FromId, edge.Distance);
            Map.StartNode = firstnode;
            firstnode.Connections = GetConnectionNode(edge.FromId);
            var lastNode = firstnode;
            Nodes.Add(firstnode);
            dicNodes.Add(edge.FromId, firstnode);
            for (var i = 1; i < Edges.Count; i++)
            {

                var edge1 = Edges[i];
                if (!dicNodes.ContainsKey(edge1.FromId))
                {
                    Node node = new Node(edge1.FromId, 0);
                    node.Connections = GetConnectionNode(edge1.FromId);
                    Nodes.Add(node);
                    dicNodes.Add(edge1.FromId, node);
                    lastNode = node;
                }
            }

            //
            Map.EndNode = lastNode;
            Map.Nodes = Nodes;

            for (var i = 0; i < Nodes.Count; i++)
            {
                var node = Nodes[i];
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

        public double FindSortDistance(string fromId, string toId)
        {

            var djikstraSearchEngine = new DjikstraSearchEngine(Map);
            return djikstraSearchEngine.GetShortestPathDijikstra(fromId, toId);

        }
    }
}
