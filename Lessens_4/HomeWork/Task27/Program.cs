// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumOfNumbersInNumber(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}

while (true)
{
    Console.Write("Введите положительное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        Console.WriteLine($"Cумма цифр в числе {num} : {SumOfNumbersInNumber(num)}");
        break;
    }
    else
    {
        Console.Write("Вам надоест первому. ");
    };
}

