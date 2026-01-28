import time
# ['flight_id', 'date', 'callsign', 
# 'adep', 'name_adep', 'country_code_adep', 
# 'ades', 'name_ades', 'country_code_ades', 
# 'actual_offblock_time', 'arrival_time', 
# 'aircraft_type', 'wtc', 'airline', 'flight_duration', 
# 'taxiout_time', 'flown_distance', 'tow']
def read_to_list (file_path):
    with open(file_path, 'r') as file:
        lines = file.readlines()
    return [line.strip() for line in lines]

def generateFlightsList(file_path):
    lines = [line.split(',') for line in read_to_list(file_path)]
    flightList = []
    if lines == []: return [{}]
    keys = lines[0]
    for line in lines[1:]:
        emptyDict = {}
        for key in range(0,len(keys)):
            emptyDict[keys[key]] = line[key]
        flightList.append(emptyDict)
    return flightList

def findFlightsLandingAtCopenhagen(flightList):
    flightByMonth = {'Total': 0}
    for flight in flightList:
        if flight['name_ades'] == 'Copenhagen':
            flightByMonth['Total'] += 1
            dates = flight['date'].split('-')
            month = dates[1]
            if (month in flightByMonth):
                flightByMonth[month] += 1
            else: flightByMonth[month] = 1
    return flightByMonth

def findFlightsToIbiza(flightList):
    departuresToIbiza = []
    for flight in flightList:
        if flight['name_ades'] == 'Ibiza':
            if not flight['name_adep'] in departuresToIbiza:
                departuresToIbiza.append(flight['name_adep'])
    return departuresToIbiza

def findFlightsInSpring(flightList):
    numberOfFlights = 0
    for flight in flightList:
        date = flight['date'].split('-')
        day = int(date[2])
        month = int(date[1])    
        if month == 4 or month == 5: 
            numberOfFlights += 1
        elif month == 3 and day >= 20: 
            numberOfFlights += 1
        elif month == 6 and day <= 21: 
            numberOfFlights += 1   
    return numberOfFlights
                        
flightList = generateFlightsList("flight_list.csv")

# startTime2 = time.time()
# print(f'Flights landing at Copenhagen: {findFlightsLandingAtCopenhagen(flightList)} ')
# endTime2 = time.time()
# timeToRun2 = endTime2 - startTime2
# print(f'Time to find the flights landing at Copenhagen: {timeToRun2}')

# startTime2 = time.time()
# print(f'\n Places that to Ibiza: {findFlightsToIbiza(flightList)}')
# print(f'Amount of airports that fly to Ibiza: {len(findFlightsToIbiza(flightList))}')
# endTime2 = time.time()
# timeToRun2 = endTime2 - startTime2
# print(f'Time to find the places that fly to Ibiza: {timeToRun2}')

# startTime3 = time.time()
# print(f'\n Flights in Spring: {findFlightsInSpring(flightList)}')
# endTime3 = time.time()
# timeToRun3 = endTime3 - startTime3
# print(f'Time to find flights in spring: {timeToRun3}')
