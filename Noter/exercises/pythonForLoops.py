# Write a loop that iterates from 0 to 4 and prints the iteration.
# for i in range(5):
#     print(i)

# Define an array of 10 strings;
# Write a for loop that prints each element of the array
# Define a list of 4 int;
# Write a for loop that prints each element of the array
strings = [
    "apple",
    "banana",
    "cherry",
    "strawbeery",
    "fig",
    "date",
    "elderberry",
    "kiwi",
    "lemon",
    "citrus"
]

ints = [10,20,30,40]

# def printAll (List):
#     for element in List:
#         print(element)

# printAll(ints)

# Using a for loop, write a function that takes as input an array of integer and increments each value in the array with 1
# def increment(intList):
#     for index in range(len(intList)):
#         intList[index] = intList[index] + 1
#     return intList

# print (increment(ints))

# Using a for loop, write a function that takes as input an array of integer and computes the sum of the values in the array
# def sum(intList):
#     sum = 0
#     for x in intList:
#         sum += x
#     return sum

# print(sum(ints))

# Using a for loop, write a function that takes as input an array of integer and finds the maximum value in the array
# exampleList1 = [4, 23, 6, 7, 9, 2]

# def maxValue(intList):
#     highestValue = 0
#     for x in intList:
#         if x > highestValue:
#             highestValue = x
#     return highestValue

# print(maxValue(exampleList1))

# Using for loop(s), write a function that takes as input an array of integer and outputs the reverse of that array
# (e.g., when the input is [|1; 2; 3|] then the output is [|3; 2; 1|])

# def reverseList(inputList):
#     reversed = []
#     for x in inputList:
#         reversed = [x] + reversed
#     return reversed

# print(reverseList(ints))

# Using for loop(s), write a function that takes as input an array of integer (with distinct values) 
# and outputs a list containing every possible pairs of integers without repetitions 
# (e.g., when the input is [|1; 2; 3; 4|] then the output is [(1,2); (1,3); (1,4); (2,3); (2,4); (3,4)]

# def findPairs(inputList):
#     pairs = []
#     for i in range(len(inputList)):
#         for j in range(i):
#             output = (inputList[j],inputList[i])
#             #print(output)
#             pairs.append(output)
               
#     return pairs

# print(findPairs(ints))