// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int xa, int xb, int ya, int yb, int za, int zb)
{
    double ab = Math.Sqrt(((xb - xa) * (xb - xa)) + ((yb - ya) * (yb - ya)) + ((zb - za) * (zb - za)));
    return Math.Round(ab);
}

Console.Write("Введите xa: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите xb: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите ya: ");
int n3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите yb: ");
int n4 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите za: ");
int n5 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите zb: ");
int n6 = Convert.ToInt32(Console.ReadLine());

double result = Distance(n1, n2, n3, n4, n5, n6);

Console.WriteLine($"Расстояние между точками с кординатами  (x = {n1}, y = {n3}, z = {n5}) и (x = {n2}, y = {n4}, z  = {n6}) равно {result}.");