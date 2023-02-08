//перевод float в int с округлением кратном "5"
int IntToFive (float a)
{
    int b;
    float c = a%5;

    b = (int)(a / 5) * 5;

    if (c >= 2.5) b += 5;

    return b;
}

// исходные числа
float a = 27f;
float b = 27.8f;
float c = 41.7f;

// итог
Console.WriteLine(IntToFive(a));
Console.WriteLine(IntToFive(b));
Console.WriteLine(IntToFive(c));