int[] array = { 51, 21, 33, 82, 52, 63, 17, 82 };

int n = array.Length;
int find = 82;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

