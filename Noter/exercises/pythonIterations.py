# Define a recursive function that generates the list of even numbers between 0 and 100.
def recEvenNumber(i=0, result = []):    
    if i > 100:
        return result
    
    if i % 2 == 0:
        result.append(i)
    return recEvenNumber(i+1, result)
    

l = recEvenNumber()
print(l)

# Define a function that relies on a for-loop to generate the list of even numbers between 0 and 100.
def loopEvenNumber():
    result = []
    for i in range(0,101):
        if i % 2 == 0:
            result.append(i)
    return result

print(loopEvenNumber())

# Define a function that relies on map and lambda expression to generate the list of even numbers between 0 and 100.
def isEven(i):
    if i % 2 == 0:
        return i

isEvenList = map(isEven, list(range(0, 101)))
print(list(isEvenList))