
fruits = ["apple", "banana", "cherry"]

for fruit in fruits:
  print(fruit)
  

numbers = [1, 2, 3, 5, 6]

for number in numbers:
  print(number)
  
  
count = 1

while count <= 5:
  print(count)
  count += 1




fruitss = ["apple", "banana", "cherry", "date"] 

for fruits in fruitss:
  if fruits == "cherry":
    break
  print(fruits)
  
print()

for fruits in fruitss:
  if fruits == "cherry":
    continue
  print(fruits)