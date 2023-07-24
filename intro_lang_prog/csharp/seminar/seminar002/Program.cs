int MaxNum(int num)
{
    int tens = num / 10;
    int unit = num % 10;
    if (tens < unit) return unit;
    else return tens;
}

int randNumber = new Random().Next(10, 100);

Console.WriteLine($"В числе {randNumber} наибольшая цифра: {MaxNum(randNumber)}");