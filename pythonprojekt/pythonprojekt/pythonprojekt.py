from math import *

print("hello world")
print(">")
print(" >")
print("  >")

#Variables & Data Types

name = "Jhon"
age = "90"

print(" there was once man named " + name)
print(" he was " + age + " yrear old ")

name = "mike"
print(" he really liked the name " + name)
print(" but didnt like being " + age + " old ")

# working with strings
phrase = "girrafe, lol"
print(len(phrase))
print(phrase.replace("lol", "okej"))
print(phrase[0])
print(phrase.index("r"))
print(phrase.lower().islower()) #.lower() lower all cases and.upper maximises cases

# Working With Numbers

min_siffra = 50
print(6 + 6, "LOL")
print(50 % 5)
print(str(min_siffra) + " min favo siffra ")
print(abs(min_siffra))
print(pow(9, 2))
print(max(4, 9))
print(min(1,5))
print(round(5.4568))
print(floor(3.7))
print(ceil(3.7))
print(sqrt(99))

# Getting Input From Users

name = input("enter your name: ")
age1 = input("Your age: ")
print(name + age)

# Building a Basic Calculator