/*
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Input number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] newArray = new int[rows, columns];

Create2dArray(newArray);
ShowArray(newArray);

int[,] Create2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 100);
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < newArray.GetLength(1) - 1; k++)
            {
                if (newArray[i, k] < newArray[i, k + 1])
                {
                    int temp = 0;
                    temp = newArray[i, k];
                    newArray[i, k] = newArray[i, k + 1];
                    newArray[i, k + 1] = temp;
                }
            }
        }
    }
}
Console.WriteLine();
ShowArray(newArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] Create2dArray()
{
    Console.Write("Input number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = new Random().Next(1, 100);
    return newArray;
}

void MinSumArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    int sum = 0;
    int minSum = 0;
    int index = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[0, j];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            minSum += array[i, j];
        }
        if (minSum < sum)
        {
            sum = minSum;
            index = i;
        }
        minSum = 0;
    }
    Console.WriteLine($"min sum in {index+1} row ({sum})" );

}
MinSumArray(Create2dArray());


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Console.Write("Input number of rows1 ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns1 ");
int columns1 = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[rows1, columns1];

int[,] CreateMatrix1(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write("A[{0},{1}] = ", i, j);
            A[i, j] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
    }
    return matrixA;
}

Console.Write("Input number of rows2 ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns2 ");
int columns2 = Convert.ToInt32(Console.ReadLine());
int[,] matrixB = new int[rows2, columns2];

int[,] CreateMatrix2(int[,] B)
{
    for (int i = 0; i < B.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            Console.Write("B[{0},{1}] = ", i, j);
            B[i, j] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
    }
    return B;
}

int[,] Multi(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.Write("Error");
    }
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

void PrintArray(int[,] C)
{
    for (int i = 0; i < C.GetLength(0); i++)
    {
        for (int j = 0; j < C.GetLength(1); j++)
        {
            Console.Write(C[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
CreateMatrix1(matrixA);
Console.WriteLine();
CreateMatrix2(matrixB);
Console.WriteLine();
int[,] C = Multi(matrixA, matrixB);
PrintArray(C);


//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Write("Input number of rows ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of layers ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] newArray = new int[z, y, x];

int[,,] Create3dArray(int[,,] array)
{
    int N = 10;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (N > 9 && N < 100)
                    array[i, j, k] = new Random().Next(N, N += 1);
                else
                    array[i, j, k] = new Random().Next(N);
            }

    return array;
}

void ShowArray(int[,,] array)
{
    
    for (int k = 0; k < array.GetLength(0); k++)
    {
        Console.WriteLine("Layer " + (k+1));
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < array.GetLength(2); i++)
            {
                Console.Write(array[k, j, i] + "\t");
                Console.Write($"({k},{j},{i}) \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
Create3dArray(newArray);
ShowArray(newArray);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Write("Input number of rows and columns ");
int sqr = Convert.ToInt32(Console.ReadLine());
int[,] square = new int[sqr, sqr];

int i = 0;
int j = 0;
int count = 1;

while (count <= square.GetLength(0) * square.GetLength(1))
{
    square[i, j] = count;
    count++;
    if (i <= j + 1 && i + j < square.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= square.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > square.GetLength(1) - 1)
        j--;
    else
        i--;
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j].ToString("00") + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

ShowArray(square);
*/