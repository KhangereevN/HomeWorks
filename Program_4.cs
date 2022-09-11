/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Degree(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}
Console.Write("Input number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int DegreeNum = Degree(numA, numB);
Console.WriteLine("A в степени B = " + DegreeNum);


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int num)
{
    int dec = 0;
    while (num > 0)
    {
       int ed = num % 10;
        dec = ed + dec;
        num = num / 10;
    }
    return dec;
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = Sum(num);
Console.WriteLine($"Сумма цифр числа {num} равно {sum}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreateArray (int A)
{
    int [] arr = new int [A];
    for (int i = 0; i < A; i++)
    {
        arr [i] = new Random().Next(A);
    }
    return arr;
}
void PrintArray (int [] arr)
{ 
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write ($"{arr[i]}, ");
    }
    Console.WriteLine("\b\b]");
}
PrintArray(CreateArray(8));
*/