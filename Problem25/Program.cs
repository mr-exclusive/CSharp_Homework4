// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Enter a power: ");
int power = int.Parse(Console.ReadLine());

double result = number;
for (int i = 2; i <= power; i++)
{
    result *= number;
}

Console.Write($"{number}^{power} = {result}");