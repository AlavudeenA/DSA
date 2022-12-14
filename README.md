Why DSA Matters :

  DSA is applied in problem-solving and enables developers to learn to write efficient code. The quality of the code can be judged by how much memory and time it consumes. The lesser memory the code consumes and the faster it runs, the more efficient it is. How much memory our code consumes is determined by space complexity and How much time it consumes is determined by time complexity.

Why Datastructure matters:

  if you’re building a program that needs to deal with lots of data, or a web app used by thousands of people simultaneously, the data structures you         select may affect whether your software runs at all.
  
Why Algorithms matters:

When applied to computing, an algorithm refers to the set of instructions given to a computer to achieve a particular task. When we write any code, then, we’re creating algorithms for the computer to follow and execute. Ex., Shortest path, Database indices etc.,

Big O Notation: Time complexity or Count the Steps

O(1): Pronounced as “Big Oh of 1 or “Oh of 1.” O(1) simply means that the algorithm takes the same number of steps no matter how much data there is. On an old computer, that step may have taken 20 minutes, and on today’s hardware it may take just a nanosecond. But in both cases, the algorithm takes just a single step.
Ex: Read an element from an array.

O(N): If array is not sorted and in worst case scenario if the element we looking for is found in last cell, then we have to do N checks each cell one at a time. 

O(N^2): for N data elements, there are roughly N^2 steps. Ex: Bubble, Insertion and Selection sorts

O(log N) : Recall that O(N) means that for N data elements, the algorithm would take N steps. If there are 8 elements, the algorithm would take 8 steps. In a sorted array, O(log N) means that for N data elements, the algorithm would take log2 N steps. If there are 8 elements, the algorithm would take 3 steps, since log2 8= 3. Said another way, if we keep dividing the 8 elements in half, it would take us 3 steps until we end up with one element. Ex: Binary Search. Binary search works on sorted array.


Big O Notation ignores constants. This is simply a mathematical way of saying that Big O Notation never includes regular numbers that aren’t an exponent.
What should technically be O(N^2 / 2) becomes simply O(N^2). Similarly, O(2N) would become O(N), and O(N / 2) would also become O(N). Even O(100N), which is 100 times slower than O(N), would also be referred to as O(N).

Sorting algorithms :

Selection Sort: Perhaps the simplest approach is to first scan through the input array to identify minimum element and swap its position with first (or unsorted left most) element. Every iteration left most element is sorted and sorted left most element will not be swapped again. Consider first, second, third and so on elements as an element to start with in each iteration. Time Complexity: O(N^2) - but actually O(N^2 / 2)

Insertion Sort:  It can be viewed as slicker implementation of Selection sort idea of iteratively growing a prefix of the sorted output array. i.e, Consider second, third and so on elements as temp value in each iteration and compare always with its left most sorted array elements from right to left and swap. Time Complexity: O(N^2) - but actually N^2 + 2N - 2

Bubble Sort: Identify adjacent pairs of elements that are out of order and perform repeated swaps until the array is sorted. Consider first, second, third and so on elements as an element to start with in each iteration. Time Complexity: O(N^2).

Average case of Insertion sort: if Insertion Sort takes N^2 steps for the worst case scenario, we’d say that it takes about N^2 / 2 steps for the average scenario. (In terms of Big O, however, both scenarios are O(N^2).) This variance is because - in insertion sort - some passthroughs compare all the data to the left of the temp_value, while other passthroughs end early, due to encountering a value that is less than the temp_value.

So far which is better - Selection Sort or Insertion Sort? The answer is: Well, it depends. In an average case - where an array is randomly sorted - they perform
similarly. If you have reason to assume that you’ll be dealing with data that is mostly sorted, Insertion Sort will be a better choice. If you have reason to
assume that you’ll be dealing with data that is mostly sorted in reverse order, Selection Sort will be faster. If you have no idea what the data will be like,
that’s essentially an average case, and both will be equal.



