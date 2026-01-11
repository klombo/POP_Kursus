import flights
# Empty Test List
emptyList = [{}]

# Test List with no ['name_ades']: Copenhagen or Ibiza
generalTestList = [{'flight_id': '248763780', 'date': '2022-01-01', 'callsign': '3840d84f25d3f5fcc0a1be3076bb4039', 'adep': 'EGLL', 'name_adep': 'London Heathrow', 'country_code_adep': 'GB', 'ades': 'EICK', 'name_ades': 'Cork', 'country_code_ades': 'IE', 'actual_offblock_time': '2022-01-01T13:46:00Z', 'arrival_time': '2022-01-01T15:04:56Z', 'aircraft_type': 'A320', 'wtc': 'M', 'airline': 'a73f82288988b79be490c6322f4c32ed', 'flight_duration': '61', 'taxiout_time': '18', 'flown_distance': '321', 'tow': '54748'}, 
                    {'flight_id': '248760618', 'date': '2022-01-01', 'callsign': 'f6f610e73002b8892a239a81321f7f1d', 'adep': 'LEBL', 'name_adep': 'Barcelona', 'country_code_adep': 'ES', 'ades': 'KMIA', 'name_ades': 'Miami', 'country_code_ades': 'US', 'actual_offblock_time': '2022-01-01T09:55:00Z', 'arrival_time': '2022-01-01T19:37:56Z', 'aircraft_type': 'B772', 'wtc': 'H', 'airline': '5543e4dc327359ffaf5b9c0e6faaf0e1', 'flight_duration': '570', 'taxiout_time': '13', 'flown_distance': '4193', 'tow': '185441'}, 
                    {'flight_id': '248753824', 'date': '2022-01-01', 'callsign': '139670936660762c230ca92556ba842b', 'adep': 'ESSA', 'name_adep': 'Stockholm Arlanda', 'country_code_adep': 'SE', 'ades': 'KORD', 'name_ades': "Chicago O'Hare", 'country_code_ades': 'US', 'actual_offblock_time': '2022-01-01T09:39:00Z', 'arrival_time': '2022-01-01T19:08:13Z', 'aircraft_type': 'A333', 'wtc': 'H', 'airline': '8be5c854fd664bcb97fb543339f74770', 'flight_duration': '554', 'taxiout_time': '15', 'flown_distance': '3770', 'tow': '230396'}]
# Test List with 2 ['name_ades']: Copenhagen 
copenhagenTestList = [{'flight_id': '248763780', 'date': '2022-01-01', 'callsign': '3840d84f25d3f5fcc0a1be3076bb4039', 'adep': 'EGLL', 'name_adep': 'London Heathrow', 'country_code_adep': 'GB', 'ades': 'EICK', 'name_ades': 'Copenhagen', 'country_code_ades': 'IE', 'actual_offblock_time': '2022-01-01T13:46:00Z', 'arrival_time': '2022-01-01T15:04:56Z', 'aircraft_type': 'A320', 'wtc': 'M', 'airline': 'a73f82288988b79be490c6322f4c32ed', 'flight_duration': '61', 'taxiout_time': '18', 'flown_distance': '321', 'tow': '54748'}, 
                    {'flight_id': '248760618', 'date': '2022-01-01', 'callsign': 'f6f610e73002b8892a239a81321f7f1d', 'adep': 'LEBL', 'name_adep': 'Barcelona', 'country_code_adep': 'ES', 'ades': 'KMIA', 'name_ades': 'Miami', 'country_code_ades': 'US', 'actual_offblock_time': '2022-01-01T09:55:00Z', 'arrival_time': '2022-01-01T19:37:56Z', 'aircraft_type': 'B772', 'wtc': 'H', 'airline': '5543e4dc327359ffaf5b9c0e6faaf0e1', 'flight_duration': '570', 'taxiout_time': '13', 'flown_distance': '4193', 'tow': '185441'}, 
                    {'flight_id': '248753824', 'date': '2022-04-01', 'callsign': '139670936660762c230ca92556ba842b', 'adep': 'ESSA', 'name_adep': 'Stockholm Arlanda', 'country_code_adep': 'SE', 'ades': 'KORD', 'name_ades': "Copenhagen", 'country_code_ades': 'US', 'actual_offblock_time': '2022-01-01T09:39:00Z', 'arrival_time': '2022-01-01T19:08:13Z', 'aircraft_type': 'A333', 'wtc': 'H', 'airline': '8be5c854fd664bcb97fb543339f74770', 'flight_duration': '554', 'taxiout_time': '15', 'flown_distance': '3770', 'tow': '230396'}]
# Test List


# - what was the total number of flights landing in Copenhagen per month?
# - from which cities departed flights to Ibiza?
# - how many flights flew in Spring 2022 (March 20ty - June 21st both included)

# !!! GENERAL TESTS !!!
# - Test empty flightList list with dict

# !!! Destination Copenhagen !!!
# - Test for empty flightList
# - Tests with small dataset
# - Test with no Copenhagen == 0
# - Test with 2 Copenhagen in different months 

# !!! Flights to Ibiza !!!
# - Test for empty flightList
# - Tests for small dataset
# - Test with no Ibiza
# - Test with 2 ibiza and Test with different 'name_adep'
# - Test with 2 ibiza and Test with duplicate 'name_adep'
# - Test with 'name_ades' og 'name_adep' both Ibiza

# !!! Flights in Spring !!!
# - Test for empty flightList
# - Tests for small dataset
# - Test with no flight in Spring/wrong dates
# - Test a normal Date
# - Test edges

def testFunction():
    assert flights.generateFlightsList([]) == [{}], 'FAILED, generateFlightList run with empty List'
    
    assert flights.findFlightsLandingAtCopenhagen(emptyList) == 0, 'FAILED, findFlightsLandingAtCopenhagen run with a empty List'
    assert flights.findFlightsLandingAtCopenhagen(noCopenhagenTestList) == 0, 'FAILED, findFlightsLandingAtCopenhagen run with no Copenhagen list'
    assert flights.findFlightsLandingAtCopenhagen(copenhagenTestList)['Total'] == 2, 'FAILED, findFlightsLandingAtCopenhagen run with flight with 2 Copenhagens.'
    
    assert flights.findFlightsToIbiza(emptyList) == 0, 'FAILED, findFlightsToIbiza run with a empty List'
    assert flights.findFlightsToIbiza()

testFunction()