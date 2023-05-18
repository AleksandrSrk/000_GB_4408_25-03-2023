// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

System.Console.Write("Введите любое число: ");

try
{
    double num = Convert.ToDouble(Console.ReadLine());
    int lenghtNum = LenghtNum(num);
    int deleteComma = Convert.ToInt32(DeleteComma(num));
    CheckingForPalindrome(deleteComma);


    int LenghtNum(double numLen) // Вычисляем длину введенного числа. Перевели его в строку, посчитали символы без учета запятой
    {
        string res = Convert.ToString(numLen);
        int count = 0;
        string comma = ",";

        for (int i = 0; i < res.Length; i++)
        {
            count++;
        }
        if (res.Contains(comma))
        {
            count = count - 1;
        }
        return count;
    }

    double DeleteComma(double number) // Удаляем запятую из числа. Перевели в строку, удалили запятую, и обратно перевели в число
    {
        string res = Convert.ToString(number);
        res = res.Replace(",", "");
        number = int.Parse(res);
        return number;
    }

    Array CheckingForPalindrome(int numWithoutComma)

    {
        int[] arr = new int[LenghtNum(num)];
        int numberMatches = lenghtNum / 2; // переменная показывает, сколько может быть максимальных совпадений в палиндроме
        int count = 0;
        int arrayLenght = lenghtNum;

        for (int i = 0; i < arr.Length; i++) // Заполнили массив
        {
            arr[i] = numWithoutComma % 10;
            numWithoutComma = numWithoutComma / 10;
        }

        for (int i = 0; i < arr.Length / 2; i++) // Сравниваем заполненный массив с двух концов
        {
            if (arr[arrayLenght - 1] == arr[i]) // Если значения совпадают, увеличиваем каунт
            {
                count++;
                arrayLenght--;
            }
        }
        if (numberMatches == count) // Сравниваем каунт и нужное количество воспадений
        {
            System.Console.WriteLine($"Число {num} ЯВЛЯЕТСЯ палиндромом");
        }
        else System.Console.WriteLine($"Число {num} НЕ ЯВЛЯЕТСЯ палиндромом");
        return arr;
    }
}
catch
{
    System.Console.WriteLine("!!! Ошибка Нужно ввести именно число!");
}

