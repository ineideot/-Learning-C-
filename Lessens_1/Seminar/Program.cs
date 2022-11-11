/*
Console.WriteLine("Good evening! "); //Строка записи консоли в () и затем в "" пишем сообщение для пользователя.
Console.Write("Input int number: ");

int num = Convert.ToInt32(Console.ReadLine());  // Переносим из правой стороны( то чtо написал пользователь в консоль) в левую.

Console.WriteLine(num);                                           // Просто выводится значение "num".
Console.WriteLine("Its new number " + num + " and its good");     // " + num + "
Console.WriteLine($"Its new number {num} and its good");          // {num} - одно и тоже, если в начаале поставить символ $.
*/

//Задача.1. Напишите программу, которая на вход принемает число и выводит его квадрат (число умноженное на само себя).

/*
Console.Write("Input int number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine($"Quard of {num} is {result}");
Console.WriteLine("Thanks");
*/

//Задача.2. Напишите программу, которая на входе принемает два числа и проверяет, является ли первое чистио квадратом второго.

/*
Console.Write("Input ferst number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2*num2){
    Console.WriteLine($"{num1} is quard of {num2}");
}
else{
    Console.WriteLine($"{num1} is not quard of {num2}");
}
*/

//Задача.3. Напишите программу, которая на вход принемает число (N), а на выходе показывает все целые числа в промежутке от (-N) до (N).

/*
Console.Write("Input int number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = (-1) *num;

while (current <= num){
    Console.Write(current + " ");
    current++;
}
*/

//Задача.4. Напишите программу, которая на вход принемает трехзначное число и на выходе показывает последнюю цифру этого числа.

//357 / 100 -> 3   / Деление нацело
//357 % 100 -> 57  % Деление с остатком
//357 % 10 -> 7    % Деление с сстатком

/*
Console.Write("Input chree-digit int number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 10;
Console.WriteLine($"Last digit of {num} is {result}");
*/

//Задача.4.1. Выести цифру 8 из числа 457894

/*
Console.WriteLine("Просто вывожу число 8");
int num = 457894;


int result = (num / 100) % 10;
Console.WriteLine($"Вывожу на экран число {result}");
*/
