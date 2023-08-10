void FillAray(int[] collection) // СОЗДАЛИ МЕТОД ЗАПОЛНЕНИЯ МАССИВА
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {

        collection[index] = new Random().Next(1, 10); // Заполняем массив случайными числами от 1 до 10
        index++;
    }
}

void PrintAray(int[] col)  // СОЗДАЛИ МЕТОД ПЕЧАТИ МАССИВА
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) 
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count) {
        if (collection[index] == find)
        {
            position = index;
            break; // ищем четверку и останавливаем цикл когда находим первую в массиве
        }

        index++;

    } return position;
}

int[] arr = new int[10];

FillAray(arr);
PrintAray(arr);
System.Console.WriteLine();

int pos = IndexOf(arr, 4); // В метод передаем массив и показываем что ищем 4
System.Console.WriteLine(pos);