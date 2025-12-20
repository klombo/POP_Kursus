def isSafe0(a, b):
    return bool((a-b > 0) and (a-b < 3) and (a-b>=1)) 

def isSafe1(a, b):
    return bool((b-a > 0) and (b-a < 3) and (b-a>=1))

def checkSafe(l):
    checkFunctions = [isSafe0, isSafe1]
    safe = True 
    for i in range(len(l)):
        for check_f in checkFunctions:
            if not check_f(l[i],l[i+1]):
                safe = False 
    return safe