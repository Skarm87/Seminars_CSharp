// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает сумму первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int firstDigit = num / 100; // 456 / 10=4.56
int lastDigit = num % 10; // 456 % 10=450+6

int result = firstDigit + lastDigit;

Console.WriteLine($"Сумма первой и последней цифры: {result}");
