// Задача VERY HARD необязательная Имеется массив случайных целых чисел. Создайте массив, в который попадают числа, описывающие 
// максимальную сплошную возрастающую последовательность. Порядок элементов менять нельзя.
// Одно число - это не последовательность.
// Пример:
// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7] так как здесь вразброс присутствуют все числа от 1 до 7
// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5] так как здесь есть числа от 1 до 5 и эта последовательность длиннее чем от 7 до 8
// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5] так как здесь есть числа от 3 до 5 и эта последовательность длиннее чем от 7 до 8


System.Console.Write("Введите размерность массива положительным натуральным числом больше 0: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size > 0)
{
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    System.Console.WriteLine();
    CountSequence(array);

}
else System.Console.WriteLine("ОШИБКА! Вы задали массив без элементов. ");



void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 11);
    }
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write($"{item} ");
    }
}

void CountSequence(int[] arr)
{
    int count = 0;
    Array.Sort(arr);
    foreach (int item in arr)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == arr[i] + 1)
        {
            count++;
            //System.Console.Write($"{arr[i]}");
        }
    }
    System.Console.WriteLine(count);
}