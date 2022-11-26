﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

int result = 0;
while (number > 0)
{
    result += number % 10;
    number /= 10;
}

Console.Write($"Summa of digits is {result}");