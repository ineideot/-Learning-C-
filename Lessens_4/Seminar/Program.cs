// Напишите программу, которая принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А.

// int FindSum(int a)
// {
//     int sum = 0;
//     for (int curr = 1; curr <= a; curr++)
//     {
//         sum += curr; //sum = sum+ curr;
//     }
//     return sum;
// }
// Console.Write("Напишите любое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n > 1)
// {
//     Console.WriteLine($"Сумма чисел от 1 до {n} будет {FindSum(n)}");
// }
// else
// {
//     Console.WriteLine("Введите положительное число");
// }



// Напишите программу, которая принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.

// int ProductOfNumbers(int n)
// {
//     int product = 1;
//     for (int curr = 1; curr <= n; curr++)
//     {
//         product = product * curr; //product *= curr;     //a=a+5 => a+=5; b=b*9=> b*=9
//     }
//     return product;
// }
// Console.Write("Напишите любое число ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n > 0)
// {
//     Console.WriteLine($"Произведение чисел от 1 до {n}: {ProductOfNumbers(n)}");
// }
// else
// {
//     Console.WriteLine("Введите положительное число!");
// }

// Напишите программу, которая находит в последовательности от 1 до N все нечетные числа

// void AllOdd(int n)
// {
//     for (int curr = 1; curr <= n; curr = curr + 2)
//     {
//         Console.Write($"{curr}, ");
//     }
// }
// Console.Write("Введите положительное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n > 0)
// {
//     AllOdd(n);
// }
// else
// {
//     Console.WriteLine("Введите положительное число!");
// }

// while (true) // Великий цикл для за%бывания!
// {
//     Console.Write("Введите положительное число: ");   
//     int n = Convert.ToInt32(Console.ReadLine());
//     if (n > 0)
//     {
//         AllOdd(n);
//         break;
//     }
//     else
//     {
//         Console.Write("Вам надоест первому. ");
//     };
// }

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3

// int CountOf(int n)    // Возвращаемый метод
// {
//     int count = 0;
//     while (n > 0)
//     {
//         count++;
//         n = n / 10;
//         Console.Write($"{n} "); // Посмотреть как это выглядит
//     }
//     return count;

// }
// Console.Write("Введите положительное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Количество чисел в числе {num}: {CountOf(num)}");

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями 
//и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] CreatRandArray(int n, int minVal, int maxVal)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
     Console.Write($"{arr[i]}, ");
    }
    Console.Write("\b\b]");     //Удаляет последний символ (\b)
}

PrintArray(CreatRandArray(8,0,2));
