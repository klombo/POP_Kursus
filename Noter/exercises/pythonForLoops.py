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

def printAll (List):
    for element in List:
        print(element)

printAll(ints)

# Using a for loop, write a function that takes as input an array of integer and increments each value in the array with 1
def increment(intList):
    for index in range(len(intList)):
        intList[index] = intList[index] + 1
    return intList

print (increment(ints))