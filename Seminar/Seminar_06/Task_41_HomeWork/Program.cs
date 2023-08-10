// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.Write("Укажите сколько чисел планируете вводить: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
System.Console.WriteLine($"Введите {count} чисел поочередно: ");

InputNumber(array);

System.Console.Write("В введенном списке ");
PrintArray(array);
System.Console.WriteLine($"'{CountNumber()}' чисел больше 0");

int[] InputNumber(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write($"{item} ");
    }


}

int CountNumber()
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

