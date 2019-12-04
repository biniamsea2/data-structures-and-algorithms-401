using System;

namespace graphcodechallenge
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        class Graph<T>
        {
            //make the key the vertex with type T.
            public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }
            //_ represents a private variable
            private int _size;

            public Graph()
            {
                AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
            }



            //AddNode(value of node) => added node
            public Vertex<T> AddVertex(T value)
            {
                Vertex<T> vertex = new Vertex<T>(value);
                //dictionary does this for use
                //if (AdjacencyList.ContainsKey(vertex))

                AdjacencyList.Add(vertex, new List<Edge<T>>());

                _size++;
                return vertex;
            }

            public int Size()
            {
                return _size;
            }

            public void AddDirectedEdge(Vertex<T> source, Vertex<T> destination, int weight)
            {
                //create an edge, include destination and the edge.
                //find the source in the AL and add the edge.

                AdjacencyList[source].Add
                    (new Edge<T>
                    {
                        Vertex = destination
                    Weight = weight
                    });

            }

            //from, to, weight
            public void AddUndirectedEdge(Vertex<T> source, Vertex<T> destination, int weight)
            {
                //attach source to destination with
                AddDirectedEdge(source, destination, weight);
                AddDirectedEdge(destination, source, weight);
            }

            public List<Vertex<T>> GetAllVertices()
            {
                List<Vertex<T>> vertices = new List<Vertex<T>>();
                foreach (var vertex in AdjacencyList)
                {
                    vertices.Add(vertex.Key);
                }
            return vertices;
            }

            public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
            {
                return AdjacencyList[vertex];
            }
        







        class Vertex<T>
        {
            public T Value { get; set; }
            public Vertex(T value)
            {
                Value = value;
            }

        }

        //edge is a combination of the verex and weight
        class Edge<T>
        {
            public int Weight { get; set; }
            public Vertex<T> Vertex { get; set; }
        }

         public void BreadthFirst()
            {

            }

    }
}
