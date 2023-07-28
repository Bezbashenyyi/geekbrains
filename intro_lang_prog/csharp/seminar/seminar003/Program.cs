// Семинар 3.

// Теория.

// Возведение в степень Math.Pow(число, степень)
// Извлечение квадратного корня Math.Sqrt(число)
// Округление до N знаков после запятой Math.Round(double число, N)

// Примеры:
// Console.WriteLine(Math.Pow(5, 2));
// Console.WriteLine(Math.Sqrt(25));
// Console.WriteLine(Math.Round(Math.Sqrt(24), 2));


/*
// Напишите программу, которая принимает на вход координаты
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
// плоскости, в которой находится эта точка.

int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

bool ChekNull(int abs, int ord)
{return abs == 0 || ord == 0;}

int Quad(int abs, int ord)
{
    if (abs > 0 && ord > 0) return 1;
    if (abs < 0 && ord > 0) return 2;
    if (abs < 0 && ord < 0) return 3;
    return 4;
}

Repeat:
int x = WriteWait("Введите координату x: ");
int y = WriteWait("Введите координату y: ");

if (ChekNull(x, y))
{
    Console.WriteLine("Некорректный ввод, пожалуйста введите ещё раз.");
    goto Repeat;
}

else Console.WriteLine ($"Координаты лежат в {Quad(x, y)} квадранте");
*/


// Напишите программу, которая принимает на вход число (N)
// и выдаёт квадраты чисел от 1 до N.

int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}




// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.