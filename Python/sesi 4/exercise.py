
def main_function():
    '''
    This is the main function to process input from user
    '''
    convention = input("enter the convention you like to convert\n (e.g f for Fahrenheit, c for celsius, k for kelvin): ")
    print(convention)

    if convention == 'c':
        celcius_converter()
    elif convention == 'f':
        fahrenheit_converter()
    elif convention == 'k':
        kelvin_converter()

# Celsius to Fahrenheit & Kelvin
def celcius_converter():
    # Reading temperature in Celsius
    celsius = int(input('Enter temperature in celcius: '))
    # Converting
    fahrenheit = 1.8 * celsius + 32
    kelvin = 273.15 + celsius
    # Displaying output
    print('%0.3f Celsius = %0.3f Fahrenheit.' % (celsius, fahrenheit))
    print('%0.3f Celsius = %0.3f Kelvin.' % (celsius, kelvin))

# Fahrenheit to Celsius and Kelvin
def fahrenheit_converter():
    # Reading temperature in Fahrenheit
    fahrenheit = int(input('Enter temperature in fahrenheit: '))
    # Converting
    celsius = (fahrenheit - 32) * 5/9
    kelvin = (fahrenheit + 459.67) * 5/9
    # Displaying output
    print('%0.3f Fahrenheit = %0.3f Celsius.' % (fahrenheit, celsius))
    print('%0.3f Fahrenheit = %0.3f Kelvin.' % (fahrenheit, kelvin))

# Kelvin to Fahrenheit and Celsius
def kelvin_converter():
    # Reading temperature in Kelvin
    kelvin = int(input('Enter temperature in kelvin: '))
    #Converting
    celsius = kelvin - 273.15
    fahrenheit = (kelvin * 9/5) - 459.67
    # Displaying output
    print('%0.3f Kelvin = %0.3f Celsius.' % (kelvin, celsius))
    print('%0.3f Kelvin = %0.3f Fahrenheit.' % (kelvin, fahrenheit))

main_function()
