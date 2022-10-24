//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.Write("Input the day of the week: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int numberDay) {
  if (numberDay == 6 || numberDay == 7) {
  Console.WriteLine("Yes it's a holiday");
  }
  else if (numberDay < 1 || numberDay > 7) {
    Console.WriteLine("Total in a week 7 days. Try again!");
  }
  else Console.WriteLine("No it's not a holiday");
}
CheckingTheDayOfTheWeek(numberDay);