// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] addMatrix(int row, int column)
{
    double[,] twoDimArray = new double[row, column];
    Random rnd = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            twoDimArray[i, j] = Convert.ToDouble(rnd.Next(0, 11));
        }
    }
    return twoDimArray;
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

void Average(double[,] arr)
{

    double[] average = new double[arr.Length];
    for (int i = 0, k = 0; i < arr.GetLength(0); i++)
    {
        double summa = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summa += arr[j, i];
        }
        average[k] = summa / arr.GetLength(1);
        Console.WriteLine("Среднее арифметическое столбца " + (i + 1) + " равно: " + average[k]);
        k++;
    }
    Console.Write("");
    Console.ReadKey(true);

}

Console.Write("Указать кол-во строк двумерного массива: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Указать кол-во столбцов, равное кол-ву строк: ");
int column = Convert.ToInt32(Console.ReadLine());

double[,] newArr = addMatrix(row, column);

PrintArray(newArr);
Average(newArr);