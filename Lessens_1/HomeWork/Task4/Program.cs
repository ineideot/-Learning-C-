/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44, 5, 78 -> 78
22, 3, 9 -> 22
*/

Console.WriteLine("Which of the three numbers is greater?");
Console.Write("Input ferst number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 >= max && num2 >= num3)           //&& Логический оператор AND ( && ) возвращает значение true , 
{                                          //если оба операнда являются и возвращаются true false в противном случае. 
    max = num2;                            //Операнды неявно преобразуются в тип bool перед вычислением, а результат
}                                          // имеет тип bool . Логическое И имеет ассоциативность в направлении слева направо.
else if (num3 >= max && num3 >= num2)
{
    max = num3;
}

Console.WriteLine($"The biggest {max}.");
