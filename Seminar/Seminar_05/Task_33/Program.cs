// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();

System.Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
System.Console.Write("Введите искомое число: ");
int num = Convert.ToInt32(Console.ReadLine());

FillArray(array);
System.Console.Write("В массиве ");
PrintArray(array);
SerachNumber(array);
System.Console.WriteLine(IndexArr(num, array));


void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(10, 16);
    }
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write($"{item} ");
    }
}

void SerachNumber(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num || arr[i] == num * -1)
        {
                        res = 1;
        }
    }
    if (res == 0)
    {
        System.Console.WriteLine($"нет искомого числа {num}");
    }
    else System.Console.Write($"есть искомое число {num} под индексом");
}

string IndexArr (int num, int[] arr)
{
    string res = string.Empty;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            res += $" {i} ";
        }
    }
    return res;
}