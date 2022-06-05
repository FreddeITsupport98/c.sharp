from math import *
from typing import FrozenSet

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

name2 = input("enter your name: ")
age1 = int(input("Your age: "))
print(name2, age1)

# Building a Basic Calculator

num1 = input("Enter a number: ")
num2 = input("Enter a second number: ")
result = float(num1) + float(num2) #float is decimal, int is whole number

print(" Your number is: ", result)

# Mad libs game

color = input("Enter a color: ")
plural_noun = input("Enter a naun: ")
celebrity = input("enter a celebrity: ")

print("Roses are " + color)
print("Violets are " + plural_noun)
print("I love " + celebrity)

# lists

friends = ["Jesper", "Simon", "kasper", "karen", "fredrik", "karin"]
friends[1] = "Super man!"
print(friends[0:2])

# lists funktion

lucky_Number = [1, 2, 4, 8, 16, 32, 64, 128]
friends_Second = ["Jesper", "Simon", "kasper", "karen", "fredrik", "karin"]
#friends_Second.extend(lucky_Number) # ökar lista med annan lista
#friends_Second.append("Creed") #bifogar lista
#friends_Second.insert(0, "Kelly") #begin insert index starting number
#friends_Second.remove("kasper")
#friends_Second.pop()
#friends_Second.sort() sorting out
#friends_Second.reverse() reversing list
# friends2 = friends_Second.copy copying list with same value as friends_second
print(friends_Second)

# Tuples