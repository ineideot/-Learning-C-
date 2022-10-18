Console.Write("Введите ваше имя ");
string username = Console.ReadLine();

if (username.ToLower() == "денис")
{
    Console.WriteLine("Ура, это же Денис!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}