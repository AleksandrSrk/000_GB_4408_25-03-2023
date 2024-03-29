# # Список - упорядоченный конечный набор элементов. Тот же самый массив. Хранил любые типы данных

# list_1 = [] # создание пустого списка
# list_2 = list() # создание пустого списка
# list_1 = [7, 9, 11, 13, 15, 17] # 
# print(list_1[0]) # 7 - печатает нулевой элемент 
# print(list_1) # [7, 9, 11, 13, 15, 17] печатает список со скобочками,
# print(*list_1) # 7 9 11 13 15 17 - печатает без скобочек, через знак * мы открыли список и вывели все из него

# # for i in list_1:
# #     print(i) # переменная i поочередно принимает на себя значение из списка и выводит его

# print(len(list_1)) # выводит длину списка
# print(list_1[-1]) # 17
# print(list_1[-2]) # 15

# list_1.append(8) # [7, 9, 11, 13, 15, 17, 8] - append добавляет в конец списка заданный элемент
# print(list_1)

###############################
# append добавляет в конец списка заданный элемент

# list_1 = [] # создание пустого списка
# for i in range(5):
#     list_1.append(i)
# print(list_1) # [0, 1, 2, 3, 4]

###############################
# .pop - удаляет ПОСЛЕДНИЙ элемент из списка

# list_1 = [7, 9, 11, 13, 15, 17]

# print(list_1.pop()) # 17
# print(list_1) # [7, 9, 11, 13, 15]
# print(list_1.pop()) # 15
# print(list_1) # [7, 9, 11, 13] и тд

###############################
# .pop(индекс) - удаляет ЗАДАННЫЙ элемент из списка

# list_1 = [7, 9, 11, 13, 15, 17]
# print(list_1.pop(0)) # 7
# print(list_1) # [9, 11, 13, 15, 17]

###############################
# .insert(индекс, элемент) - добавляет указанный элемент в указанный индекс

# list_1 = [7, 9, 11, 13, 15, 17]
# print(list_1.insert(123, 111))  # None
# print(list_1) # [7, 9, 11, 13, 15, 17, 111] индекса 123 нет, добавил вконце
# print(list_1.insert(1, 111))  # None
# print(list_1) # [7, 111, 9, 11, 13, 15, 17, 111] добавил 111 в индекс 1

###############################
# печать среза списка
# : - если перед двоеточием ничего - начинаем сначала списка, если после ничего - заканчиваем на конце списка

list_1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
print(list_1[0]) # 1
print(list_1[1]) # 2
print(list_1[len(list_1) - 1]) # 10
print(list_1[-5]) # 6
print(list_1[:]) # [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
print(list_1[:2]) # [1, 2] - начинаем сначала и выводим до второго индекса
print(list_1[len(list_1) - 2:]) # [9, 10] - выводим от (размер списка минус 2) до конца
print(list_1[2:9]) # [3, 4, 5, 6, 7, 8, 9]
print(list_1[6:-18]) # []
print(list_1[0:len(list_1):6]) # [1, 7] - идем с начала до конца с шагом 6
print(list_1[::6]) # [1, 7]

