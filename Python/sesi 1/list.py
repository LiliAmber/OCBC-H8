# Python Lists === array javascript, mutable, akses menggunakan index
print("===Python Lists===")
primary_colors = ['Red', 'Green', 'Blue']
even_numbers = [2, 4, 6, 8]
event_a = ['Surabaya', 1300]
print(str(type(even_numbers)) +' '+ str(type(event_a)))
event_b = ['Manado', 1450]
events = [event_a, event_b]
print(events)

# Modifying & Access List Value
print("===Modifying & Access List Value===")
events = [
    primary_colors,
    even_numbers
]
print(events[0][1]) # Must be green
print(event_a[-1]) # Must be 1300
print(len(event_a))
print("A single value in a list can be replaced by indexing and simple assignment:")
a = ['foo', 'bar', 'baz', 'qux', 'quux', 'corge']
a[2] = 10
a[-1] = 20
print(a)

# Slice list
print("What if you want to change several contiguous elements in a list at one time? Python allows this with sliceassignment, which has the following syntax: \n print(nameFile[indexBegin:indexEnd]) \n indexBegin will include inseide the sliced list and indexEnd will exclude")
print(a[1:4])

# Modify using slice
a[1:4] = [1.1, 2.2, 3.3, 4.4, 5.5]
print(a)
