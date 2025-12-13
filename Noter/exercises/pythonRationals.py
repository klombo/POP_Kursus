def qplus(x,y):
    resultNum = x[0] * y[1] + x[1] * y[0]
    resultDem = x[1] * y[1]
    return (resultNum,resultDem)

def qminus(x,y):
    resultNum = x[0] * y[1] - x[1] * y[0]
    resultDem = x[1] * y[1]
    return (resultNum, resultDem)

def qmult(x,y):
    resultNum = x[0] * y[0]
    resultDem = x[1] * y[1]
    return(resultNum, resultDem)

def qdiv(x,y):
    resultNum = x[0] * y[1]
    resultDem = y[0] * x[1]
    return(resultNum,resultDem)

tuple1 = (1,2)
tuple2 = (2,3)
print(qplus(tuple1,tuple2))
print(qminus(tuple1,tuple2))
print(qmult(tuple1,tuple2))
print(qdiv(tuple1,tuple2))
