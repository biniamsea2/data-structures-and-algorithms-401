### Merge Sort

 Merge sort is an efficient, general-purpose, comparison-based sorting algorithm. 
 Most implementations produce a stable sort, which means that the order of equal elements is the same in the input and output. 
 Merge sort is a divide and conquer algorithm.  

Below we have an example of a merge sort using pseduocode.     
 ##### code starts here:

ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length
           
    if n > 1
      DECLARE mid <-- n/2
      DECLARE left <-- arr[0...mid]
      DECLARE right <-- arr[mid...n]
      // sort the left side
      Mergesort(left)
      // sort the right side
      Mergesort(right)
      // merge the sorted left and right sides together
      Merge(left, right, arr)

ALGORITHM Merge(left, right, arr)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < left.length && j < right.length
        if left[i] <= right[j]
            arr[k] <-- left[i]
            i <-- i + 1
        else
            arr[k] <-- right[j]
            j <-- j + 1
            
        k <-- k + 1

    if i = left.length
       set remaining entries in arr to remaining values in right
    else
       set remaining entries in arr to remaining values in left
       
![Image 1](https://github.com/biniamsea2/data-structures-and-algorithms-401/blob/quicksort/Assets/20191124_181306%20(1).jpg)

  ##### Let's walk through the steps.    
  ### Example:  Array[8,4,23,42,16,15]
- The Method will cut the array in half and place the left half into a new array called left.  
- It will place the right side of the array into a new array called right.  
- We continue cutting each array in half using recursion, until there are only single values left.  
- Once there is only single values left we use the merge method to be able to compare the values to each other a sort them from smallest to biggest.

The Time and Space complexity of this problem is:  
| Time  | Space  
O(n log n) | O(n)
