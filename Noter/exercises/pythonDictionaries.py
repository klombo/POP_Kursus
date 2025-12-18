import datetime

# create a dictionary that associates 5 danish cities with their number of inhabitants
byer = {
    'Klemensker': 599,
    'Aakirkeby': 2092,
    'Roskilde': 53354,
    'Odense': 210803,
    'København': 667099 
}

# create a dictionary that represents a person (name, age, address)
personer = {
    'Klement': {'age': 20, 'adresse': 'Hesseløgade 51 4th'},
    'Nikolaj': {'age': 21, 'adresse': 'Ringparken 4'}
}

# create a dictionary that represents hourly prices for electricity (float between 0 and 5)

nu = datetime.datetime.now()
# 2025-12-16 10

prices = {
    '11': 1.0,
}

timeNu = nu.strftime('%I')

print(prices[timeNu])

