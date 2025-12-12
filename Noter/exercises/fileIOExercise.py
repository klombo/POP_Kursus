def read_to_list (file_path):
    with open(file_path, 'r') as file:
        lines = file.readlines()
    return [line.strip() for line in lines]

l = read_to_list("example.txt")

col1 = [line.split()[0] for line in l]
col2 = [line.split()[1] for line in l]

print(col1, col2)