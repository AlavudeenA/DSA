Why DSA Matters :

  DSA is applied in problem-solving and enables developers to learn to write efficient code. The quality of the code can be judged by how much memory and     time it consumes. The lesser memory the code consumes and the faster it runs, the more efficient it is. How much memory it consumes = space complexity ,   Hom much time it consumes = time complexity.

Why Datastructure matters:

  if you’re building a program that needs to deal with lots of data, or a web app used by thousands of people simultaneously, the data structures you         select may affect whether your software runs at all, or simply conks out because it can’t handle the load.

Array and Set:

  The array and set are one of the most basic data structures in computer science. Ex: array = ["apples", "bananas", "cucumbers", "dates", "elderberries"]

Many data structures are used in four basic ways, which we refer to as operations. These operations are:

Read: Reading refers to looking something up at a particular spot within the data structure. With an array, this means looking up a value at a particular index. For example, looking up which grocery item is located at index 2 would be reading from the array.

Search: Searching refers to looking for a particular value within a data structure. With an array, this means looking to see if a particular value exists within the array, and if so, at which index. For example, looking up the index of "dates" in our grocery list would be searching the array.

Insert: Insertion refers to adding a new value to our data structure. With an array, this means adding a new value to an additional slot within the array. If we were to add "figs" to our shopping list, we’d be inserting a new value into the array.

Delete: Deletion refers to removing a value from our data structure. With an array, this means removing one of the values from the array. For example, if we removed "bananas" from our grocery list, this value would be deleted from the array.

Measuring speed:

Why do we measure code’s speed in terms of steps?

We do this because we can never say definitively that any operation takes, say, five seconds. While a piece of code may take five seconds on a particular computer, that same piece of code may take longer on an older piece of hardware. For that matter, that same code might run much faster on the supercomputers of tomorrow. Measuring the speed of an operation in terms of time is undependable, since the time will always change depending on the hardware it is run on.

However, we can measure the speed of an operation in terms of how many computational steps it takes. If Operation A takes 5 steps, and Operation B takes 500 steps, we can assume that Operation A will always be faster than Operation B on all pieces of hardware. Measuring the number of steps is, therefore, the key to analyzing the speed of an operation.

Let’s apply this to our grocery list array. Our example array begins at memory address 1010. So, if we told the computer to read the value at index 3, the computer would go through the following thought process:

The array begins with index 0, which is at memory address 1010.
Index 3 will be exactly three slots past index 0.
By logical extension, index 3 would be located at memory address 1013, since 1010 + 3 is 1013.
Once the computer knows that index 3 is at memory address 1013, it can jump right there and see that it contains the value "dates".

Read:

Reading from an array is, therefore, an efficient operation, since the computer can read any index by jumping to any memory address in one step. 

Search:
 
To search for a item within the array for example cucumbers, the computer has no choice but to inspect each cell one at a time. This basic search operation—in which the computer checks each cell one at a time—is known as linear search.

Now, what is the maximum number of steps a computer would need to perform to conduct a linear search on an array?

If the value we’re seeking happens to be in the final cell in the array (like "elderberries"), then the computer would end up searching through every cell of the array until it finally finds the value it’s looking for. Also, if the value we’re looking for doesn’t occur in the array at all, the computer likewise would have to search every cell so that it can be sure the value doesn’t exist within the array.

So, it turns out that for an array of five cells, the maximum number of steps linear search would take is five. For an array of 500 cells, the maximum number of steps linear search would take is 500.

Another way of saying this is that for N cells in an array, linear search would take a maximum of N steps. In this context, N is just a variable that can be replaced by any number.

In any case, it’s clear that searching is less efficient than reading, since searching can take many steps, while reading always takes just one step no matter the size of the array.
