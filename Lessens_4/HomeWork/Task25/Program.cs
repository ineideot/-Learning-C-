// Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)

// 3, 5 -> 243 (3⁵)
// 0, 0 - >1
// 2, 4 -> 16

int Degree(int numA, int numB)
{
    int sum = 1;
    for (int i = 1; i <= numB; i++)
    {
        sum *= numA;
    }
    return sum;
}
Console.Write("Напишите число которое необходимо возвести в степень: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("В какую степень его возвести: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > 0 && numB > 0)
{
    Console.WriteLine($"Число {numA} в степени {numB}: {Degree(numA, numB)}");
}
else
{
    Console.WriteLine("Введите положительное число и степень");
}

