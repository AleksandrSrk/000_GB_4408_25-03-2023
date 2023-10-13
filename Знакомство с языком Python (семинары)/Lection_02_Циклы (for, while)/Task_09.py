# По данному целому неотрицательному n вычислите значение n!. N! = 1 * 2 * 3 * … * N (произведение всех чисел от 1 до N) 0! = 1 
# Решить задачу используя цикл while
# Input: 5
# Output: 120


try:
       
    number = int(input("Введите целое неотрицательное число: "))
    count = int(1)
    if number < 0:
        print("Нужно ввести число больше нуля")
    else:
        while number !=0:
            count = count * number
            number -= 1
        print(count)
except:
    print("Нужно ввести целое неотрицательное число")