import colouring

def runNeighbourTests(neighbourLists):
    for name, neighbourList in neighbourLists:
        test = colouring.NeighbourRelation(neighbourList)
        test.makeColouring()

        print(f"\nTest: {name}")
        print(test)
        print("All of the countries are present:", test.checkAmountOfUniqueCountries())
        print("No Neighbours are same Colour:", test.checkIfNeighboursAreSameColour())


# All test cases in one list
neighbourLists = [
    ("Simple List", [("da", "se"), ("no", "da"), ("se", "no"), ("de", "da")]),
    ("Empty List", []),
    ("All Neighbours List", [("da","se"), ("no","da"), ("se","no")]),
    ("Neighbour Pairs List", [("nl","de"),("br","ar"),("cn","vn")]),
    ("No Neighbours List", [("nl",'00'),("00",'br'),("cn",'00')])
]

runNeighbourTests(neighbourLists)