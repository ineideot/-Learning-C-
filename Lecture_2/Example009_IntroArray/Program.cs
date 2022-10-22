int[] array = { 1, 22, 13, 54, 2, 63, 17, 6};

int Max1(int arg1, int arg2, int arg3, int arg4)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    if (arg4 > result) result = arg4;
    return result;
}

int Max2(int arg1, int arg2)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    return result;
}

int max = Max2(
    Max1(array[0], array[1], array[2], array[3]),
    Max1(array[4], array[5], array[6], array[7])
);

Console.WriteLine($"Максимум {max}"); 
