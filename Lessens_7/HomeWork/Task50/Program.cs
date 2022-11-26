// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] Create2dArr()
{

    Console.Write("Введите количество строк: ");
    int row = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int column = Convert.ToInt32(Console.ReadLine());

    int[,] CreatArr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            CreatArr[i, j] = new Random().Next(0, 20);
        }
    }
    return CreatArr;
}

int[,] FillMatrix(int[,] arr)
{
    Console.Write("Номер искомой строки (отсчет с нуля): ");
    int rowNum = Convert.ToInt32(Console.ReadLine());

    Console.Write("Номер искомого столбца (отсчет с нуля): ");
    int colNum = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Ищем число с позицией [{rowNum}, {colNum}]");


    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr.GetLength(0) < rowNum)
        {
            Console.Write($"Чисел с индексом [ {rowNum}, {colNum} ] нет \n");
            break;
        }
        for (int j = 0; j <= arr.GetLength(1); j++)
        {
            if (arr.GetLength(1) - 1 < colNum)
            {
                Console.Write($"Чисел с индексом [ {rowNum}, {colNum} ] нет \n");
                break;
            }
           if (i == rowNum && j == colNum)
            {
                Console.Write($"В {i} ряду найдено число: {arr[i, j]} \n");
                break;
            }
            else if (j == arr.GetLength(1))
            { 
                Console.Write($"В {i} ряду числа с индексом [ {rowNum}, {colNum} ] нет \n");
                break;
            }
        }
    }
    return arr;
}

void show2Arr(int[,] arr)
{  
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] addArray = Create2dArr();
show2Arr(addArray);
int[,] calcArray = FillMatrix(addArray);