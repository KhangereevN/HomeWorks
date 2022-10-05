/*
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void NumbersDiap(int M, int N)
{   
    int max = 0;
    int min = 0;
    if (N > M) 
    {
        max = N;
        min = M;
    }
    else 
    {
        max = M;
        min = N;
    }
    Console.Write(min + " ");
    if (min != max) NumbersDiap(min + 1, max);

}
Console.Write("Input number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int N = Convert.ToInt32(Console.ReadLine());

NumbersDiap(M, N);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumDiap(int M, int N)
{
    int min = 0;
    int max = 0;

    if (N > M) 
    {
        max = N;
        min = M;
    }
    else 
    {
        max = M;
        min = N;
    }

    if (min == 0) return (max * (max + 1)) / 2;
    else if (max == 0) return (min * (min + 1)) / 2;
    else if (min == max) return min;
    else if (min < max) return max + SumDiap(min, max - 1);
    else return max + SumDiap(min, max + 1);
}

Console.Write("Input number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write(SumDiap(M, N));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackermann(int m, int n)
{
    if (m != 0 && n == 0) return Ackermann(m - 1, 1);
    if (m == 0) return n + 1;
    if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
    return Ackermann(m, n);
}
Console.Write("Input possitive number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input possitve number n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Ackermann(n, m));
*/