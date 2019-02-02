using System;

namespace BreadthFirstSearchInGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Breadth First Search!");
            Console.WriteLine("---------------------");

            Graph graph = GetGraphFromInput();
            try
            {
                Console.WriteLine("Enter the start vertex");
                int startVertex = int.Parse(Console.ReadLine());
                graph.BreadthFirstSearch(graph, startVertex);
            }
            catch (Exception exception) {
                Console.WriteLine("Exception thrown is "+exception.Message);
            }


            Console.WriteLine("----------------------");
            Console.ReadLine();
        }

        private static Graph GetGraphFromInput() {
            Graph graph = null;

            Console.WriteLine("Enter the number of vertices in the graph!");
            try
            {
                int noVertices = int.Parse(Console.ReadLine());
                graph = new Graph(noVertices);
                Console.WriteLine("Enter the number of edges in the graph!");
                int noEdges = int.Parse(Console.ReadLine());
                for (int i = 0; i < noEdges; i++) {
                    Console.WriteLine("Enter the edge "+i+":");
                    String[] elements = Console.ReadLine().Split(' ');
                    graph.addEdge(int.Parse(elements[0]), int.Parse(elements[1]));
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }


            return graph;
        }
    }
}
