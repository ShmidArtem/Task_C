// Задача 6. Напишите программу, которая 
// на вход принимает число 
// и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите натуральное число");
// int number = Convert.ToInt32(Console.ReadLine());


Console.Write("Напишите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine($"{num} - Число нечетное");
}
else
{
    Console.WriteLine($"{num} - Число четное");
}








