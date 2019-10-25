
## Linked List
*Author: Biniam Tesfamariam*

---

### Problem Domain  
Write the following methods for the Linked List class:  

.append(value) which adds a new node with the given value to the end of the list  
.insertBefore(value, newVal) which add a new node with the given newValue immediately before the first value node  
.insertAfter(value, newVal) which add a new node with the given newValue immediately after the first value node  

---

### Inputs and Expected Outputs

#### .append(value)
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| head -> [1] -> [3] -> [2] -> X | 5 | head -> [1] -> [3] -> [2] -> [5] -> X |
| head -> X | 1 | head -> [1] -> X |
#### .insertBefore(value, newValue)
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| head -> [1] -> [3] -> [2] -> X | 3, 5 | head -> [1] -> [5] -> [3] -> [2] -> X |
| head -> [1] -> [3] -> [2] -> X | 1, 5 | head -> [5] -> [1] -> [3] -> [2] -> X |
| head -> [1] -> [3] -> [2] -> X | 4, 5 | Exception |
#### .insertAfter(value, newValue)
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| head -> [1] -> [3] -> [2] -> X | 3, 5 | head -> [1] -> [3] -> [5] -> [2] -> X |
| head -> [1] -> [3] -> [2] -> X | 1, 5 | head -> [1] -> [5] -> [3] -> [2] -> X |
| head -> [1] -> [3] -> [2] -> X | 4, 5 | Exception |

---

### Big O


| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |


---


### Whiteboard Visual
Code Challenge 6
![Image 1](https://github.com/biniamsea2/data-structures-and-algorithms-401/blob/master/Assets/20191022_135643.jpg)
Code Challenge 7
![Image 1](https://github.com/biniamsea2/data-structures-and-algorithms-401/blob/master/Assets/20191023_135831.jpg)
Code Challenge 8
![Image 1](https://github.com/biniamsea2/data-structures-and-algorithms-401/blob/master/Assets/20191024_134956.jpg)




---

### Change Log
 
1.0: Code Challenge 6 Completed - 22 Oct 2019  

---
