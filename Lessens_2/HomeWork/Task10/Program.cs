//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Input triple digits ");
int num = Convert.ToInt32(Console.ReadLine());

void SearchTwoDigit(int arg1)
{
int result = ((arg1- (arg1 /100 * 100))- arg1 %10)/ 10;
Console.WriteLine($"Second digit {result}");
}

SearchTwoDigit(num);