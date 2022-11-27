// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

Console.Clear();
int randomDigit = new Random().Next(100,1000); //случайное число от 100 до 990 включительно

int firstDigit = randomDigit / 100;
int thirdDigit = randomDigit % 10; //остаток от деления на 10

Console.WriteLine($"{randomDigit} -> {firstDigit}{thirdDigit}");

// int result = (randomDigit / 100)*10 + randomDigit%10;
// Console.WriteLine(result);