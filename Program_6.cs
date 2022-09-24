// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
Console.Write("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];

int Positive (int [] massive)
{
    int positive = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write($"введите {i+1} число: ");
        massive[i] = Convert.ToInt32(Console.ReadLine());
        if (massive[i] > 0)
        {
            positive++;
        }
    }
    return positive;
}
Console.WriteLine($"Пользователь ввел чисел больше 0 => {Positive(massive)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)
Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
Console.WriteLine($"Пересечение двух прямых в точке с координатами X: {x}, Y: {y}");

*/