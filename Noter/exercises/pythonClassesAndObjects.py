# (a) Implement a class Student that has a property name. 
# When objects of the Student type are instantiated, the individual student's name must be specified as an argument to the default constructor (__init__). 
# Write a program that creates 2 Student objects and prints the name stored in each object (hint: define a __str__ method).

class Student:
    def __init__(self, name):
        self.__name = name
        self.__print_credit = 0
    
    def getPrintCredit(self):
        return self.__print_credit
    
    def setPrintCredit(self, newCredit):
        self.__print_credit = newCredit
        
    
    def __str__(self):
        return f'Student: {self.__name}, print Credit: {self.__print_credit}'

# Write a class Person with the properties for a person's name, address, and phone number. 
# How do you represent the name? Next, write a class called Customer, which is a subclass of the Person class. 
# The Customer class should have the properties customer number and a Boolean value for whether the customer wants to be on a mailing list. 
# Write a small program that creates an instance of the Customer class.

class Person:
    def __init__(self, name, adresse, phoneNumber):
        self.name = name
        self.adresse = adresse
        self.phoneNumber = phoneNumber
    

class Customer(Person):
    def __init__(self, name, adresse, phoneNumber, mail):
        super().__init__(name, adresse, phoneNumber)
        self.mail = mail
    
    def __str__(self):
        return f'Person: {self.name}, Adresse: {self.adresse}, tlf Nr: {self.phoneNumber}, mailing list: {self.mail}'

c1 = Customer('Klement', 'Hesseløgade 51', 51865654, False)
print(str(c1))