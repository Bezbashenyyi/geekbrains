/*
// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/

int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

void Counting(int inTotal)
{
    int count = 0;

    for (int i = 0; i < inTotal; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");

        if ((Convert.ToInt32(Console.ReadLine()) > 0))
            count++;
    }

    Console.WriteLine("Вы ввели положительных чисел: " + count);
}

Console.WriteLine("Программа подсчитывает количество введённых положительных чисел.\n");
int howMany = WriteWait("Сколько чисел собираетесь ввести? ");
Counting(howMany);
