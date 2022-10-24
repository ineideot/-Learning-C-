//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6


Console.Write("Input natural number: ");
uint nNumber = Convert.ToUInt16(Console.ReadLine());

string nNumberText = Convert.ToString(nNumber);

if (nNumberText.Length > 2)
{
    Console.WriteLine("Third digit: " + nNumberText[2]);
}
else
{
    Console.WriteLine("No third digit");
}