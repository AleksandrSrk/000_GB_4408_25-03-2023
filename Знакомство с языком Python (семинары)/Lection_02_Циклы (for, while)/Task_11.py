# Дано натуральное число A > 1. Определите, каким по счету числом Фибоначчи оно является, то есть выведите такое число n, что φ(n)=A. 
# Если А не является числом Фибоначчи, выведите число -1.
# Input: 5
# Output: 6

A = int(input("Введите искомое число: "))

f = False
oneNum = 0
twoNum = 1
i = 3

if A <= 1:
    print("Ввежите число больше 1")
else:
    while (f == False):
        if (A == oneNum or A == twoNum) and (oneNum <= A):
            f = True
        elif A <= oneNum:
            print("Число не является числом Фиббоначи")
            f = True
            i = -2
        oneNum = oneNum + twoNum
        twoNum = oneNum + twoNum
        i += 1
print(i)

#################### Решение преподавателя

n = int(input())
n0 = 0
n1 = 0
n2 = 1
i = 2 # Так как 2 первых числа уже известны это 0 и 1
while n0 < n:
    n0 = n1 + n2
    n1 = n2
    n2 = n0
    i += 1
    if n0 > n:
        i = 0
if i != 0:
    print(i)
else:
    print(-1)
