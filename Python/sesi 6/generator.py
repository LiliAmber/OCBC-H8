# lazy evaluation = kalo nggak ada request nggak akan return value

# generator functions
def my_generator():
  print("Inside my generator")
  yield 'a'
  yield 'b'
  yield 'c'

# print('===print generator with list===')
# print(list(my_generator()))

# generator expressions
x = my_generator()

# lazy iterator nya disini, kalo pake next() di return valuenya 1 per satu
print(next(x))

# print('===print generator with for loop===')
# for char in my_generator():
#   print(char)

def counter_generator(low, high):
    while low <= high:
       yield low
       low += 1

# for i in counter_generator(5,10):
#   print(i, end=' ')

obj_gen = counter_generator(5,10)
print(next(obj_gen))

'''
yield mirip dengan return, tapi nggak terminate/berhentiin program

low, high --> yield
5,   10   --> 5
6,   10   --> 6
7,   10   --> 7
8,   10   --> 8
9,   10   --> 9
10,  10   --> 10
11 do not pass while condition
'''

# ===FIRST CLASS OBJECT===
# In Python, functions are first-class objects. This means that functions can be passed around and used as arguments, just like any other object (string, int, float, list, and so on). Consider the following three functions:

def say_hello(name):
    return f"Hello {name}"

def be_awesome(name):
    return f"Yo {name}, together we are the awesomest!"

def weather_talk(name):
    return f"the weather is nice, {name}."

def greet_bob(greeter_func):
    return greeter_func("Bob")

print(greet_bob(say_hello))
print(greet_bob(be_awesome))
print(greet_bob(weather_talk))

# ===Inner Functions==
def parent():
    print("Printing from the parent() function")

    def first_child():
        print("Printing from the first_child() function")

    def second_child():
        print("Printing from the second_child() function")

# print(parent())

# Returning Functions From Functions
# Python also allows you to use functions as return values. The following example returns one of the inner functions from the outer parent() function:

def parent(num):
    def first_child():
        return "Hi, I am Emma"

    def second_child():
        return "Call me Liam"

    if num == 1:
        return first_child
    else:
        return second_child

first = parent(4)
# print(first())
