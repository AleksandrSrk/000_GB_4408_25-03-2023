// Задача необязательная 2:
// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, 
// по которой робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".
// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.
// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с 
// правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 
// 5 программистов.
// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 1000 человек.

System.Console.WriteLine("Введите количество программистов в комнате: ");
int num = Convert.ToInt32(Console.ReadLine());
string name = "Программист";


if (num%10 == 1 && num%100 != 11) System.Console.WriteLine($"{num} {name}");
if (num%10 == 2 && num%100 != 12) System.Console.WriteLine($"{num} {name}а");
if (num%10 == 3 && num%100 != 13) System.Console.WriteLine($"{num} {name}а");
if (num%10 == 4 && num%100 != 14) System.Console.WriteLine($"{num} {name}а");
if (num%10 == 5) System.Console.WriteLine($"{num} {name}ов");
if (num%10 == 6) System.Console.WriteLine($"{num} {name}ов");
if (num%10 == 7) System.Console.WriteLine($"{num} {name}ов");
if (num%10 == 8) System.Console.WriteLine($"{num} {name}ов");
if (num%10 == 9) System.Console.WriteLine($"{num} {name}ов");
if (num%10 == 0) System.Console.WriteLine($"{num} {name}ов");
if (num%100 == 11) System.Console.WriteLine($"{num} {name}ов");
if (num%100 == 12) System.Console.WriteLine($"{num} {name}ов");
if (num%100 == 13) System.Console.WriteLine($"{num} {name}ов");
if (num%100 == 14) System.Console.WriteLine($"{num} {name}ов");