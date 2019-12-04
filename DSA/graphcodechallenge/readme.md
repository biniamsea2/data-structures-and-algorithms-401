## Code Challenge: Graph Implementation    
*Author: Biniam Tesfamariam*

---


## Features:  
- Implement your own Graph. The graph should be represented as an adjacency list, and should include the following methods:

- Implement a breadth-first traversal on a graph. (Code challenge 36)   

AddNode()  
- Adds a new node to the graph  
- Takes in the value of that node  
- Returns the added node  

AddEdge()  
- Adds a new edge between two nodes in the graph  
- Include the ability to have a “weight”  
- Takes in the two nodes to be connected by the edge  
- Both nodes should already be in the Graph  

GetNodes()  
- Returns all of the nodes in the graph as a collection (set, list, or similar)  

GetNeighbors()  
- Returns a collection of nodes connected to the given node  
- Takes in a given node  
- Include the weight of the connection in the returned collection.  

Size()  
- Returns the total number of nodes in the graph  
## Unit Tests:
Write tests to prove the following functionality:

- Node can be successfully added to the graph  
- An edge can be successfully added to the graph  
- A collection of all nodes can be properly retrieved from the graph  
- All appropriate neighbors can be retrieved from the graph  
- Neighbors are returned with the weight between nodes included  
- The proper size is returned, representing the number of nodes in the graph  
- A graph with only one node and edge can be properly returned  
- An empty graph properly returns null  

---


### Big O:  
| Time |  Space |
| :----------- | :----------- |
 O(V+E) | O(n) | 


### Whiteboard Visual
![Image 1]()

---

### Change Log
 
1.0: Code Challenge 35/36 Partial - 4 DEC 2019  


---