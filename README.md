## Queue Stacks.
*Author: Biniam Tesfamariam*

---

### Problem Domain


Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.
Implement the following methods:  
- enqueue(animal): adds animal to the shelter. animal can be either a dog or a cat object.
- dequeue(pref): returns either a dog or a cat. If pref is not "dog" or "cat" then return null.



---

### Inputs and Expected Outputs

Enqueue(Animal)

| Input | Animal |Expected Output |
| :----------- | :----------- |
| [D,C,C,D,D],  | C | [C,D,C,C,D,D] |


Dequeue(Pref)

| Input | Pref | Expected Output | Returns |
| :----------- | :----------- |
| [D,C,C,D,D],  | C | [D,C,C] | C

Pops the first two dogs off and returns the first cat



---
## Big O
| Space  | Time  
O(n) | O(n)

---

### Whiteboard Visual
![Image 1](https://github.com/biniamsea2/data-structures-and-algorithms-401/blob/master/Assets/20191028_140139.jpg)


---

### Change Log
1.0: Code Challenge 12 Partial on 10/29/19