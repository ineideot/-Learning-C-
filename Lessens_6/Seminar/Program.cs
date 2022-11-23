// //Напишите программу, которая перевернёт одномерный массив.

// int[] CreatNewArray(int size, int minVal, int maxVal)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minVal, maxVal + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write("\b\b]");
// }

// int[] ReversedArray(int[] array)
// {
//     int k = array.Length;
//     for (int i = 0; i < k / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[k - 1 - i];
//         array[k - 1 - i] = temp;
//     }
//     return array;
// }

// Console.Write("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreatNewArray(size, min, max);
// ShowArray(newArray);

// ShowArray(ReversedArray(newArray));


//Напишите программу, которая будет преобразовывать  десятичное число в двоичное
//45 -> 101101
//3 -> 11

// string BinarySystem(int num)
// {
//     string result = string.Empty; // или ""; пустая строка
//     while (num != 0)
//     {
//         result = num % 2 + result; // Запись наоборот(справа на лево)
//         num = num / 2;
//     }
//     return result;
// }

// Console.Write("Input number: ");
// int number10 = Convert.ToInt32(Console.ReadLine());

// string res = BinarySystem(number10);
// Console.WriteLine($"Your number {number10} in binary system is {res}");

//Не используя рекурсию, вывести первые N чисел Фибоначи.
//Первые два числа Фибоначи: a и b (пользователь)

// void Fibonachi(int kol, int n1, int n2)
// {
//     int[] arr = new int[kol];
//     arr[0] = n1;
//     arr[1] = n2;
//     Console.Write($"{arr[0]} {arr[1]} ");
//     for (int i = 2; i < kol; i++)
//     {
//         arr[i] = arr[i - 1] + arr[i - 2];
//         Console.Write($"{arr[i]} ");
//     }
// // ShowArray(arr);
// }

// // void ShowArray(int[] array)
// // {
// //     Console.Write("[");
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         Console.Write($"{array[i]}, ");
// //     }
// //     Console.Write("\b\b]");
// // }

// Console.Write("Input first number Fibonachi: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number Fibonachi: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input count number Fibonachi: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Fibonachi(n, a, b);

// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины

void Triangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < b + a)
    {
        Console.Write($"Triangle with {a}, {b}, {c} is real");
    }
    else
    {
   Console.Write($"Triangle with {a}, {b}, {c} is not real");
    }
}

Console.Write("Input length of the first side: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input length of the second side: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input length of the third side: ");
int n = Convert.ToInt32(Console.ReadLine());

Triangle(a,b,n);