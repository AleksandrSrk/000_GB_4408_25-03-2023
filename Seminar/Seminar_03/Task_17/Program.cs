// Напишите программу которая на вход принимает координаты Х и У, при чем они ен равны нулю, и выдает номер четверти в которой находится точка

void CheckKoord(int x, int y)
{
    if (x > 0 && y > 0)
        System.Console.WriteLine($"Координаты Х = {x}, Y = {y}. Это 1 четверть");
    else if (x < 0 && y > 0)
        System.Console.WriteLine($"Координаты Х = {x}, Y = {y}. Это 2 четверть");
    else if (x < 0 && y < 0)
        System.Console.WriteLine($"Координаты Х = {x}, Y = {y}. Это 3 четверть");
    else if (x > 0 && y < 0)
        System.Console.WriteLine($"Координаты Х = {x}, Y = {y}. Это 3 четверть");
    else
        System.Console.WriteLine("Точка лежит на координатной оси");
}
int CheckKoord2(int x, int y)
{
    int res = 0;
    if (x > 0 && y > 0)
        res = 1;
    else if (x < 0 && y > 0)
        res = 2;
    else if (x < 0 && y < 0)
        res = 3;
    else if (x > 0 && y < 0)
        res = 4;
    return res;
}

System.Console.WriteLine("Введите координаты X");
int numX = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты Y");
int numY = Convert.ToInt32(Console.ReadLine());

CheckKoord(numX, numY);
System.Console.WriteLine($"Это четверть номер {CheckKoord2(numX, numY)}");
