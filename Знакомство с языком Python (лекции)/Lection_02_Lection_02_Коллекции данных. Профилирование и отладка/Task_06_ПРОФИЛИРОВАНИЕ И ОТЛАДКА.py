### СИНТАКСИЧЕСКАЯ ОШИБКА expected: 

# num_1 = 5
# num_2 = 7

# if num_1 > num_2 # НЕТ ДВОЕТОЧИЯ :
#     print(num_1)

### ОШИБКА ОТСТУПОВ IndentationError: 

# num_1 = 5
# num_2 = 7

# if num_1 > num_2:
# print(num_1) # НЕТ ОТСТУПА

### ТИПОВАЯ ОШИБКА TypeError: 

# text = "python"
# number = 5
# print(text + number) # НЕЛЬЗЯ СКЛАДЫВАТЬ СТРОКИ И ЧИСЛА

### ДЕЛЕНИЕ НА НОЛЬ ZeroDivisionError: 

# num_1 = 5
# num_2 = 0
# print(num_1 // num_2) # делить на ноль нельзя

### ОШИБКА КЛЮЧА KeyError:

# dictionary = {1: 'Monday', 2: 'Tuesday'}
# print(dictionary[3]) # Такого ключа не существует

### ОШИБКА ИМЕНИ ПЕРЕМЕННОЙ NameError:

# name = 'Ivan'
# print(names) # такой переменной не существует

### ОШИБКА значения ValueError:

# text = "python"
# print(int(text)) # Нельзя символы перевести в целые значения
