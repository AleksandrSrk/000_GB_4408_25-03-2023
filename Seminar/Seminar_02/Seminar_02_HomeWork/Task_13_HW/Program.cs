// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// ЗАДАННОЕ ЧИСЛО ОЗНАЧАЕТ ЧТО ЕГО НЕ ПОЛУЧАЕМ ИЗВНЕ, А ОНО ЗАДАНО ИЗНАЧАЛЬНО?

int num0 = Number(1);
int num1 = Number(325);
int num2 = Number(-987654);
int num3 = Number(478);

int Number(int numIn)
{
    if (numIn > 99 || numIn < -99)
    {
        while (numIn > 999 || numIn < -999)
        {
            numIn = numIn / 10;
        }
        numIn = numIn % 10;
        System.Console.WriteLine(numIn);
    }
    else System.Console.WriteLine("Третьей цифры нет");
    return 1; // КАК МОЖНО НЕ ВВОДИТЬ ТУТ ЭТО ЗНАЧЕНИЕ? БЕЗ НЕГО ПРОГРАММА ВЫДАЕТ ОШИБКУ. 
}

