// Собрать строку с числами от а до b, a<=b

string NumberFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i}";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a}" + NumbersRec(a + 1, b);
    else return String.Empty;
}

Console.WriteLine(NumberFor(1, 10));  //Это обычный метод
Console.WriteLine(NumbersRec(1, 10)); //Это рекурсия


Console.WriteLine("---------------------");

//Сумма чисел от 1 до n

int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));

Console.WriteLine("---------------------");

//Факториал числа

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

Console.WriteLine($"Факториал числа 10:{FactorialFor(10)}");
Console.WriteLine($"Факториал числа 5:{FactorialRec(5)}");

Console.WriteLine("---------------------");

//Вычислить а

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{
    // return n==0 ? 1; PowerRec(a,n-1)*a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));
Console.WriteLine(PowerRecMath(2, 10));


Console.WriteLine("---------------------");

// Перебор слов

char[] s = { 'a', 'и', 'с', 'в' };

int count = s.Length;

int n = 1;

for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        Console.WriteLine($"{n++,-5}{s[i]}{s[j]}");
    }
}

Console.WriteLine("---------------------");

void FindWords(string alphabet, char[] word, int lenght = 0)
{
    if (lenght == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[lenght] = alphabet[i];
        FindWords(alphabet, word, lenght + 1);
    }
}

// FindWords("аисв", new char[2]);

// Console.WriteLine("---------------------");

// string path = "/Lecture_1/Example001_HelloConsole";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }


// void CatalogInfo(string path, string indent = "")
// {
//  DirectoryInfo catalogs = new DirectoryInfo(path);
//  foreach (var currentCatalog in catalogs.GetDirectories())
//  {
//  Console.WriteLine($"{indent}{currentCatalog.Name}");
//  CatalogInfo(currentCatalog.FullName, indent + " ");
//  }
//  foreach (var item in catalogs.GetFiles())
//  {
//  Console.WriteLine($"{indent}{item.Name}");
//  }
// }
// string path = @"/Lecture_1/Example001_HelloConsole";
// CatalogInfo(path);

// Console.WriteLine("---------------------");

//Игра в пирамидки

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
 if (count > 1) Towers(with, some, on, count - 1);
 Console.WriteLine($"{with} >> {on}");
 if (count > 1) Towers(some, on, with, count - 1);
}

