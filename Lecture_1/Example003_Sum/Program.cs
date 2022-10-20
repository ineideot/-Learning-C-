int numberA = new Random().Next(1, 100); //1 2 3 4 5 6 7 8 9 
Console.Write("Рандомное число а: ");
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 100);
Console.Write("Рандомное число b: ");
Console.WriteLine(numberB);
int numberC = new Random().Next(10, 14);
Console.Write("Рандомное число c: ");
Console.WriteLine(numberC);
int result = numberA + numberB + numberC;
Console.Write("Получаем сумму, стрех случайных, чисел ");
Console.WriteLine(result);