# 15. Иван Васильевич пришел на рынок и решил купить два арбуза: один для себя, а другой для тещи. Понятно, что для себя нужно выбрать арбуз потяжелей, 
# а для тещи полегче. Но вот незадача: арбузов слишком много и он не знает как же выбрать самый легкий и самый тяжелый арбуз? Помогите ему!
# Пользователь вводит одно число N – количество арбузов. Вторая строка содержит N чисел, записанных на новой строчке каждое. 
# Здесь каждое число – это масса соответствующего арбуза
# Input: 5 -> 5 1 6 5 9
# Output: 1 9
import random


countWatermelon = int(input("Введите количество арбузов: "))
any = int (countWatermelon)
text = " "
maxHeigt = int (0)
# minHeigt = int (0)


while countWatermelon > 0:
    heigt = int(random.randint(1, 9))
    
    if heigt > maxHeigt:
        maxHeigt = heigt
    heigt = str(heigt)
    text = (heigt + text)
    countWatermelon -= 1

minHeigt = int (text[0])
count = int (0)
print(f"Из {any} арбузов с весами {text}")
      
while any != 0:
    if int (minHeigt) > int (text[count]):
        minHeigt = int (text[count])
    count += 1
    any -= 1
print(f"Мин вес арбуза: {minHeigt}, Макс вес арбуза: {maxHeigt}")
# print(type(minHeigt))

