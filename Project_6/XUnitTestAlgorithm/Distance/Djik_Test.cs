using Algorithm.Distance;
using System;
using Xunit;

namespace XUnitTestAlgorithm.Distance
{
    public class Djik_Test
    {
        [Fact]
        public void Test1()
        {
            Graph graph = new Graph();
            graph.AddEdge("1", "2", 5);
            graph.AddEdge("2", "3", 1);
            graph.AddEdge("3", "4", 4);
            graph.AddEdge("4", "5", 4);
            //graph.AddEdge("5", "1", 8);
            graph.AddEdge("1", "5", 8);
            graph.AddEdge("1", "3", 7);
            graph.AddEdge("2", "4", 8);

            graph.CreateGraph();
            var distance = graph.FindSortDistance("1", "4");
            Console.WriteLine(distance);
            
        }

    }
}
