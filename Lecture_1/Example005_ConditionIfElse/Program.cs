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

// Здесь мы используем ветвление if/else, что дает нам возможность при разных исходных данных получать разные результаты.
// ToLower() - Преобразует значение символа Юникода в его эквивалент в нижнем регистре.