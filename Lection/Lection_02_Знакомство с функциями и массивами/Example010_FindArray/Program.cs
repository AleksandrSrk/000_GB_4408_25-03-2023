// Пользователь вводит число, и мы ищем есть ли оно среди массива и выводим индекс числа в массиве и количество совпадений или пишем что числа нет. 

int[] arr = { 11, 21, 31, 41, 51, 12, 15, 15, 19 };
System.Console.Write("Введите искомое число: ");
int find = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == find)
        {
            System.Console.WriteLine("Есть совпадение в индексе " + i);
            count++;
        }
    }
if (count == 0)
{
    System.Console.WriteLine("Совпадений найдено не было");
}
else if (count != 0)
{
    System.Console.WriteLine("Было найдено " + count + " совпадений");
}