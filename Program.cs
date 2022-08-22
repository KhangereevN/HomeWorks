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


