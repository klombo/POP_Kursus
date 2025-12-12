l = [1,2,3,31,42,67,69,21]

# define a function that takes a list as input and prints its elements to the screen.
# def printAll(inputList):
#     [print(x) for x in inputList]
    
# printAll(l)

# define a function that takes a list of integer as input and returns its maximum value.
# def maximumValue(inputList):
#     return max(inputList)
    
# print(maximumValue(l))

# define a recursive function that  takes an integer as parameter and returns its factorial
def factorial(n):
    if (n == 1 or n == 0):
        return 1
    elif (n < 0):
        return 0
    return n * factorial(n-1)

#print(factorial(5))

# define a recursive function that takes two integers as parameters and returns their greatest common divisor
def gcd(n, k):
    if (k == 0):
        return n
    return gcd (k, n%k)

print(gcd(3,9))

# define a recursive function that computes the compound interest of a principal (integer), with an interest rate (float) over a number of years (integer). 
# The compound interest is the total amount of principal and interest after a number of years, minus the initial principal amount.

def compoundInterest(interest, year, amount):
    if (year <= 0):
        return amount
    amountAfterInterest = amount + amount * (interest/100)
    return compoundInterest(interest, year-1, amountAfterInterest) 

print(compoundInterest(1.5, 10, 1000))