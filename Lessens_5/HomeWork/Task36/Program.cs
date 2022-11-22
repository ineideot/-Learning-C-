// Задача 36: Задайте массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] NewArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b]");

}

int EvenNumbers(int[] array)
{
    Console.WriteLine("");
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = NewArray(size);
ShowArray(newArray);

Console.WriteLine($"Сумму элементов, стоящих на нечётных позициях: {EvenNumbers(newArray)}.");