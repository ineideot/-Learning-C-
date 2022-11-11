// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

void Polidrom(int num)
{
    int numOld = num;
    int numNew = 0;

    while (num > 0)
    {
        numNew = (num % 10) + (numNew * 10);
        num = num / 10;
    }

    if (numNew != numOld)
    {
        Console.Write($"{numOld} Не является палиндром числа {numNew} ");

    }
    else
    {
        Console.Write($" Число {numNew} палиндром числа {numOld} :-) ");
    }
};

while (true)
{
    Console.Write("Введите пятизначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num >= 10000 && num <= 99999)
    {
        Polidrom(num);
        break;
    }
    else
    {
        Console.Write($" ");
    };

}