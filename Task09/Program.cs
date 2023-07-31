// Задача 9. Напишите программу, которая
// 1. выводит случайное число из отрезка [10, 99] и
// 2. показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 : {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// Вариант 1
// Console.WriteLine("Первый способ: ");
// if (firstDigit > secondDigit)
//     Console.WriteLine($"Наибольшая цифра цикла: {firstDigit}");
// else
//     Console.WriteLine($"Наибольшая цифра цикла: {secondDigit}");


// Вариант 2
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
                                    
// Console.WriteLine("Второй способ: ");
// Console.WriteLine($"Наибольшая цифра цикла: {maxDigit}");

// Методы в функции всегда с большой буквы

int result = MaxDigit(number);

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}
Console.WriteLine($"Наибольшая цифра цикла: {result}");







