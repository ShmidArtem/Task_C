// Задача 7. Напишите программу, которая принимает на вход
// трехзначное число и на входе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number *= -1;
}
if (number >= 100 && number <= 999)
{
    int result = number % 10;
    //int result2 = number / 100; // Первая цифра трехзначного числа
    // int result3 = number /10 % 10; // Вторая цивра трехзначного числа
    Console.WriteLine($"Последняя цифра числа: {result}");
}
else
{
    Console.WriteLine("Число не трехзначное");
}
