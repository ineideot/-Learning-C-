//Напишите программу, которая выводит случайное число из отрезка [10, 90] и показывает наибольшую цифру числа.

/* Так решил я.

int num = new Random().Next(10, 100);
Console.WriteLine($"Рандомное число: {num}");

int ferst = num / 10;
Console.WriteLine($"Первая цифра числа: {ferst}");

int second = num % 10;
Console.WriteLine($"Вторая цифра числа: {second}");

if (ferst > second)
{
    Console.WriteLine($"Наибольшая цифра числа: {ferst}");
}
else
{
    Console.WriteLine($"Наибольшая цифра числа: {second}");
}
*/

/*Так решил преподователь, через метод.

int FindBiggestDigit (int number)
{
    int ed = number % 10;
    int dec = number / 10;
    int result;

    if (ed > dec)
    {
        result = ed;
    }
    else
    {
        result = dec;
    }
    return result;
}

int randNum = new Random().Next(10, 100);
int biggestDigit = FindBiggestDigit(randNum);

Console.WriteLine($"The biggest digit of {randNum} is {biggestDigit}");
*/

//Напишите программу, которая вводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/* Так решил я.
int number = new Random().Next(100, 1000);
int ferst = number / 100;
int third = number %10;

Console.WriteLine($"Получили {number}, где первое число {ferst} ,а третье число {third}");
*/

/* Так решил преподователь.
int Delet(int num)   //int num - внутренняя переменная самой функции, в которую она принимает просимое значание.
{
    int dig1 = num / 100;
    int dig3 = num % 10;
    int res = dig1 * 10 + dig3;
    return res;
}

int randNum = new Random().Next(100, 1000);
int result = Delet(randNum);

Console.WriteLine($"Result of convertation {randNum} is {result}");
*/

/*Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1,
то программа выводит остаток от деления. */
/* Так решил я
void Find(int num1, int num2)
{
    int resMul = num2 % num1;
    if (resMul == 0)
    {
        Console.WriteLine($"{num2} кратно {num1}");
    }
    else
    {
        Console.WriteLine($"Остаток от деления {num2} на {num1} будет {resMul}");
    }

}

//int randNum1 = new Random().Next(10, 100);
Console.Write("Напишите первое число ");
int randNum1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите второе число ");
int randNum2 = Convert.ToInt32(Console.ReadLine());
//int randNum2 = new Random().Next(10, 100);
Find(randNum1, randNum2);
*/

//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

/* Так решил я
void Find(int arg1, int arg2, int arg3)
{
    if (arg1 % arg2 == 0 & arg1 % arg3 == 0)
    {
        Console.WriteLine($"{arg1} multiple {arg2} and {arg3}");
    }
    else
    {
        Console.WriteLine($"{arg1} not multiple {arg2} and {arg3}");
    }

}
Console.Write("Input ferst number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number ");
int b = Convert.ToInt32(Console.ReadLine());
Find(num1, a, b);
*/

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/* Так решил я
void Square(int arg1, int arg2)
{
    if (arg1 * arg1 == arg2)
    {
        Console.WriteLine($"{arg2} square {arg1}");
    }
    else
    {
        Console.WriteLine($"{arg2} is not a square {arg1}");
    }
    if (arg2 * arg2 == arg1)
    {
        Console.WriteLine($"{arg1} square {arg2}");
    }
    else{
        Console.WriteLine($"{arg1} is not a square {arg2}");
    }
}

Console.Write("Input ferst number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
Square(num1, num2);
*/
/* Новый метод с использованием @bool@
bool Find(int arg1, int arg2)
{
    if (arg1 == arg2 * arg2 || arg2 == arg1 * arg1)  // || - или(or)
        return
        true;
    else return
    false;
}

Console.Write("Input ferst number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = Find(num1, num2);
if (result)
{
    Console.WriteLine("One of the numbers is square of another number.");
}
else
{
    Console.WriteLine("No one of the numbers is square of another number.");
}
*/

// Ещё пример с bool
/*
bool CheckNumbers(int x, int a, int b)
{
    if (x % a == 0 & x % b == 0)   // & - и (and)
    {
        return true;
    }
    else return false;
}
Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number ");
int numberB = Convert.ToInt32(Console.ReadLine());

bool result = CheckNumbers(number, numberA, numberB);
if (result)
{
    Console.WriteLine($"The number {number} is multiply {numberA} and {numberB}");
}
else
{
    Console.WriteLine($"The number {number} is not multiply {numberA} and {numberB}");
}
*/