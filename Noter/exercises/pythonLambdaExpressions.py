# Consider the function apply defined as follows:
def apply (f, *args):
    return f(*args)
        
# call apply with a function that takes one integer as parameter and returns true if the parameter is even
checkIfEven = lambda i : i % 2 == 0

isEven = apply(checkIfEven, 8)
print(isEven)

# call apply with a function that takes two integer parameters and returns true if the first parameter is greater than the second
greaterThan = lambda a, b: a > b

isGreater = apply(greaterThan, 4, 2)
print(isGreater)

# call apply with a function that takes three integers as parameters and returns a tuple of three corresponding strings 
tupledStrings = lambda a, b, c: (str(a),str(b),str(c))

theTupleString = apply(tupledStrings, 42, 67, 69)
print(theTupleString)

# The built-in function map can be used to apply a function to all elements of a list. 

# call map with a function that takes a list of integers and returns a list of booleans that are true if the integer is even
def isEven(i):
    return i % 2 == 0

isEvenList = map(isEven, [0,1,2,3,4,5])
print(list(isEvenList))

# call map with a function that takes a list of tuples formed of two integers and 
# returns a list of boolean indicating whether the first element of the tuple is greater than the second

def isGreaterTuple(i):
    return i[0] > i[1]

tupleList = [(4,2), (6,7), (9,6)]

isGreaterTupleList = list(map(isGreaterTuple, tupleList))
print(isGreaterTupleList)

# call map with a function that takes a list of integers as parameters and returns a list of corresponding strings (e.g., 10 becomes '10').
def stringList(i):
    return str(i)

numberList = list(range(0,10))
numberToStringList = list(map(stringList, numberList))
print(numberToStringList)
