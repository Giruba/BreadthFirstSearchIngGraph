using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstSearchInGraph
{
    class Graph
    {
        int noVertices;
        LinkedList<int> []adjacencyList;

        public Graph(int vertices) {
            noVertices = vertices;
            adjacencyList = new LinkedList<int>[noVertices];
            for (int i = 0; i < noVertices; i++) {
                adjacencyList[i] = new LinkedList<int>();
            }
        }

        public void addEdge(int startVertex, int endVertext) {
            adjacencyList[startVertex].AddLast(endVertext);
        }

        public void BreadthFirstSearch(Graph g, int startVertex) {
            Queue<int> queue = new Queue<int>();
            bool[] visited = new bool[noVertices];

            Console.WriteLine("-------------BFS---------");

            visited[startVertex] = true;
            queue.Enqueue(startVertex);

            while (queue.Count != 0) {
                int topVertex = queue.Dequeue();
                Console.Write(topVertex+"->");
                LinkedList<int> adjofStart = adjacencyList[topVertex];
                foreach(int vertex in adjofStart) {
                    if (visited[vertex] == false) {
                        visited[vertex] = true;
                        queue.Enqueue(vertex);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
