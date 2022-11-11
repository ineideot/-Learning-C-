// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void SquareOfNumbers(int num)
{
    if (num <= 0)
        Console.WriteLine("Натуральные числа - это числа, возникающие естественным образом при счёте (1, 2, 3, 4, 5, 6, 7 и так далее). Попробуйте ещё раз.");
    else
    {
        int i = 1;
        int num1;
        Console.Write($"Таблица кубов чисел от 1 до {num}: ");
        while (i < num + 1)
        {
            num1 = (i * i * i);
            Console.Write($"{num1} ");
            i++;
        }
        Console.Write(".");
    }
}

Console.Write("Введите натуральное число:");
int num = Convert.ToInt32(Console.ReadLine());

SquareOfNumbers(num);