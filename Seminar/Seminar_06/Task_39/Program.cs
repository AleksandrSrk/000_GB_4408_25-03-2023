// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
FillArray(arr);
PrintArray(arr);
System.Console.WriteLine();
ReverseArray(arr);
PrintArray(arr);



int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item} ");
    }
}

/*
int [] ReverseArray (int [] array)
{
    int temp = 0;
    int count = 1;
    for (int i = 0; i < array.Length/2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length -count];
        array[array.Length -count] = temp;
        count++;
    }
    return array;
}
*/

int[] ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        (array[i], array[array.Length - 1 - i]) = (array[array.Length - 1 - i], array[i]); // перевернули массив методом преподавателя через кортеж
    }
    return array;
}