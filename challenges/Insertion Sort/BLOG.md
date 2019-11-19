### Insertion Sort

Insertion sort is a simple sorting algorithm that builds the final sorted array one item at a time. 
It might not be the most efficient way to sort our an array but it gets the job done.   
Below we have some pseduocode that we will work with in this blog.     
 ##### code starts here:
  InsertionSort(int[] arr)

    FOR i = 1 to arr.length
    
      int j <-- i - 1
      int temp <-- arr[i]
      
      WHILE j >= 0 AND temp < arr[j]
        arr[j + 1] <-- arr[j]
        j <-- j - 1
        
      arr[j + 1] <-- temp

  ##### Before we discuss the pseduocode it might be easier to first work with a visual example.    
  ### Example:  ![Image 1](https://github.com/biniamsea2/data-structures-and-algorithms-401/blob/master/challenges/Insertion%20Sort/Insertion%20Sort/Assets/20191118_173425.jpg)  
- So, as you can see we have an array at the top, our array has 6 numbers [8,4,23,42,16,15].  
- Next, we use that as our first input. We want to be able to order this array from smallest to biggest. So, we take the value at index 1 and compare it the value
at index 0. We start at index 1 becuase we are able to compare it to index 0. So, here we have the value 4 at index 1 being compared to the value at index 0 which is 8.  
- Since, 4 is less than 8 we must replace the values. In our output we only switched those two values, we'll switch the rest later.  
- Now, we need to do the same thing for the next index, which is index 3 and that has a value of 23. We need to compare 23 to 8, and since 23 is not less than 8 it stays where its at.
We don't need to compare it to 4 becuase we already know that is bigger than 4. Our output remains the same.  
- We now move onto the third index which has a value of 42. We compare 42 to 23 and since 42 is greater than 23 it doesn't change. Our output remains the same.  
- Our next index is 4 which has a value of 16. We compare 16 to 42, since 16 is less than 42 they switch places. Next, 16 compares itself to 23 and since 16 is less than 23 they too switch places.
Now, 16 compares itself to 8 and since 16 is greater than 8; it found its new home after 8 and before 23. So our output should be [4,8,16,23,42,15].  
- We have one more number to check and thats 15 at index 5. We compare 15 to 42, it takes that spot, then we compare it to 23, it takes that spot, then we compare it to 16, it also takes that spot, then 
lastly we compare 15 to 8 and since 15 is greater than 8, 15 is placed between 8 and 16. So our output looks like [4,8,15,16,23,42].  
- And that folks is an example of Insertion Sort.  

The Time and Space complexity of this problem is:  
| Time  | Space  
O(n*2) | O(1)
