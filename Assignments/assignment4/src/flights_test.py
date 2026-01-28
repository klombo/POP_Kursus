import flights

emptyList = []

# Test List where none of the conditions are meet meaning it should give zero for all the functions
generalTestList = [
    {'flight_id': '111', 'date': '2022-02-10', 'callsign': 'abc', 'adep': 'EGLL', 'name_adep': 'London Heathrow', 'country_code_adep': 'GB', 'ades': 'LFPG', 'name_ades': 'Paris', 'country_code_ades': 'FR', 'actual_offblock_time': '2022-02-10T10:00:00Z', 'arrival_time': '2022-02-10T12:00:00Z', 'aircraft_type': 'A320', 'wtc': 'M', 'airline': 'test', 'flight_duration': '120', 'taxiout_time': '15', 'flown_distance': '340', 'tow': '60000'}
]

# Two name_ades = Copenhagen
twoCopenhagenTestList = [
    {'flight_id': '248763780', 'date': '2022-01-01', 'callsign': '3840d84f25d3f5fcc0a1be3076bb4039', 'adep': 'EGLL', 'name_adep': 'London Heathrow', 'country_code_adep': 'GB', 'ades': 'EICK', 'name_ades': 'Copenhagen', 'country_code_ades': 'IE', 'actual_offblock_time': '2022-01-01T13:46:00Z', 'arrival_time': '2022-01-01T15:04:56Z', 'aircraft_type': 'A320', 'wtc': 'M', 'airline': 'test', 'flight_duration': '61', 'taxiout_time': '18', 'flown_distance': '321', 'tow': '54748'},
    {'flight_id': '248753824', 'date': '2022-04-01', 'callsign': '139670936660762c230ca92556ba842b', 'adep': 'ESSA', 'name_adep': 'Stockholm Arlanda', 'country_code_adep': 'SE', 'ades': 'KORD', 'name_ades': 'Copenhagen', 'country_code_ades': 'US', 'actual_offblock_time': '2022-01-01T09:39:00Z', 'arrival_time': '2022-01-01T19:08:13Z', 'aircraft_type': 'A333', 'wtc': 'H', 'airline': 'test', 'flight_duration': '554', 'taxiout_time': '15', 'flown_distance': '3770', 'tow': '230396'}
]

# Two name_ades = Ibiza and name_adep = Barcelona and name_adep = Madrid
ibizaDifferentAdepTestList = [
    {'flight_id': '301', 'date': '2022-06-01', 'callsign': 'ibz1', 'adep': 'MAD', 'name_adep': 'Madrid', 'country_code_adep': 'ES', 'ades': 'LEIB', 'name_ades': 'Ibiza', 'country_code_ades': 'ES', 'actual_offblock_time': '2022-06-01T08:00:00Z', 'arrival_time': '2022-06-01T09:10:00Z', 'aircraft_type': 'A320', 'wtc': 'M', 'airline': 'test', 'flight_duration': '70', 'taxiout_time': '10', 'flown_distance': '300', 'tow': '60000'},
    {'flight_id': '302', 'date': '2022-06-05', 'callsign': 'ibz2', 'adep': 'BCN', 'name_adep': 'Barcelona', 'country_code_adep': 'ES', 'ades': 'LEIB', 'name_ades': 'Ibiza', 'country_code_ades': 'ES', 'actual_offblock_time': '2022-06-05T11:00:00Z', 'arrival_time': '2022-06-05T12:15:00Z', 'aircraft_type': 'A320', 'wtc': 'M', 'airline': 'test', 'flight_duration': '75', 'taxiout_time': '12', 'flown_distance': '310', 'tow': '61000'}
]

# Two name_ades = Ibiza and Two name_adep = Madrid
ibizaDuplicateAdepTestList = [
    {'flight_id': '301', 'date': '2022-06-01', 'callsign': 'ibz1', 'adep': 'MAD', 'name_adep': 'Madrid', 'country_code_adep': 'ES', 'ades': 'LEIB', 'name_ades': 'Ibiza', 'country_code_ades': 'ES', 'actual_offblock_time': '2022-06-01T08:00:00Z', 'arrival_time': '2022-06-01T09:10:00Z', 'aircraft_type': 'A320', 'wtc': 'M', 'airline': 'test', 'flight_duration': '70', 'taxiout_time': '10', 'flown_distance': '300', 'tow': '60000'},
    {'flight_id': '302', 'date': '2022-06-05', 'callsign': 'ibz2', 'adep': 'BCN', 'name_adep': 'Madrid', 'country_code_adep': 'ES', 'ades': 'LEIB', 'name_ades': 'Ibiza', 'country_code_ades': 'ES', 'actual_offblock_time': '2022-06-05T11:00:00Z', 'arrival_time': '2022-06-05T12:15:00Z', 'aircraft_type': 'A320', 'wtc': 'M', 'airline': 'test', 'flight_duration': '75', 'taxiout_time': '12', 'flown_distance': '310', 'tow': '61000'}
]

# one flight in the middle of spring
springTestList = [
    {'flight_id': '402', 'date': '2022-04-15', 'callsign': 'spring', 'adep': 'AMS', 'name_adep': 'Amsterdam', 'country_code_adep': 'NL', 'ades': 'FCO', 'name_ades': 'Rome', 'country_code_ades': 'IT', 'actual_offblock_time': '2022-04-15T09:00:00Z', 'arrival_time': '2022-04-15T11:30:00Z', 'aircraft_type': 'A320', 'wtc': 'M', 'airline': 'test', 'flight_duration': '150', 'taxiout_time': '15', 'flown_distance': '800', 'tow': '65000'}
]

# two flights on each edge of spring
springEdgeTestList = [
    {'flight_id': '403', 'date': '2022-03-20', 'callsign': 'edge1', 'adep': 'OSL', 'name_adep': 'Oslo', 'country_code_adep': 'NO', 'ades': 'BER', 'name_ades': 'Berlin', 'country_code_ades': 'DE', 'actual_offblock_time': '2022-03-20T08:00:00Z', 'arrival_time': '2022-03-20T10:00:00Z', 'aircraft_type': 'A320', 'wtc': 'M', 'airline': 'test', 'flight_duration': '120', 'taxiout_time': '10', 'flown_distance': '500', 'tow': '62000'},
    {'flight_id': '404', 'date': '2022-06-21', 'callsign': 'edge2', 'adep': 'VIE', 'name_adep': 'Vienna', 'country_code_adep': 'AT', 'ades': 'ZRH', 'name_ades': 'Zurich', 'country_code_ades': 'CH', 'actual_offblock_time': '2022-06-21T14:00:00Z', 'arrival_time': '2022-06-21T15:30:00Z', 'aircraft_type': 'A320', 'wtc': 'M', 'airline': 'test', 'flight_duration': '90', 'taxiout_time': '10', 'flown_distance': '450', 'tow': '61000'}
]

def testFunction():
    assert flights.findFlightsLandingAtCopenhagen(emptyList)['Total'] == 0
    assert flights.findFlightsLandingAtCopenhagen(generalTestList)['Total'] == 0
    assert flights.findFlightsLandingAtCopenhagen(twoCopenhagenTestList)['Total'] == 2
    assert flights.findFlightsLandingAtCopenhagen(twoCopenhagenTestList)['01'] == 1
    assert flights.findFlightsLandingAtCopenhagen(twoCopenhagenTestList)['04'] == 1


    assert flights.findFlightsToIbiza(emptyList) == []
    assert flights.findFlightsToIbiza(generalTestList) == []
    assert flights.findFlightsToIbiza(ibizaDifferentAdepTestList) == ['Madrid','Barcelona']
    assert flights.findFlightsToIbiza(ibizaDuplicateAdepTestList) == ['Madrid']

    assert flights.findFlightsInSpring(emptyList) == 0
    assert flights.findFlightsInSpring(generalTestList) == 0
    assert flights.findFlightsInSpring(springTestList) == 1
    assert flights.findFlightsInSpring(springEdgeTestList)== 2

    print("All tests ran without Issue")

testFunction()