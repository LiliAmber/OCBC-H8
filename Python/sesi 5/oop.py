# person without class

# raka = [
#     [0]"Raka Ardhi", 
#     [1]28,
#     [2]"CurDev", 
#     [3] 2265
# ]
# spock = [
#     [0]"Spock", 
#     [1]35, 
#     [2]"Science Officer", 
#     [3] 2254
# ]
# mccoy = [
#     [0]"Leonard McCoy", 
#     [1]"Chief Medical Officer", 
#     [2] 2266
#     [3]
# ]

# class Dog:
#     pass

# mendefinisikan class, pascalCase
class Dog():
    # class attribute
    species = 'Canis familiaris'
    # wajib menyertakan self di dalam init
    def __init__(self, name, age):
        # instance attribute
        self.name = name
        self.age = age
    
    # instance method, self is mandatory untuk instance method, sama dengan def __init__, kalo mau dipanggil harus diinvoke --> namaMethod()
    def descfription(self):
        return f'{self.name} is  {self.age} years old'
    
    def speak(self, sound):
        '''
        alternate to print something:

        return '{} says {}'.format(self.name, sound)

        return '{0_name} says {o_sound}'.format(o_sound = sound, o_name = self.name)

        return f'{self.name} says {sound}'
        '''
        return f'{self.name} says {sound}'
    


# instanciate/ obj instance dri class
# miles = Dog('Miles', 4)
# buddy = Dog('Buddy', 9)

# print(miles.name)
# print(miles.age)
# print(miles.species)
# print(miles.descfription())
# print(miles.speak('woof wooff'))
# print(isinstance(miles, Dog))
# print(dir(Dog))
# print(buddy.name)
# print(buddy.age)

# ===inheritance from other classes in python==

# parent
class Mom():
    def __init__(self, name, hair_color):
        self.name = name
        self.hair_color = hair_color

# child
class Children(Mom):
    # pass
    def __init__(self, name, hair_color, age):
        super().__init__(name, hair_color)
        self.age = age
        

mom = Mom('ani', 'cokelat')
print(f"{mom.name}'s hair color is {mom.hair_color}")

first_daughter = Children('ina', 'ungu', 22)
print(f"{first_daughter.name}'s hair color is {first_daughter.hair_color} and she is {first_daughter.age} years old")

class Dog1:
    species = "Canis familiaris"

    def __init__(self, name, age):
        self.name = name
        self.age = age

    def __str__(self):
        return f"{self.name} is {self.age} years old"

    def speak(self, sound):
        return f"{self.name} says {sound}"


class JackRussellTerrier(Dog1):
    def speak(self, sound="Arf"):
        return f"{self.name} says {sound}"
    # pass

class Dachshund(Dog1):
    pass

class Bulldog(Dog1):
    pass

jack = Bulldog("Jack", 3)
print(jack)

# Extend the Functionality of a Parent Class
miles = JackRussellTerrier("Miles", 4)
print(miles.speak())
print(miles.speak("Grrr"))