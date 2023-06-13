// Напишите програму которая будет копировать массив поэлементно


System.Console.Write("Введите Длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

PrintArray(Array());
PrintArray(CopyArray());


int[] Array()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

int[] CopyArray()
{
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = array[i];
    }
    return arr;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}