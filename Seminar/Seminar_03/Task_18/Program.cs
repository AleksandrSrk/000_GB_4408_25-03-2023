// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void NumQuarter(int numQ)
{
    if (numQ == 1) System.Console.WriteLine($"Координаты в плоскости {numQ} x > 0; y > 0");
    else if (numQ == 2) System.Console.WriteLine($"Координаты в плоскости {numQ} x < 0; y > 0");
    else if (numQ == 3) System.Console.WriteLine($"Координаты в плоскости {numQ} x < 0; y < 0");
    else if (numQ == 4) System.Console.WriteLine($"Координаты в плоскости {numQ} x > 0; y < 0");
    else System.Console.WriteLine("Нужно ввести номер от 1 до 4");
}

string NumQuaterStr(int num)
{
    string res = "Нужно ввести номер от 1 до 4";
    if (num == 1)
        res = ($"Координаты в плоскости {num} x > 0; y > 0");
    else if (num == 2)
        res = ($"Координаты в плоскости {num} x < 0; y > 0");
    else if (num == 3)
        res = ($"Координаты в плоскости {num} x < 0; y < 0");
    else if (num == 4)
        res = ($"Координаты в плоскости {num} x > 0; y < 0");
    return res;
}

try {
System.Console.WriteLine("Введите номер четверти от 1 до 4");
int num = Convert.ToInt32(Console.ReadLine());

NumQuarter(num);
System.Console.WriteLine(NumQuaterStr(num));
}

catch {
    System.Console.WriteLine("ОШИБКА!!! Нужно вводить именно целые числа!");
}