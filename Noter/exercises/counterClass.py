class Counter:
    def __init__(self, startCount):
        self._count = startCount
    
    def increment(self):
        self._count += 1
    
    def getCount(self):
        return self._count

# c1 = Counter()
# print(c1.getCount())
# c1.increment()
# print(c1.getCount())

class by2(Counter):
    def increment(self):
        self._count += 2

c1 = by2(5)
print(c1.getCount())
c1.increment()
print(c1.getCount())
