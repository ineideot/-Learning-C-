// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] addMatrix()
{
    Console.Write("Введите количество строк: ");
    int row = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int column = Convert.ToInt32(Console.ReadLine());

    double[,] twoArray = new double[row, column];

    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            twoArray[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
        }
    }
    return twoArray;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] newArray = addMatrix();
PrintArray(newArray);