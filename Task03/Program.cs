// Задача 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.


Console.WriteLine("Введите день недели");

int day = Convert.ToInt32(Console.ReadLine()); 

if ( day == 1) 
{
    System.Console.WriteLine("Понедельник");
}
else if (day == 2)
{
    System.Console.WriteLine("Вторник");
}
else if (day == 3)
{
    System.Console.WriteLine("Срреда");
}
else if (day == 4)
{
    System.Console.WriteLine("Четверг");
}
else if (day == 5)
{
    System.Console.WriteLine("Пятница");
}
else if (day == 6)
{
    System.Console.WriteLine("Суббота");
}
else if (day == 7)
{
    System.Console.WriteLine("Воскресенье");
}
else {
    System.Console.WriteLine("Больше 1 и меньше 7");
}