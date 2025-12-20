# Object-oriented programming was introduced in week 10 (slides 23-33). 
# Jon used pizza as an example to show the benefits of encapsulation to 
# (i) group functions together with the data they work on, and 
# (ii) hide how data is actually organized within an object so that it is easier to manipulate. 
# F# makes it possible to define classes as types to which both data 
# and functions are connected (indentation is used to define a function as a method within a class), 
# and objects as values from such types. Python offers very similar constructs.

# A. Define a class report with one attribute: a list of levels (given as parameter to the constructor).
# B. Define a method checkSafe() that returns True if the report is safe and False otherwise.
class Report:
    def __init__(self, levels):
        self.levels = levels
        
    def isSafe0(a, b):
        return bool((a-b > 0) and (a-b < 3) and (a-b>=1)) 

    def isSafe1(a, b):
        return bool((b-a > 0) and (b-a < 3) and (b-a>=1))

    def checkSafe(self, l):
        safe = False
        retning = l[0] > l[1] # False = stiger eller True = falder
        for i in range(len(l)-1):
            if retning and self.isSafe0(l[i],l[i+1]): safe = True
            elif not retning and self.isSafe1(l[i],l[i+1]): safe = True
            else: 
                safe = False
                return safe    
        return safe