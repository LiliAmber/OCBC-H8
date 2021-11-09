with open("test.txt", 'w', encoding = 'utf-8') as f:   
    f.write("my first file\n")   
    f.write("This file\n\n")   
    f.write("contains three lines\n")


f = open("test.txt",'r',encoding = 'utf-8')
data = f.read(4)    # read the first 4 data'This'>>> 
f.read(4)    # read the next 4 data' is '>>> 
data1 = f.read()     # read in the rest till end of file'my first file\nThis file\ncontains three lines\n'>>> 
f.read()  # further reading returns empty string‘’

print(data)
print(data1)
print('=====')

with open('test.txt', 'r') as reader:
     # Read & print the entire file
     print(reader.read())

# x = 10
# if x > 5:
#     raise Exception('x should not exceed 5. The value of x was: {}'.format(x))

print('====')

# import sys
# print(sys.platform)
# assert ('linux' in sys.platform), "This code runs on Linux only."
# assert ('windows' in sys.platform), "This code runs on Windows only."
# assert ('darwin' in sys.platform), "This code runs on Windows2 only."

# coins = 10 -> ideal condition
# coin = 8

# def check_coins(coin):
#     assert(coin == 10), 'some coins fell down on the way'

# try:
#     check_coins(coin)
# except:
#     raise Exception('some message coins fell here---')

import sys
print(sys.platform)
def os_interaction():
    # assert ('linux' in sys.platform), "Function can only run on Linux systems."
    assert ('darwin' in sys.platform), "Function can only run on macos systems."
    assert ('windows' in sys.platform), "This code runs on Windows only."
    print('Doing something.')
    '''
    contoh docstring
    '''

try:
    os_interaction()
    print('masuk try block')
except:
    print('masuk except blok')
    pass

try:
    os_interaction()
except AssertionError as error:
    print(error)
    print('The os_interaction() function was not executed')

# try:
#     os_interaction()
# except AssertionError as error:
#     print(error)
# else:
#     print('Executing the else clause.')

# using else
try:
    with open('test.txt') as file:
        read_data = file.read()
    print(read_data)
except FileNotFoundError as error:
    print(error)
    print('%#')
else:
    print('execute else clause')
    # print('harus ditampilkan')
    n = 10
    print(n)

try:
    os_interaction()
except AssertionError as error:
    print(error)
else:
    try:
        with open('file.log') as file:
            read_data = file.read()
    except FileNotFoundError as fnf_error:
        print(fnf_error)

# using finally
try:
    os_interaction()
except AssertionError as error:
    print(error)
else:
    try:
        with open('file.log') as file:
            read_data = file.read()
    except FileNotFoundError as fnf_error:
        print(fnf_error)
finally:
    print('Cleaning up, irrespective of any exceptions.')

# print(dir())
print(os_interaction.__doc__)

