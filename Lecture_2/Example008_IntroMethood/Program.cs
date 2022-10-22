/*
Стихийный метод
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 223;
int c3 = 33;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);
*/

// Метод/функция (Max and Max2). Помогает найти максимум.

int a1 = 15;
int b1 = 21;
int c1 = 10;
int d1 = 10;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int d2 = 10;
int a3 = 13;
int b3 = 23;
int c3 = 76;
int d3 = 10;
int a4 = 13;
int b4 = 23;
int c4 = 39;
int d4 = 10;
int a5 = 12;
int b5 = 23;
int c5 = 37;
int d5 = 10;

int Max(int arg1, int arg2, int arg3, int arg4, int arg5)  //Оказывается это и есть функция...
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    if (arg4 > result) result = arg4;
    if (arg5 > result) result = arg5;
    return result;
}

int Max2(int arg1, int arg2, int arg3, int arg4)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    if (arg4 > result) result = arg4;
    return result;
}

//int max1 = Max2(a1, b1, c1, d1);
//int max2 = Max2(a2, b2, c2, d2);
//int max3 = Max2(a3, b3, c3, d3);
//int max4 = Max2(a4, b4, c4, d4);
//int max5 = Max2(a5, b5, c5, d5);
//int maxx = Max(max1, max2, max3, max4, max5);

int maxx = Max(
    Max2(a1, b1, c1, d1), 
    Max2(a2, b2, c2, d2), 
    Max2(a3, b3, c3, d3), 
    Max2(a4, b4, c4, d4), 
    Max2(a5, b5, c5, d5)
);

//Console.WriteLine(max1);
//Console.WriteLine(max2);
//Console.WriteLine(max3);
//Console.WriteLine(max4);
//Console.WriteLine(max5);
//Console.WriteLine($"А самое большое из всех будет {maxx}");

Console.WriteLine($"А самое большое из всех {maxx}");