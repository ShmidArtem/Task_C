// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// string[] array = new string[7];

// array[1] = "Понедельник";
// array[2] = "Вторник";
// array[3] = "Среда";
// array[4] = "Четверг";
// array[5] = "Пятница";
// array[6] = "Суббота";
// array[7] = "Воскресенье";

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// if(array[6] = number)
// {
//     Console.WriteLine("Выходной");
// }
// if(array[7] = number)
// {
//     Console.WriteLine("Выходной");
// };


// Console.WriteLine("Введите цифру дня недели");
// int dayNumber = int.Parse(Console.ReadLine()); 

// bool isWeekend = IsWeekend(dayNumber);

// if (IsWeekend)
// {
//     Console.WriteLine("Этот день является выходным.");
// }
// else
// {
//     Console.WriteLine("Этот день не является выходным.");
// }
// static bool IsWeekend(int dayNumber)
// {
//     return dayNumber == 6 || dayNumber ==7;
// };



// if ( day == 1) 
// {
//     System.Console.WriteLine("Понедельник");
// }else if (day == 2)
// {
//     System.Console.WriteLine("Вторник");
// }else if (day == 3)
// {
//     System.Console.WriteLine("Срреда");
// }else if (day == 4)
// {
//     System.Console.WriteLine("Четверг");
// }else if (day == 5)
// {
//     System.Console.WriteLine("Пятница");
// }else if (day == 6)
// {
//     System.Console.WriteLine("Суббота");
// }else if (day == 7)
// {
//     System.Console.WriteLine("Воскресенье");
// }else {
//     System.Console.WriteLine("Больше 1 и меньше 7");
// }

misst: Console.WriteLine("Введите День недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number < 1)
{
    Console.WriteLine("Вам стоит попробовать снова: ");
    goto misst;
}
if (number == 6 || number == 7)
{
    Console.WriteLine("Выходной");
    goto misst;
}
if (number == 5)
{
    Console.WriteLine("Это пятница, завтра выходнной!!");
    goto misst;
}
if (number == 1 || number == 2 || number == 3 || number == 4)
{
    Console.WriteLine("Этот день рабочий!");
    goto misst;
};

