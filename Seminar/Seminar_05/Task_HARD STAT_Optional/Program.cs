// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
// среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

// НУ ТУТ И НАВОРОЧЕНО КОНЕЧНО. Я НЕ СМОГ ПОНЯТЬ, КАК ИЗ ОДНОГО МЕТОДА МОЖНО ВЫТАЩИТЬ РАЗНЫЕ ДАННЫЕ, ВЕДЬ РЕТЕРН ТОЛЬКО ОДИН У НАС. 
// ИНАЧЕ Я БЫ ВСЕ ВЫЧИСЛЕНИЯ В ОДНОМ МЕТОДЕ СДЕЛАЛ. А ТАК ПРИШЛОСЬ РАЗБИВАТЬ КАЖДОЕ ВЫЧИСЛЕНИЕ НА ОТДЕЛЬНЫЙ МЕТОД. 
// ПОЧЕМУ ТО СРЕДНЕЕ АРИФМЕТИЧЕСКОЕ НЕ ВЫВОДИЛО ДРОБНОЕ ЧИСЛО, КОГДА СДЕЛАЛ ЕГО В ДАБЛ. РЕШИЛ ПОКА ОСТАВИТЬ ИНТ, И ТАК ЖЕ ИНТ В МЕДИАНЕ С ЧЕТНОЙ ДЛИНОЙ МАССИВА.
// СРОК ВЫХОДИТ К СДАЧЕ. ПОЗЖЕ РАЗБЕРУСЬ ЕЩЕ С ДАБЛ. 


System.Console.Write("Введите размерность массива положительным натуральным числом больше 0: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size > 0)
{
    int[] array = new int[size];
    int[] arrayResult = new int[6];
    string[] commentArrayResult = new string[6];


    FillArray(array);
    System.Console.WriteLine("ЗАДАН МАССИВ ");
    PrintArray(array);
    System.Console.WriteLine();
    FillArrayResult(arrayResult, array);
    FillCommentArrayResult(commentArrayResult);
    PrintArrayResult(arrayResult, commentArrayResult);

}
else System.Console.WriteLine("ОШИБКА! Вы задали массив без элементов. ");



void FillArray(int[] arr) //ЗАПОЛНЯЕМ ПЕРВОНАЧАЛЬНЫЙ МАССИВ ДАННЫМИ
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] arr) // МЕТОД ПЕЧАТИ МАССИВА
{
    foreach (double item in arr)
    {
        System.Console.Write($"{item} ");
    }
}

int MaxElements(int[] arr) // НАХОДИМ МАКСИМАЛЬНЫЙ ЭЛЕМЕНТ МАССИВА
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

int MinElements(int[] arr) // НАХОДИМ МИНИМАЛЬНЫЙ ЭЛЕМЕНТ МАССИВА
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

int IndexMaxElements(int[] arr) // НАХОДИМ ИНДЕКС МАКСИМАЛЬНОГО ЭЛЕМЕНТА МАССИВА
{
    int max = arr[0];
    int indexMax = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
            indexMax = i;
        }
    }
    return indexMax;
}

int IndexMinElements(int[] arr) // НАХОДИМ ИНДЕКС МИНИМАЛЬНОГО ЭЛЕМЕНТА МАССИВА
{

    int min = arr[0];
    int indexMin = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            indexMin = i;
        }
    }
    return indexMin;
}

int ArithmeticMean(int[] arr) // НАХОДИМ СРЕДНЕЕ АРИФМЕТИЧЕСКОЕ
{
    int sumElements = 0;
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        sumElements = sumElements + arr[i];
        count++;
    }
    int arithmeticMean = sumElements / count;
    return arithmeticMean;
}

int Mediana(int[] arr) // НАХОДИМ МЕДИАНУ. Я ПРАВИЛЬНО ЖЕ ПОНЯЛ, ЧТО МЕДИАНА = СЕРЕДИНА МАССИВА В НЕЧЕТНОМ МАССИВЕ, ИЛИ СР.АРИФМ В ДВУХ СРЕДНИХ ЦИФРАХ В ЧЕТНОМ?
{
    int mediana = 0;
    Array.Sort(arr);
    // foreach (int item in arr)
    // {
    //     System.Console.Write($"{item} ");
    // }
    if (arr.Length % 2 != 0)
    {
        mediana = arr[arr.Length / 2];
    }
    else
    {
        mediana = (arr[arr.Length / 2] + arr[(arr.Length / 2) -1]) / 2;
    }
    return mediana;

}

void FillArrayResult(int[] arrayResult, int[] array) // ЗАПОЛНЯЕМ НОВЫЙ МАССИВ ДАННЫМИ РЕЗУЛЬТАТОВ ВЫЧИСЛЕНИЙ
{
    arrayResult[0] = MaxElements(array);
    arrayResult[1] = IndexMaxElements(array);
    arrayResult[2] = MinElements(array);
    arrayResult[3] = IndexMinElements(array);
    arrayResult[4] = ArithmeticMean(array);
    arrayResult[5] = Mediana(array);
}

void FillCommentArrayResult(string[] commentArrayResult) // ЗАПОЛНЯЕМ МАССИВ КОММЕНТАРИЯМИ К ДАННЫМ
{
    commentArrayResult[0] = "Максимальный элемент";
    commentArrayResult[1] = "Индекс максимального элемента";
    commentArrayResult[2] = "Минимальный элемент";
    commentArrayResult[3] = "Индекс минимального элемента";
    commentArrayResult[4] = "Среднее арифм. элементов массива";
    commentArrayResult[5] = "Медиана массива";
}

void PrintArrayResult(int[] arrayResult, string[] commentArrayResult) // ПЕЧАТАЕМ ИТОГОВЫЙ МАССИВ С КОММЕНТАРИЯМИ
{
    for (int i = 0; i < arrayResult.Length; i++)
    {
        System.Console.WriteLine($"{commentArrayResult[i]} = {arrayResult[i]}");
    }
}