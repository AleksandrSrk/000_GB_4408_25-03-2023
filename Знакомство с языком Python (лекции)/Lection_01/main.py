# a = 5.34345
# b = 1.4353
# print(f"{a} * {b} = {a*b}")
# print(f"{a} * {b} = {round(a*b, 2)}") # Оставляем нужное количество знаков после запятой, указали что 2 знака

##############

# Сокращенное присваивание (то что в сишарпе было i++)

# iter = 2
# iter += 3 # iter = iter + 3
# iter -= 4 # iter = iter - 4
# iter *= 5 # iter = iter * 5
# iter /= 3 # iter = iter / 3
# iter //= 3 # iter = iter // 3
# iter %= 3 # iter = iter % 3
# iter **= 3 # iter = iter ** 3

# Строки

# a = "qwerty" # прошлись по всей строке и вывели буквы
# print(a[2])
# for i in a:
#     print(i)

# line = "" # пять раз выводит строку из пяти звездочек
# for i in range(5):
#     line = ""
#     for j in range(5):
#         line += "*"
#     print(line)

text = "СъеШЬ еще этих МягКих французских булок"

# print(len(text)) # считает количество символов
# print("еще" in text) # проверяет  есть ли "еще" в строке выводит True False
# print(text.lower()) # весь текст маленькими буквами
# print(text.upper()) # весь текст большими буквами
# print(text.replace("еще", "УЩУ")) # замена в тексте

# print(text[0]) # С
# print(text[1]) # ъ
# print(text[len(text) - 1]) # к
# print(text[-5]) # 6
# print(text[:]) # СъеШЬ еще этих МягКих французских булок
# print(text[:2]) # выводим элемент с нулевого по второй - съ
# print(text[len(text) -2:]) # ок
# print(text[2:9]) # ешь еще
# print(text[6:-18]) # еще этих мягких
# print(text[0:len(text):6]) # сеикакл - от нуля до конца строки с шагом 6
# print(text[::6]) # сеикакл - то же самое

# text = text[2:9] + text[-5] + text[:2] # еШЬ ещебСъ

