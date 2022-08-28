/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int ThirdDigitNumber(int num)
{
    int first = num / 10;
    int second = first % 10;
    int result = second;
    return result;
}
Console.Write("Input third digit number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int second = ThirdDigitNumber(num1);
Console.WriteLine ($"Из числа {num1} вторая цифра {second} ");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
string number1 = Convert.ToString(number);
if (number1.Length > 2)
{
  Console.WriteLine($"третья цифра {number1[2]}");
}
else 
{
  Console.WriteLine("третья цифра отсутствует");
}

*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.Write("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
void Weekend (int day)
{
   if (day == 6 || day == 7)
   {
    Console.WriteLine("Этот день является выходным");
   }
    else if (day <1 || day >7) 
    {
    Console.WriteLine("Это число не обозначает день недели");
    }
    
else 
 Console.WriteLine (" Этот день не является выходным");
}

Weekend(day);
*/
