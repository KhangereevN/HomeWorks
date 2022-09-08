/*
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Checknumber (string num)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
         Console.WriteLine ($" Число {num} является палиндромом");
    }
    else 
    {
        Console.WriteLine ($" Число {num} не является палиндромом");
    }
}
    
Console.WriteLine("Введите пятизначное число ");
int num1 = Convert.ToInt32(Console.ReadLine());
string num2 = Convert.ToString(num1);
if (num2.Length == 5)
    {
    Checknumber (num2);
    }
    else
    {
        Console.WriteLine ("Введите корректное число");
    } 


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dx = x2 - x1;
    double dy = y2 - y1;
    double dz = z2 - z1;
    double dis = Math.Sqrt((dx * dx) + (dy * dy) + (dz*dz));
    return dis;

}
Console.WriteLine("input x coordinate 1");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input y coordinate 1");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input z coordinate 1");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input x coordinate 2");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input y coordinate 2");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input z coordinate 2");
double z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"the distance between two points ({x1},{y1},{z1})({x2},{y2},{z2}), is equal to {distance (x1, y1, z1, x2, y2, z2)}");

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int n)
{
    int i = 1;
    while (i <= n)
    {Console.WriteLine ($"Куб числа {i} равен {i*i*i}");
    i++;
    }
}
Console.WriteLine ("input number");
int cub = Convert.ToInt32(Console.ReadLine());
Cube(cub);
*/