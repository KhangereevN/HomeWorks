/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
{
    Console.Write($"число {num1} большее, число {num2} меньшее");
}
else
{
     Console.Write($"число {num2} большее, число {num1} меньшее");
}
*/

/*
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num2 > num1 && num2 > num3)
{
    Console.Write($"max {num2}");
}
else if (num3 > num2 && num3 > num1)
{
    Console.Write($"max {num3}");
}
else
{
    Console.Write($"max {num1}");
}
*/

/*
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.Write($"Число {num} - четное");
}
else
    Console.Write($"Число {num} - нечетное");
*/

/*
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;

while (current <= num)
{   
    if (current % 2 == 0)
    {
        Console.Write(current + " ");
        current++;
    }
    else current++;
}
*/