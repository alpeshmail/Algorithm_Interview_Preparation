using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Distance
{
    /// <summary>
    /// http://www.codeding.com/articles/dijkstras-path-finding
    /// https://www.youtube.com/watch?v=pVfj6mxhdMw
    /// //https://www.youtube.com/watch?v=pVfj6mxhdMw
    /// </summary>
    public class DjikstraSearchEngine
    {
        public Map Map { get; set; }
        private string RouteNode { get; set; }

        public DjikstraSearchEngine(Map map)
        {
            Map = map;

        }

        public double GetShortestPathDijikstra(string fromId, string toId)
        {
            var data = DijkstraSearchTest(fromId,toId);
            var totalDistance = GetRecursiveShortestPath(data, toId);
            Console.WriteLine(data.Count);
            var strTravelNode = string.Format("Total Distance: {0}; Route: {1}", totalDistance, RouteNode);
            Console.WriteLine(strTravelNode);
            return totalDistance;
        }

     

        private double GetRecursiveShortestPath(Dictionary<string, ResultTravelPath> resultTravelPath, string _toId)
        {
            var node = resultTravelPath[_toId];
            if (node.PreviosVertex != null && resultTravelPath.ContainsKey(node.PreviosVertex))
            {
                var preNode = resultTravelPath[node.PreviosVertex];
                var result =  GetRecursiveShortestPath(resultTravelPath, preNode.Vertex);
                var finalResult = node.ShortestDistance.Value + result;
                RouteNode += string.Format("From {0} To {1} Distance {2};", node.PreviosVertex , node.Vertex, node.ShortestDistance.Value);
                return finalResult;
            }
            var distance = node.ShortestDistance;
            return distance.Value;
        }

        private Dictionary<string, ResultTravelPath> DijkstraSearchTest(string fromId, string toId)
        {
            var NodeVisits = 0;
            var Start = Map.Nodes.Where(w => w.Name == fromId).FirstOrDefault();
            var End = Map.Nodes.Where(w => w.Name == toId).FirstOrDefault();
            Dictionary<string, ResultTravelPath> dicResultTravelPaths = new Dictionary<string, ResultTravelPath>();
            foreach(var nodeName in Map.Nodes.Distinct().Select(w => w.Name).ToList())
            {
                if (!dicResultTravelPaths.ContainsKey(nodeName))
                {
                    var resultTravelPath = new ResultTravelPath() { Vertex = nodeName };
                    dicResultTravelPaths.Add(nodeName, resultTravelPath);
                }
            }

            dicResultTravelPaths[fromId].ShortestDistance = 0;

            var prioQueue = new List<Node>();
            prioQueue.Add(Start);
            do
            {
                NodeVisits++;
                var node = prioQueue.First();
                var nodeResult = dicResultTravelPaths[node.Name];
                prioQueue.Remove(node);
                foreach (var cnn in node.Connections.OrderBy(x => x.Distance))
                {
                    
                    var childNode = cnn.ConnectedNode;
                    if (childNode.Visited)
                        continue;

                    var childNodeResultTravelPath = dicResultTravelPaths[childNode.Name];


                     if (string.IsNullOrEmpty(childNodeResultTravelPath.PreviosVertex)
                        || (nodeResult.MinDistance + cnn.Distance < childNodeResultTravelPath.MinDistance))
                    {
                        childNodeResultTravelPath.ShortestDistance =  cnn.Distance;
                        childNodeResultTravelPath.MinDistance = nodeResult.MinDistance + cnn.Distance;
                        childNodeResultTravelPath.PreviosVertex = node.Name;
                        if (prioQueue.Count == 0)
                        {
                            childNode.NearestToStart = node;
                            prioQueue.Add(childNode);
                        }
                    }
                }

                node.Visited = true;
                if (node == End)
                    return dicResultTravelPaths;

            } while (prioQueue.Any());

            return dicResultTravelPaths;
        }

        /// <summary>
        /// Reference only method, not in use
        /// </summary>
        private void DijkstraSearch()
        {
            var NodeVisits = 0;
            var Start = Map.StartNode;
            var End = Map.EndNode;


            var prioQueue = new List<Node>();
            prioQueue.Add(Start);
            do
            {
                NodeVisits++;
                var node = prioQueue.First();
                prioQueue.Remove(node);
                foreach (var cnn in node.Connections.OrderBy(x => x.Distance))
                {
                    var childNode = cnn.ConnectedNode;
                    if (childNode.Visited)
                        continue;
                    if (node.Distance + cnn.Distance < childNode.MinDistince)
                    {
                        childNode.MinDistince = node.MinDistince + cnn.Distance;
                        childNode.NearestToStart = node;
                        if (!prioQueue.Contains(childNode))
                            prioQueue.Add(childNode);
                    }
                }
                node.Visited = true;
                if (node == End)
                    return;
            } while (prioQueue.Any());
        }
    }

    public class ResultTravelPath
    {
        public string Vertex { get; set; }
        public double? ShortestDistance { get; set; }
        public string PreviosVertex { get; set; }
        public double MinDistance { get; set; }

    }
}
