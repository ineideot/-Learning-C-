// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());


int Sum(int m, int n)
{
    if (m != n + 1)
    {
        return m + Sum(m + 1, n);
    }
    else return 0;
}
Console.WriteLine($"Cумма натуральных значений в промежутке от M:{m} до N:{n} = {Sum(m, n)}.");