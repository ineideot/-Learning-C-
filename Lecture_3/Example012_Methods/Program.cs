//Метод который ничего не принемает и нечего не возврощает
void Method1()
{
    Console.WriteLine("Просто текст");
}
Method1();


//Метод который что-то принемает, но ничего не возврощает
void Method2(string message)
{
    Console.WriteLine(message);
}
Method2("1234");
Method2("Text");

void Method21(string message, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(message);
        i++;
    }

}
Method21("Text for you", 4);
Method21(message: "Text for me", count: 2);
Method21(count: 5, message: "Text for yo");

//Методы которые, что-то возврощают, но ничего не принемают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//Методы которые что-то принемают и что-то возвращают

//string Method4(int count, string c)
//{
//   int i = 0;
//    string result = ""; //String.Empty = ""
//
//    while (i < count)
//    {
//        result = result + c;
//        i++;
//    }
//    return result;
//}

//string res = Method4(10, "qwerty");
//Console.WriteLine(res);

string Method4(int count, string c)
{
    string result = ""; //String.Empty = ""
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}

string res = Method4(10, "qwerty");
Console.WriteLine(res);

for (int i = 2; i < 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

//Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
//заменить большими «К», а большие «С» заменить на маленькие «с».

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValve, char newValve)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValve) result = result + $"{newValve}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);


int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 12, 42, 5, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array [ i ]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = 1;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);