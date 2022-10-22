int[] array = new int[12]; //new new int[12] - создай новый массив в котором будет 12 элементов


void FillArray(int[] collection)  //Создадим пустой масив с именем collection.
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 19);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Indexof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


FillArray(array);
array[4]= 4;
array[5]= 4;
PrintArray(array);
Console.WriteLine();

int pos = Indexof(array, 4);
Console.WriteLine(pos);