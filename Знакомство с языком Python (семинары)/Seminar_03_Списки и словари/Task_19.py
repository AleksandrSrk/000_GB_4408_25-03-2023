# Задача No19. Общее обсуждение
# Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на K элементов вправо, K – положительное число.
# Input: [1, 2, 3, 4, 5] k = 3 Output: [4, 5, 1, 2, 3]

import random

N = int(input("Введите размер последовательности: "))
K = int(input("Введите размер сдвига: "))

list_1 = [] # создал пустой список

for i in range (0, N):
    list_1.append(int(random.randint(0, 10))) # заполнил его случайными числами

print(list_1)

for i in range(0, K):
    list_1.insert(i, list_1[-1]) # добавил элемент в индекс I из конца списка
    list_1.pop(-1) # удалил элемент из конца списка

print(list_1)
