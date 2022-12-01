// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// 

Console.Write("Количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат, спиралька внизу");
void ShowArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4} ");
        }
        Console.WriteLine();
    }
}

int SpirallArr(int[,] newArray, int count, int iElm, int jElm)
{
    for (int j = jElm; j < column; j++)
    {
        if (newArray[iElm, j] == 0) newArray[iElm, j] = count;
        count++;
    }
    for (int i = iElm + 1; i < rows; i++)
    {
        if (newArray[i, column - 1] == 0) newArray[i, column - 1] = count;
        count++;
    }
    for (int j = column - 2; j >= jElm; j--)
    {
        if (newArray[rows - 1, j] == 0) newArray[rows - 1, j] = count;
        count++;
    }
    for (int i = rows - 2; i > iElm; i--)
    {
        if (newArray[i, jElm] == 0) newArray[i, jElm] = count;
        count++;
    }
    return count;
}

int[,] spirAddArray = new int[rows, column];
int iBegin = 0;
int jBegin = 0;
int value = 1;

while (rows > 1 & column > 1)
{
    value = SpirallArr(spirAddArray, value, iBegin, jBegin);
    iBegin++;
    jBegin++;
    rows--;
    column--;
}

ShowArr(spirAddArray);