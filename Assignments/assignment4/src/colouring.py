class NeighbourRelation:
    def __init__(self, nr):
        self.__nr = nr
        self.__nodes = [] # Added a loop so every country is present in the nodes list only once.
        for neighbourPair in nr:
            for country in neighbourPair:
                if country not in self.__nodes: self.__nodes.append(country)
        self.__colouring = []

    def __areNeighbours(self, c1, c2):
        if (c1, c2) in self.__nr or (c2,c1) in self.__nr: return True # Changed so that we check (c1,c2) and (c2,c1) are both checked instead of (c1)
        else: return False

    def __canExtendColour(self, country, colour):
        for c in colour:
            if self.__areNeighbours(c, country):
                return False
        return True

    def __extendColouring(self, country, colouring):
        if colouring == []: return [[country]] # Changed from returning [[]] to returning [[country]]
        else: 
            colour = colouring[0]
            if self.__canExtendColour(country, colour):
                # Beware!:  side effect
                colouring[0].append(country)
                return colouring
            else:
                return [colour] + self.__extendColouring(country, colouring[1:]) # Changed from :1 to 1: 

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
                    if ((colour[i], colour[j]) in self.__nr) or ((colour[j], colour[i]) in self.__nr): 
                        return False
                    j += 1
                i += 1
            
        return True