// Напишите программу, которая 
// выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Clear();
int randomDigit = new Random().Next(10,100);
Console.WriteLine($"Случайное число: {randomDigit}");

int ostatok = randomDigit%10;
Console.WriteLine($"Последняя цифра: {ostatok}");

int firstDigit = randomDigit/10;
Console.WriteLine($"Первая цифра: {firstDigit}");

if (ostatok > firstDigit)
{
    Console.WriteLine($"Наибольшая цифра: {ostatok}");
}
else
{
    Console.WriteLine($"Наибольшая цифра: {firstDigit}");
}
