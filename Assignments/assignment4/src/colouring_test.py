import colouring

# Neighbour List errors:
# - 

# Simple test
simple = [("da", "se"), ("no", "da"), ("se", "no"), ("de", "da")]
simpleTest = colouring.NeighbourRelation(simple)
simpleTest.makeColouring()
print(simpleTest)
print(simpleTest.checkAmountOfUniqueCountries())
print(simpleTest.checkIfNeighboursAreSameColour())

# Empty List test
emptyList = []
emptyTest = colouring.NeighbourRelation(emptyList)
emptyTest.makeColouring()
print(f'Test for Empty List: {emptyTest}')
print(emptyTest.checkAmountOfUniqueCountries()) 
print(emptyTest.checkIfNeighboursAreSameColour()) 

# All Neighbours Test
allNeighboursList = [("da","se"), ("no","da"), ("se","no")]
allNeighbourTest = colouring.NeighbourRelation(allNeighboursList)
allNeighbourTest.makeColouring()
print(f'Test for where all Neighbour List: {allNeighbourTest}') 
print(allNeighbourTest.checkAmountOfUniqueCountries()) 
print(allNeighbourTest.checkIfNeighboursAreSameColour()) 

# Pair Neighbours Test
twoNeighbourList = [("nl","de"),("br","ar"),("cn","vn")]
twoNeighbourTest = colouring.NeighbourRelation(twoNeighbourList)
twoNeighbourTest.makeColouring()
print(f'Test for list with only two neighbour List: {twoNeighbourTest}')
print(twoNeighbourTest.checkAmountOfUniqueCountries())
print(twoNeighbourTest.checkIfNeighboursAreSameColour())

# No Neighbours Test
noNeighbourList = [("nl",'00'),("br",'00'),("cn",'00')]
noNeighbourTest = colouring.NeighbourRelation(noNeighbourList)
noNeighbourTest.makeColouring()
print(f'Test for list with no Neighbours: {noNeighbourTest}')
print(noNeighbourTest.checkAmountOfUniqueCountries())
print(noNeighbourTest.checkIfNeighboursAreSameColour())

