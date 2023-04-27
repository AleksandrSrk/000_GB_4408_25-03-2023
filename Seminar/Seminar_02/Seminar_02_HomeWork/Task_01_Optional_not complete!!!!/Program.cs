// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123

System.Console.WriteLine("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
//double num = (Convert.ToDouble(Console.ReadLine()));



int count = 0;
string numStr = Convert.ToString(num);

for (int i = 0; i < numStr.Length; i++)
{
    count++;
}


double NumberTwoo (double number) {
    //System.Console.WriteLine(number%10);
    for (double i = 0; i < count; i++)
    {
        number = number%100;
        int a = Convert.ToInt32(number);
        System.Console.Write(a);
    }
    return 1;

}
double res = NumberTwoo(num);