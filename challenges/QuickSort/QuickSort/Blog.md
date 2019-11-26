### Quick Sort

Quicksort is an efficient sorting algorithm, serving as a systematic method for placing the elements of a random access file or an array in order from smallest value to largest value.  

Below we have an example of a quick sort using pseduocode.     
 ##### code starts here:
```
ALGORITHM QuickSort(arr, left, right)

    if left < right
        // Partition the array by setting the position of the pivot value 
        DEFINE position <-- Partition(arr, left, right)
        // Sort the left
        QuickSort(arr, left, position - 1)
        // Sort the right
        QuickSort(arr, position + 1, right)

ALGORITHM Partition(arr, left, right)

    // set a pivot value as a point of reference
    DEFINE pivot <-- arr[right]
    // create a variable to track the largest index of numbers lower than the defined pivot
    DEFINE low <-- left - 1
    for i <- left to right do
        if arr[i] <= pivot
            low++
            Swap(arr, i, low)

     // place the value of the pivot location in the middle.
     // all numbers smaller than the pivot are on the left, larger on the right. 
     Swap(arr, right, low + 1)
    // return the pivot index point
     return low + 1

ALGORITHM Swap(arr, i, low)

    DEFINE temp;
    temp <-- arr[i]
    arr[i] <-- arr[low]
    arr[low] <-- temp
```
![Image 1](https://github.com/biniamsea2/data-structures-and-algorithms-401/blob/quicksort/Assets/20191125_225332.jpg)


  ##### Let's walk through the steps.    
- First, you are going to create a pivot. The pivot is going to be the value that we are comparing the other values in the array to.  
- Next, we compare all the other values to the pivot. If the value is less than the pivot then we move it to the left side of the pivot. If the value is great than the pivot then we move it to the right side of the pivot.  
- We continue to do this until there are no more values to compare to the pivot.  
- Once there are no more values to compare, we now have placed the pivot in the correct position in the array.  
- We then select another pivot and continue the process. We continue this process until all the values are placed in the correct order.    

The Time and Space complexity of this problem is:  
| Time  | Space  
O(n*2) | O(n log n)
