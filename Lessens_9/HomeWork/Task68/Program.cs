// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


long Ackerman(long m, long n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
    return Ackerman(m, n);
}

Console.Write($"Введите число M: ");
long m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число N: ");
long n = Convert.ToInt32(Console.ReadLine());

if (m >= 0 && n >= 0)
{
    Console.WriteLine("Вычисления функции Аккермана....пиу пиу пиу");
    Console.WriteLine($"A({m},{n}) = {Ackerman(m, n)}");
}
else
{
    Console.Write($"Одно или оба числа < 0. Давай по новой.");
}