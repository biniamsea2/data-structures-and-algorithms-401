## Queue Stacks.
*Author: Biniam Tesfamariam*

---

### Problem Domain


Create a brand new PseudoQueue class. Do not use an existing Queue. 
Instead, this PseudoQueue class will implement our standard queue 
interface (the two methods listed below), but will internally only utilize 2 Stack objects. 
Ensure that you create your class with the following methods:

- Enqueue(value) which inserts value into the PsedoQueue, using 
a First In First Out approach.
- Dequeue() which extracts a value fromt the PseudoQueue using First
In First Out approach.

---

### Inputs and Expected Outputs

Enqueue(value)

| Input | Expected Output |
| :----------- | :----------- |
| [10,15,20],   5 | [5,10,15,20] |


Dequeue()

| Input | Expected Output |
| :----------- | :----------- |
| [5,10,15,20],   20 | [5,10,15] |



---
## Big O
| Space  | Time  
O(n) | O(n)

---

### Whiteboard Visual
![Image 1](https://github.com/biniamsea2/data-structures-and-algorithms-401/blob/master/Assets/20191028_140139.jpg)


---

### Change Log
1.0: Code Challenge 11 completed on 10/28/19
