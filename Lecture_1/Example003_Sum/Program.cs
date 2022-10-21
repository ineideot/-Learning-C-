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

// int - хранит целое число от -2147483648 до 2147483647 и занимает 4 байта. Представлен системным типом System.

// new Random().Next - создает случайное число, значения которого варьируются от 0 до меньше Int32. MaxValue. 
// Чтобы создать случайное число, значения которого варьируются от 0 до другого положительного числа, используйте перегрузку Random.

// Int32 - является неизменяемым типом значения, представляющим целые числа со знаком в диапазоне от отрицательного 2 147 483 648 
// (представленного константой Int32. MinValue) до положительного 2 147 483 647 (представленного константой Int32. MaxValue). .