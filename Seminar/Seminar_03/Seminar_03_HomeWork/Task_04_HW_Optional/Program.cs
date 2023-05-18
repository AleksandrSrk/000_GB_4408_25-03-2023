// Необходимо реализовать три алгоритма сортировки одномерного массива - пузырьком, быстрой сортировкой, методом подсчета. 
// Исходный массив заполняется случайными целыми числами. 
//Далее провести ряд экспериментов с различной размерностью массива, 
// засечь время выполнения каждого, объяснить в соответствии с нотацией Big O полученные результаты. 
// Выполнять всё с помощью методов. Рассказать про плюсы и минусы каждого алгоритма.

System.Console.Write("Введите размерность массива: ");
int lenghtArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenghtArray];
Random rnd = new Random();

CreateArray();
BubbleSort();


Array CreateArray()
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-1000, 1000); // Заполняем массив случайными числами в диапазоне 
    }
    System.Console.Write("Создали массив и заполнили его значениями: ");
    Console.WriteLine("[{0}]", string.Join(", ", array));
    return array;
}

void BubbleSort()
{
    int temp;

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                Console.WriteLine("[{0}]", string.Join(", ", array));
            }

        }
    }
    Console.WriteLine("[{0}]", string.Join(", ", array));
}