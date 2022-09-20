/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int A, int minVal, int maxVal)
{
    int[] arr = new int[A];
    for (int i = 0; i < A; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal+1);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("\b\b]");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            {
                Console.WriteLine($"Число {arr[i]} четное");
            }
        else
        {
        Console.WriteLine($"Число {arr[i]} нечетное");
        }
    }
}
PrintArray(CreateArray(5, 100, 999));

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int B)
{
    int[] arr = new int[B];
    for (int i = 0; i < B; i++)
    {
        arr[i] = new Random().Next(-10, 11);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("\b\b]");
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0)
        {
            sum = sum + arr[i];
        }
    }
Console.Write($"Sum of odd number is {sum}");
}
PrintArray(CreateRandomArray(5));


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] RandomArray(int С)
{
    double[] arr = new double[С];
    for (int i = 0; i < С; i++)
    {
        arr[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
    return arr;
}
void Difference(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}; ");
    }
    Console.WriteLine("\b\b]");
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    Console.WriteLine($"max = {max}, min = {min}, difference = {max - min}");
}
Difference(RandomArray(6));
*/