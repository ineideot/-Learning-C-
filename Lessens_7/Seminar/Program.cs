//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int[,] Create2dArray() // создание 2х мерного массива
// {
//     Console.Write("Imput number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input numbers of column: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] createdArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             createdArray[i, j] = new Random().Next(minValue, maxValue + 1);

//     return createdArray;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] newArray = Create2dArray();
// Show2dArray(newArray);






// Задайте двумерный массив размера m на n, каждый элемент в массиве находится
// по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

//  int[,] Filled2dArray() // заполение 2х мерного массива по условию задачи
// {
//     Console.Write("Imput number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input numbers of column: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     int[,] changedArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             changedArray[i, j] = i+j; 
//     return changedArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] newArray = Filled2dArray();
// Show2dArray(newArray);




// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int[,] Changed2dArray() // заполение 2х мерного массива по условию задачи
{
    Console.Write("Imput number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of column: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] changedArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            changedArray[i, j] = new Random().Next(minValue, maxValue);
        }
    return changedArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ChangeEvensIndex(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 != 1 && j % 2 != 1)
            {
                arr[i, j] = arr[i, j] * arr[i, j];
            }
        }
    }
    return arr;
}

int[,] newArray = Changed2dArray();
Show2dArray(newArray);
int[,] changedArr = ChangeEvensIndex(newArray);
Show2dArray(changedArr);