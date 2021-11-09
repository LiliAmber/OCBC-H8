# function pada python menggunakan keyword 'def'

# deafult argument, jdi kalo arg age nggak diinput maka akan memiliki value default 17
def get_personal_info(name, age=17):
    # print(name, age)
    print('name: ', name)
    print('age: ', age)
    pass

# required arg(positional order) -> posisi menentukan
get_personal_info('budi', 22)
get_personal_info('ani', 25)

# keyword argument
get_personal_info(age=17, name='putra')
get_personal_info(name='putri', age=18)

# eggs, wheat, flour, choclate bar
# roy buy 1 item: chocolatebar
# tia buy 4 items: eggs, wheat, flour, chocolate bar

# variable length-non-keyword
def buy(customer_name, *items):
    print(customer_name)
    print(items)
    pass

buy('roy', 'chocolate bar')
buy('tia', 'eggs', 'wheat', 'flour', 'choclate bar')

# Create a function with nonkeyword variables

def person_car(total_data, **kwargs):
  '''Create a function to print who owns what car'''
  print('Total Data : ', total_data)
  for key, value in kwargs.items():
    print('Person : ', key)
    print('Car    : ', value)
    print('')

person_car(3, jimmy='chevrolet', frank='ford', tina='honda')
person_car(3)

# Parameters (jimmy='chevrolet', frank='ford', tina='honda') will be equal to
# kwargs = {
#     'jimmy': 'chevrolet',
#     'frank': 'ford',
#     'tina': 'honda'
# }

# LAMBDA
def sum(num1, num2):
    return num1 + num2

hasil = lambda num1, num2: num1 + num2

# Declare a global variable
total = 0

# Create sum function
def sum( arg1, arg2 ):
   total = arg1 + arg2; 
   print("Inside the function local total   : ", total)
   return total

# Call a function
print("Outside the function global total - before : ", total)
total = sum( 10, 20 )
print("Outside the function global total - after  : ", total)


def sum_number(num1, num2):
  '''
  This function is used to sum of 2 variables.
  :param num1: Input number 1 | int or float
  :param num2: Input number 2 | int or float
  
  :return: num3: Sum of number | int or float
  '''

  num3 = num1 + num2
  return num3

print(sum_number.__doc__)