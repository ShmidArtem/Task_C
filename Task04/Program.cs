﻿// Задача 4: Напишите программу, которая 
// принимает на вход три числа и выдаёт максимальное
// из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


System.Console.Write("Введите первое число: ");
int num1 = Int32.Parse(Console.ReadLine()!);

System.Console.Write("Ведите второе число: ");
int num2 = Int32.Parse(Console.ReadLine()!);

System.Console.Write("Ввелдите третье число: ");
int num3 = Int32.Parse(Console.ReadLine()!);

int max = num1;

if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
System.Console.WriteLine($"Максимальное из трех чисел: {max}");