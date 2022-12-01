//Задайте двумерный масcив, напишите программу 
//которая поменяет две любые строки массива.

// int[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] CreateArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             CreateArray[i, j] = new Random().Next(minValue, maxValue + 1);
//     return CreateArray;
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

// int[,] ChangeRows(int[,] array, int row1, int row2)
// {
//     if (row1 >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row2 < array.GetLength(0) && row1 != row2)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//     }
//     else Console.WriteLine("Incorrect input!");
//     return array;
// }


// Console.Write("Imput number of rows: ");
// int user_rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numbers of column: ");
// int user_columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min possible value: ");
// int user_minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max possible value: ");
// int user_maxValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of 1st row for remove: ");
// int user_row1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of 2nd row for remove: ");
// int user_row2 = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = Create2dArray(user_rows, user_columns, user_minValue, user_maxValue);
// Show2dArray(newArray);
// Show2dArray(ChangeRows(newArray, user_row1, user_row2));


//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] Create2dArray()
// {
//     Console.Write("Imput number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input numbers of column: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] CreateArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             CreateArray[i, j] = new Random().Next(minValue, maxValue + 1);
//     return CreateArray;
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

// void MatrixChange(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Let it be square matrix? 4x4 for example");
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//             for (int j = 1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//     }
// }

// int [,] initMatrix = Create2dArray();
// Show2dArray(initMatrix);
// Console.WriteLine();
// MatrixChange(initMatrix);
// Show2dArray(initMatrix);


//Заддайте двумерный массив из целых чисел.Напишите программу,
//которая обнулит строку и столбец, на пересечении которых 
//расположен первый наименьший элемент массива.

int[,] Create2dArray()
{
    Console.Write("Imput number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of column: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] CreateArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            CreateArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return CreateArray;
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

int[,] ChangeRowColumn(int[,] array)
{
    int iMin = 0;
    int jMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    Console.WriteLine($"{iMin}, {jMin}");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, jMin] = 0;
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[iMin, j] = 0;
    }
    return array;
}

int[,] myArray = Create2dArray();
Show2dArray(myArray);
ChangeRowColumn(myArray);
Show2dArray(myArray);