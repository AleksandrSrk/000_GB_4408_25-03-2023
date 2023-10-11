# Задача №7. Решение в группах
# Дано натуральное число. Требуется определить, является ли год с данным номером високосным. Если год является високосным, то выведите YES, иначе
# выведите NO. Напомним, что в соответствии с григорианским календарем, год является високосным, если его номер кратен 4, но не кратен
# 100, а также если он кратен 400. Input: 2016
# Output: YES

numberYear = int (input("Введите номер года: "))

if ((numberYear%4 == 0) and (numberYear%100 !=0)) or (numberYear%400 == 0):
    print("YES")
else: 
    print("NO")

print(numberYear%4, numberYear%100, numberYear%400)
    
    
