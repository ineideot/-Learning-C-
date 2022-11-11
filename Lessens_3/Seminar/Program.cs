//Напишите программу, которая по заданному номеру четверти,
//показывает диапазон возможных координат точек в этой четверти (x и y).


// void Quters(int quater)
// {
//     if (quater == 1) Console.WriteLine("В первоей четверти х>0, y>0");
//     else if (quater == 2) Console.WriteLine("Во второй четверти х>0, y<0.");
//     else if (quater == 3) Console.WriteLine("В третей четверти х<0, y<0.");
//     else if (quater == 4) Console.WriteLine("В  четверти х<0, y>0.");
//     else Console.WriteLine("Такоей четверти не существует.");
// }
// Console.Write("Введите номер четверти: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Quters(num);

//Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


// void PointPosition(int num1, int num2)
// {

//     if (num1 > 0 & num2 > 0) Console.WriteLine($"Точка c кординатами х={num1}, y={num2} пренадлежит к первой четверти.");
//     else if (num1 > 0 & num2 < 0) Console.WriteLine($"Точка c кординатами х={num1}, y=({num2}) пренадлежит ко второй четверти.");
//     else if (num1 < 0 & num2 < 0) Console.WriteLine($"Точка c кординатами х=({num1}), y=({num2}) пренадлежит к третей четверти.");
//     else if (num1 < 0 & num2 > 0) Console.WriteLine($"Точка c кординатами х=({num1}), y={num2} пренадлежит к четвёртой четверти.");
// }

// Console.Write("Напишите кординаты точки X:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Напишите кординаты точки Y:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == 0 || num2 == 0) Console.WriteLine("Задайте новые кординаты, где X не равен 0 и Y не равен 0.");

// PointPosition(num1, num2);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// void SquareOfNumbers(int num)

//Метод через for

// {
//     if (num <= 0)
//         Console.WriteLine("Натуральные числа - это числа, возникающие естественным образом при счёте (1, 2, 3, 4, 5, 6, 7 и так далее). Попробуйте ещё раз.");
//     else 
//     Console.Write($"Таблица квадратов чисел от 1 до {num}: ");
//     for(int i =1; i<=num;i++){
//         Console.Write($"{i*i} ");
//     }

//Метод через while

//     if (num <= 0)
//         Console.WriteLine("Натуральные числа - это числа, возникающие естественным образом при счёте (1, 2, 3, 4, 5, 6, 7 и так далее). Попробуйте ещё раз.");
//     else
//     {
//         int i = 1;
//         int num1;
//         Console.Write($"Таблица квадратов чисел от 1 до {num}: ");
//         while (i < num + 1)
//         {
//             num1 = (i * i);
//             Console.Write($"{num1} ");
//             i++;
//         }
//         Console.Write(".");
//     }
// }

// Console.Write("Введите натуральное число:");
// int num = Convert.ToInt32(Console.ReadLine());

// SquareOfNumbers(num);


// Напишите программу,
//которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве


// AB =√(xb-xa)^2 +(yb-ya)^2

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Distance(int xa, int xb, int ya, int yb)

//float- хранит до трех знаков после запятой
//double - хранит до ста знаков после запятой
{
    double ab = Math.Sqrt(((xb - xa) * (xb - xa)) + ((yb - ya) * (yb - ya)));  //Math.Sqrt - Возвращает квадратный корень из указанного числа.
    return Math.Round(ab); //Метод Math. round() - возвращает число, округлённое к ближайшему целому.
}

Console.Write("Введите xa: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите xb: "); 
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите ya: ");
int n3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите yb: ");
int n4 = Convert.ToInt32(Console.ReadLine());

double result = Distance(n1,n2,n3,n4);

Console.WriteLine($"Расстояние между точками ({n1},{n3}) и({n2},{n4}) равно {result} ");
