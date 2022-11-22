// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма отрицательных равна -20.

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

// int FindNegativeSum(int[] array)
// {
//     Console.WriteLine("");
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             sum += array[i];
//         }
//     }
//     return sum;
// }

// int size = 12;
// int min = -9;
// int max = 9;

// int[] newArray = CreatNewArray(size, min, max);
// ShowArray(newArray);

// Console.WriteLine($"Sum of negative elements is {FindNegativeSum(newArray)}");




// Напишите программу замены элементов массива: положительные элементы замените 
// на соответствующие отрицательные,и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}  ");
//     }
//     Console.WriteLine("");
// }

// int[] RewriteArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

// Console.Write("Input count of elements of array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input min scope: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input max scope: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreatNewArray(size, min, max); // Создаём массив с помощью метода

// ShowArray(newArray); // Показали исходный массив

// RewriteArray(newArray); //Преоброзовали знаки

// ShowArray(newArray); // Показать резуьтат


// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное 
// число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] CreatNewArray(int size, int minVal, int maxVal)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minVal, maxVal + 1);
//     }
// //     return array;
// // }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}  ");
//     }
//     Console.WriteLine("");
// }

// bool FindElement(int num, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// int[] array = { 5, 7, 19, 345, 3 }; 


// Console.Write("Input number for search: ");
// int number = Convert.ToInt32(Console.ReadLine());

// bool result = FindElement(number, array);

// if (result == true)
// {
//     Console.Write($"{number} consist in array");
// }
// else
// {
//     Console.Write($"{number} do not consist in array");
// }


// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//  Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] CreatNewArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine("");
}

int NewArraySize(int size_start)
{
    int sieze_end = 0;
    if (size_start % 2 == 0)
    {
        sieze_end = size_start / 2;
    }
    else
    {
        sieze_end = size_start / 2 + 1;
    }
    return sieze_end;
}

int[] Multi(int[] array)
{
    int end_size = NewArraySize(array.Length);
    int[] newArrayMulti = new int[end_size];
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1 - i)
        {
            newArrayMulti[i] = array[i];
        }
        else
        {
            newArrayMulti[i] = array[i] * array[array.Length - 1 - i];
        }
    }
    return newArrayMulti;
}


int[] start_array = CreatNewArray(6, -6, 6);

ShowArray(start_array);

// int new_size = NewArraySize(6);

int [] finish_array = Multi(start_array);