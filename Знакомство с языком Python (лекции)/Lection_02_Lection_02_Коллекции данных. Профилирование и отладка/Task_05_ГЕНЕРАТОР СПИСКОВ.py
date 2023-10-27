# LIST COMPREHENSION - ГЕНЕРАТОР СПИСКОВ


# list_1 = [exp for item in iterable] # мы идем по коллекции данных iterable и добавляем значение exp
# list_2 = [NON for item in range(5)] # 5 раз добавили в список значение NON

# # выборка по заданному условию

# list_3 = [exp for item in iterable(if conditional)]

# Создать список чисел от 1 до 100: 

list_1 = []
for i in range(1, 101):
    list_1.append(i)
print(list_1) # [1,2,3...,100]

# Так же можно записать так: 

list_2 = [i for i in range(1 , 101)]
print(list_2)  # [1,2,3...,100]

# Хотим добавлять только четные числа: 

list_3 = [i for i in range(1 , 101) if i%2 == 0]
print(list_3)  # [2, 4, 6, 8...,100]

# Хотим создать пары каждому из чисел (кортежи): 

list_4 = [(i , i) for i in range(1 , 101) if i%2 == 0]
print(list_4)  # [(2, 2), (4, 4), (6, 6), (8, 8) ...

# Также можно умножать делить прибавлять вычитать. Например умножим значение на 2: 

list_5 = [i * 2 for i in range(1 , 101) if i%2 == 0]
print(list_5)  # [4, 8, 12, 16, 20, 24, 28, 32, ...