# the levels are either all decreasing or increasing
# any two adjacent levels differ by at least one and at most three

# Inputs:
increasingInput = [1,2,3,4,5]
decreasingInput = [5,4,3,2,1]
notSafeIncreasingInput = [1,5,10]
notSafeDecreasingInput = [10,5,1]
changingDirectionInput = [1,4,3,5]

def isSafe0(a, b):
    return bool((a-b > 0) and (a-b <= 3) and (a-b>=1)) 

def isSafe1(a, b):
    return bool((b-a > 0) and (b-a <= 3) and (b-a>=1))

def checkSafe(l):
    safe = False
    retning = l[0] > l[1] # False = stiger eller True = falder
    for i in range(len(l)-1):
        if retning and isSafe0(l[i],l[i+1]):
            safe = True
        elif not retning and isSafe1(l[i],l[i+1]):    
            safe = True
        else: 
            safe = False
            return safe    
    return safe

def passFail(bool):
    if bool: print('PASSED')
    else: print('FAILED')

def testFunction():
    passFail(True == checkSafe(increasingInput))
    passFail(True == checkSafe(decreasingInput))
    passFail(False == checkSafe(notSafeIncreasingInput))
    passFail(False == checkSafe(notSafeDecreasingInput))
    passFail(False == checkSafe(changingDirectionInput))
    
testFunction()