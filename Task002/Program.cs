// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2)
{
    Console.Write($"Первое число: {n1} больше второго: {n2}");
}
else
{
    Console.Write($"Второе число: {n2} больше первого: {n1}");
}