# Найдите сумму цифр трехзначного числа n.


n = int (input("Введите трехзначное число: "))
res = 0
while n !=0:
    res = res + (int(n%10))
    n = int (n/10)
print(res)