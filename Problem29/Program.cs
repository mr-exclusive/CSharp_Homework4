﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] arr = {1, 2, 5, 7, 19, 6, 1, 33};

for (int i = 0; i < arr.Length; i++)
{
    if (i > 0) 
    {
        Console.Write(", ");
    }

    Console.Write(arr[i]);
}