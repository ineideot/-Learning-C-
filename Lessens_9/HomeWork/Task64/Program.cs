﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int ShowNumbers(int n)
{
    if (n >= 1)
    {
        Console.Write($"[{n}] ");
        return ShowNumbers(n - 1);
    }
    else return 0;
}

Console.Write("Натуральные числа в промежутке от N до 1: ");

ShowNumbers(n);