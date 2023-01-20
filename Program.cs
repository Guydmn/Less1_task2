// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите значение a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b: ");
int b = Convert.ToInt32(Console.ReadLine());
int y = a * a;
if (y == b)
Console.Write($"b является квадратом числа a");
else
Console.Write($"b не является квадратом числа a");