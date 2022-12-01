// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7


int[,] CreateArray(int row, int col)
{
    int[,] newArray = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            newArray[i, j] = new Random().Next(0, 10);
        }
    }
    return newArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3}");
        }
        Console.WriteLine();
    }
}

int[] SummRows(int[,] array)
{
    int[] calcArr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        Console.WriteLine($"Сумма значений в {i + 1} строке: {sum} ");
        calcArr[i] = sum;
    }
    return calcArr;
}

Console.Write("Количество строк в массиве: ");
int lenArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов в массиве: ");
int widthArray = Convert.ToInt32(Console.ReadLine());

int[,] addArray = CreateArray(lenArray, widthArray);
ShowArray(addArray);

int[] sumArray = SummRows(addArray);
int min = sumArray[0];

int minIdx = 0;
for (int i = 1; i < sumArray.Length; i++)
{
    if (sumArray[i] < min)
    {
        min = sumArray[i];
        minIdx = i;
    }
}

Console.Write($"Номер строки,где сумма значений наименьшая: {minIdx + 1}");