# СЛОВАРИ - неупорядоченные коллекции произхвольных объектов с доступом по ключу
# В списках в качестве ключа используется индек, а в словаре значение

dictionary = {} # создали пустой словарь // dictionary = dict() - аналогично создали пустой словарь

dictionary = {'up': '↑', 'left': '←', 'down': '↓', 'right': '→'}
print(dictionary) # {'up': '↑', 'left': '←', 'down': '↓', 'right': '→'}
print(dictionary['left']) # ←
print(dictionary['up']) # ↑
dictionary['left'] = '⇐' # в ключ 'left' мы положили значение '⇐'
print(dictionary['left']) # ⇐
# print(dictionary['type']) # KeyError: 'type' - так как ключа type не существует

del dictionary['left'] # Удаление элемента
print(dictionary) # {'up': '↑', 'down': '↓', 'right': '→'}

dictionary[895] = 1234 # создали ключ 895 и в него положили значение 1234, добавился в конец
print(dictionary) # {'up': '↑', 'down': '↓', 'right': '→', 895: 1234}

print("1___________")

# ВЫВОД значений словаря: 
for item in dictionary:
    print(item) # up // down // right // 895

print("2___________")

# ВЫВОД ключа и значений словаря: 
for item in dictionary:
    print('{}: {}'.format(item, dictionary[item])) # up: ↑ // down: ↓ // right: → // 895: 1234

print("3___________")

for (k, v) in dictionary.items(): # проходим по списку из кортежей, где k - это наш ключ, а v - значение
    print(k, v) # up ↑ // down ↓ // right → // 895 1234

print("4___________")

print(dictionary.items()) # dict_items([('up', '↑'), ('down', '↓'), ('right', '→'), (895, 1234)]) - выводится список, внутри которого каждый элемент это КОРТЕЖ из двух значений

