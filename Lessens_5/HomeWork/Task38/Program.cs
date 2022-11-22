// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.0 7.2 22.7 2.1 78.3] -> 76.2

double RealNumber(double[] arr)
{

    double min = arr[0];
    double max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= min)
        {
            min = arr[i];
        };

        if (arr[i] >= max)
        {
            max = arr[i];
        };

    }
    return (max - min);
}

double[] arr = { 12.23, 123.22, 2.71, 321.89, 454.45 };

Console.Write($"Разницу между максимальным и минимальным элементов массива: {RealNumber(arr)}.");

