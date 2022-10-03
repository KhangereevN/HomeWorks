/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandomMatrix()
{
    Console.Write("Input number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns ");
    int columns = Convert.ToInt32(Console.ReadLine());

    double[,] newArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = Convert.ToDouble(new Random().Next(100, 1000)) / 10;
    return newArray;
}

void ShowMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
                Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double[,] matrix = CreateRandomMatrix();
ShowMatrix(matrix);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Input number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrix()
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(100, 1000);
    return newArray;
}

void Elements(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
}

void AddressElements(int[,] array)
{
    Console.Write("input the address of the row ");
    int index1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("input the address of the column ");
    int index2 = Convert.ToInt32(Console.ReadLine());
    int i = index1 - 1;
    int j = index2 - 1;
    if (index1 <= array.GetLength(0) && index2 <= array.GetLength(1))
    {
        Console.WriteLine(array[i, j]);
    }
    else 
        Console.WriteLine("This element is missing in this array");
}

int[,] matrix = CreateMatrix();
Elements(matrix);
AddressElements(matrix);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Input number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] FillMatrix()
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(10, 100);
    return newArray;
}

void AvgArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("\n");

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avg = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avg += array[i, j];
        }
        avg = avg / rows;
        Console.Write(Math.Round(avg, 2) + "\t");
    }
    Console.WriteLine();
}

AvgArray(FillMatrix());
*/