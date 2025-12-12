def read_to_list (file_path):
    with open(file_path, 'r') as file:
        lines = file.readlines()
    return [line.strip() for line in lines]

l = read_to_list("example.txt")
print(l)