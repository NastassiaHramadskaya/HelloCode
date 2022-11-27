// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.Clear();
// Console.Write("Введите первое число: ");
// int numberA = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int numberB = int.Parse(Console.ReadLine());

// int div = numberA % numberB;

// if (div == 0)
// {
//     Console.Write($"{numberA}, {numberB} -> кратно");
// }
// else
// {
//     Console.Write($"{numberA}, {numberB} -> не кратно, остаток {div}");
// }

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

// Кратное число - это число, делящееся на данное целое число без остатка. Например : 12 кратно числу 3 , так как 12 делиться на 3.

// Console.Clear();
// Console.Write("Введите первое число: ");
// int number = int.Parse(Console.ReadLine());
// int divA = 7;
// int divB = 23;
// if (number % divA == 0 && number % divB == 0)
// {
//     Console.Write($"{number}-> кратно");
// }
// else
// {
//     Console.Write($"{number}-> не кратно");
// }

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Clear();
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if ((numberA * numberA == numberB) || (numberB * numberB == numberA))
{
    Console.Write($"{numberA}, {numberB}-> yes");
}
else
{
    Console.Write($"{numberA}, {numberB}-> no");
}
