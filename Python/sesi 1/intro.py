# Float
print("===Float===")
print(4.2)
print(type(4.2))
print(4.)
print(.2)
print(.4e7)
print(4.2e-4)

# Strings
print("===Strings===")
print("Hacktiv8")
print(type("Hacktiv8"))
print("This string contains a single quote (') character.")
print('This string contains a double quote (") character.')

# Boolean
# Python 3 provides a Boolean data type. Objects of Boolean type may have one of two values, True or False, PascalCase to declare true or false
print("===Python 3 provides a Boolean data type. Objects of Boolean type may have one of two values, True or False:")
print(type(True))
print(type(False))

# When you compare two values, the expression is evaluated and Python returns the Boolean answer:
print("===When you compare two values, the expression is evaluated and Python returns the Boolean answer:")
print(100 > 200) #False
print(100 == 200) #False
print(100 < 200) #True

# Variable Assignment
print("===Variable Assignment===")
n = 300
print(n)
# Chained Type assignment
print("===Chained Type assignment===")
a = b = c = 300
print(a, b, c)

# Variable Names, cant begin with number
print("===Variable Names===")
name = "Hacktiv8"
Age = 54
has_laptops = True
print(name, Age, has_laptops)

# Operators and Expressions
print("===Operators and Expressions===")
a = 10
b = 20
print(a + b)
print(a + b - 5)

# Arithmetic Operators
print("===Arithmetic Operators===")
a = 4
b = 3
print(a + b)
print(a - b)
print(a * b)
print(a / b)
print(a % b)
print(a ** b) # (**) means a pangkat b

# Comparison Operators
print("===Comparison Operators===")
a = 10
b = 20
print(a == b)
print(a != b)
print(a <= b)
print(a >= b)

# String Manipulation
print("===String Manipulation===")
s = 'foo'
t = 'bar'
# + and * Operators
print(s + t)
print(s * 4)
#Case Conversion
print(s.capitalize())
print(s.lower())
print(s.swapcase())