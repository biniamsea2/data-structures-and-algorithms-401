
## Linked List
*Author: Biniam Tesfamariam*

---

### Problem Domain  
Write the following methods for the Linked List class:  
#### Code Challenge 6:  

.append(value) which adds a new node with the given value to the end of the list  
.insertBefore(value, newVal) which add a new node with the given newValue immediately before the first value node  
.insertAfter(value, newVal) which add a new node with the given newValue immediately after the first value node  

#### Code Challenge 7:  

Write a method for the Linked List class which takes a number, k, as a parameter. Return the node’s value that is k from the end of the linked list. You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

#### Code Challenge 8:  

Write a function called mergeLists which takes two linked lists as arguments. Zip the two linked lists together into one so that the nodes alternate between the two lists and return a reference to the head of the zipped list. Try and keep additional space down to O(1). You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

---

### Inputs and Expected Outputs for Code Challenge 6

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


### Inputs and Expected Outputs for Code Challenge 7

#### ll.kthFromEnd(k)
| Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| head -> [1] -> [3] -> [8] -> [2] -> X | 0 | [2]

### Inputs and Expected Outputs for Code Challenge 8

#### mergeLists(list1, list2)
| Input | Input | Args | Expected Output |
| :----------- |:-- |:----------- |
| head -> [1] -> [3] -> [2] -> X | head -> [1] -> [3] -> [2] -> X | [2]



| Input | | Input2 | Args | Expected Output |
| :----------- |:-- |:----------- |
| head -> [1] -> [3] -> [2] -> X | head -> [5] -> [9] -> [4] -> X | head -> [1] -> [5] -> [3] -> [9] -> [2] -> [4] -> X







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
1.0: Code Challenge 7 Partial - 24 Oct 2019  
1.0: Code Challenge 6 Partial - 25 Oct 2019  

---
