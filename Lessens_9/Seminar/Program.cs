// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от 1 до N.

// void ShowNumbers(int n)
// {
//     Console.Write(n + " ");
//     if (n > 1) ShowNumbers(n - 1);
//     Console.Write(n + " ");
// }

// ShowNumbers(10);
// Console.WriteLine();
// ShowNumbers(12);




// Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.

// int SumDigits(int n)
// {
//     if (n < 0) n *= (-1);
//     if (n > 0) return SumDigits(n / 10) + n % 10;
//     else return 0;
// }

// Console.Write("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int res = SumDigits(num);
// Console.WriteLine(res);




// Задайте значение M и N. Напишите программу,
// которая выведет все натуральные чсла в промежутке от M до N.
// M > N, M = N, M < N.

// void ShowNumbersMN(int n, int m)
// {
//     Console.Write($"{Math.Max(n, m)} ");
//     if (Math.Max(n, m) != Math.Min(n, m))
//         ShowNumbersMN(Math.Max(n, m) - 1, Math.Min(n, m));
//     Console.Write($"{Math.Max(n, m)} ");
// }

// ShowNumbersMN(-15, 1);




//Напишите программу, которая на входи принемает два 
//числа А и Б, и возводит число А в степень Б c помощью рекурсии

// double FindPower(double a, double b) // работает как с int, так и с double
// {
//     if (b > 0) return FindPower(a, b - 1) * a;
//     if (b < 0) return FindPower(a, b + 1) / a;
//     return 1.0;
// }

// double res = FindPower(333, -99);
// Console.WriteLine(res);