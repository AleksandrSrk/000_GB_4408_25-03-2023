// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];
Arr();
System.Console.Write("Среднее арифметическое массива");
PrintArray(array);
System.Console.Write($" равно: {ArithmeticMean()}");


Array Arr()
{
    Random rand = new Random(); // СОЗДАЛИ КЛАСС РАНДОМ
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 2); // ЗАПОЛНЯЕМ МАССИВ ЭЛЕМЕНТАМИ ОТТ 0 ДО 1, ОБРАЩАЯСЬ К КЛАССУ РАНДОМ
    }
    return array;
}

double ArithmeticMean()
{
    double res = 0;

    for (int i = 0; i < array.Length; i++)
    {
        res = res + array[i];
    }
    double arithmetic = res / array.Length;
    return arithmetic;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]}");
    }
}

//Console.WriteLine("[{0}]", string.Join(", ", array)); // ПЕЧАТЬ МАССИВА
// System.Console.Write($" {numbers[i]}"); ЕЩЕ МЕТОД ПЕЧАТИ МАССИВА ЧЕРЕЗ ЦИКЛ ФОР