// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223 -> 4

void GreaterThanZero()
{
    Console.WriteLine("Вводите любые числа. Для выхода напишите 911.");
    int count = 0;
    int num = 0;
    while (num != 911)
    {
        Console.Write("Введи число: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num > 0 && num != 911)
        {
            count++;
        }
        else if (num == 911)
        {
            Console.WriteLine($"Всего введено {count} чисел больше нуля.");
            break;
        }
    }
}

GreaterThanZero();