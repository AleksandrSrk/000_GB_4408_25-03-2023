# Задача №5. Решение в группах
# Вагоны в электричке пронумерованы натуральными числами, начиная с 1 (при этом иногда вагоны нумеруются от «головы» поезда, а иногда – с
# «хвоста»; это зависит от того, в какую сторону едет электричка). В каждом вагоне написан его номер.
# Витя сел в i-й вагон от головы поезда и обнаружил, что его вагон имеет номер j. Он хочет определить, сколько всего вагонов в электричке. 
# Напишите программу, которая будет это делать или сообщать, что без дополнительной информации это сделать невозможно.
# Input: 3 4(ввод на разных строках)
# Output: 6

i_numberPlace = int (input("Введите номер вагона, в который сел Витя: "))
j_numberWagon = int (input("Введите номер вагона, в котором оказался Витя: "))
count = 0

if j_numberWagon == i_numberPlace:
    print("Без доп ниформации сделать невозможно")
else:
    while j_numberWagon != 1:
        j_numberWagon -= 1
        count +=1
    print(count + i_numberPlace)


