﻿// Напишите программу, которая принимает на вход трехзначное число
// и удаляет вторую цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81


Console.Write("Введите целое положительное трёхзначное число: ");

int num = Convert.ToInt32(System.Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int firstDigit = num / 100; // 256 / 10 = 2.56 = 2
    int thirdDigit = num % 10; // 256 % 10 = 250 + 6 = 6

    int result = firstDigit * 10 + thirdDigit;

    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некорректный ввод");
}