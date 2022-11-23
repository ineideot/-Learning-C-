// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = b1 * x + a1, y = b2 * x + a2; 
//значения a1, b1, a2 и b2 задаются пользователем.

// a1 = 2, b1 = 5, a2 = 4, b2 = 9 -> (-0,5; -0,5)

void Dot(double a1, double b1, double a2, double b2)
{
    if (b1 != b2)
    {
        double x = (a1 - a2) / (b2 - b1);
        double y = b1 * x + a1;
        Console.Write($"Координаты точки пересечения двух прямых: ({x}; {y})");
    }
    else Console.Write($"Координаты точки пересечения отсутствуют!");
}

Console.Write("Введи a1: ");
double a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи a2: ");
double a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Dot(a1, b1, a2, b2);