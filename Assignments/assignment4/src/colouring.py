class NeighbourRelation:
    def __init__(self, nr):
        self.__nr = nr
        self.__nodes = [c for (c, _) in nr]
        self.__colouring = []

    def __areNeighbours(self, c1, c2):
        return ((c1, c2) in self.__nr)

    def __canExtendColour(self, country, colour):
        for c in colour:
            if self.__areNeighbours(c, country):
                return False
        return True

    def __extendColouring(self, country, colouring):
        if colouring == []: return [[]]
        else: 
            colour = colouring[0]
            if self.__canExtendColour(country, colour):
                # Beware!:  side effect
                colouring[0].append(country)
                return colouring
            else:
                return [colour] + self.__extendColouring(country, colouring[:1])

    def makeColouring(self):
        for c in self.__nodes:
            self.__colouring = self.__extendColouring(c, self.__colouring)

    def __str__(self):
        return str(self.__colouring)
    
    def checkAmountOfUniqueCountries(self):
        countryColouringList = []
        countryNRList = []
        
        for colour in self.__colouring:
            for country in colour:
                countryColouringList.append(country)
        
        for neighbourRelation in self.__nr:
            country1 = neighbourRelation[0]
            country2 = neighbourRelation[1]
            if country1 not in countryNRList: countryNRList.append(country1)
            if country2 not in countryNRList: countryNRList.append(country2)
        
        return len(countryColouringList) == len(countryNRList)
    
    def checkIfNeighboursAreSameColour(self):
        for colour in self.__colouring:
            i = 0
            while i < len(colour):
                j = i+1
                while j < len(colour):
                    if self.__areNeighbours(colour[i], colour[j]): 
                        return False
                    j += 1
                i += 1
            
        return True

simple = [("da", "se"), ("no", "da"), ("se", "no"), ("de", "da")]
simpleTest = NeighbourRelation(simple)
simpleTest.makeColouring()
print(simpleTest)