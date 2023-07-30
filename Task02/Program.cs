// 2. Напишите программу, котораая на вход принимает два числа 
// и выдает, како число больше, а какое меньше.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10 
// a = -9; b = -3 -> max -3


System.Console.Write("Первое число: ");
int num1 = Int32.Parse(Console.ReadLine()!);

System.Console.Write("Второе число: ");
int num2 = Int32.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    System.Console.WriteLine($"Наибольшее число: {num1}");
}
if (num2 > num1)
{
    System.Console.WriteLine($"Наибольшее число: {num2}");
}