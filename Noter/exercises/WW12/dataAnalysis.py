def read_to_list (file_path):
    with open(file_path, 'r') as file:
        lines = file.readlines()
    return [line.strip() for line in lines]
l = read_to_list("nordpool_prices_last_2_weeks.csv")
llist = [e.split(',') for e in l]

# How do you choose to represent the price of electricity? 
# Describe three possible data structures (using Python) that you could use and explain which one you choose.

# floats, tuples, dictionary

#res = {f"{ele[0] + ele[1]}": [ele[1:]] for ele in llist}
#keyList = [f"{ele[0]+ele[1]}" for ele in llist]
#print(keyList)


        
def splitByDate(lines):
    res = {}
    for line in lines:
        date = line[0]
        if date not in res.keys():
            res[date] = []
        res[date].append(line)
    return list(res.values())

print(splitByDate(llist))
#print(llist)