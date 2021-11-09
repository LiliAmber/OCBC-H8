import sys
import person
from person import name, devices, display

##With default import
print("\n\n> With default import")
print(person.name)
print(person.devices)
person.display('Good Morning !', 'putra')

##Alternate individual object
print("\n\n> Alternate individual object")
print(name)
print(devices)
display('Good Morning !', 'putri')

##Python Packages
print("\n\n> Python Package")
import pkg.mod1, pkg.mod2
print(pkg.mod1.kitchen_sets)
print(pkg.mod2.artist_kits)

##Package using individual object
print("\n> Package using individual object")
from pkg.mod1 import kitchen_sets
print(kitchen_sets)
##Package using alt name
print("\n> Package using alt name")
from pkg.mod1 import kitchen_sets as ks
print(ks)