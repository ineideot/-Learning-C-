/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Show even number?");
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)    // Делим число на 2, в котором остаток от деления будет равен 0.
{
    Console.WriteLine($"{num} even number.");
}
else
{
    Console.WriteLine($"{num} not even number.");
}